using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace App
{
    public partial class MainForm : Form
    {
        private delegate void OnSuccessDelegate(Models.StaticMd.Image image);
        private delegate void OnErrorDelegate(string message);
        private delegate void OnCompleteDelegate();
        private delegate void OnImageDelegate(Image image);

        // Copy as methods
        private enum MenuCopyAs { Text, BBCode, HTML }

        // App settings
        private App.Properties.Settings appSettings;

        // Upload service instance
        private Service.Upload uploadService;

        // Ctrl+PrtScr keyboard instance
        private Helpers.KeyboardHook.KeyboardHook hookKeyCtrlPrtScr = new Helpers.KeyboardHook.KeyboardHook();

        // Constructor
        public MainForm()
        {
            InitializeComponent();

            // Set app settings
            this.appSettings = App.Properties.Settings.Default;

            // Set form icon
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // Set tray icon
            this.mainNotifyIcon.Icon = this.Icon;
            this.mainNotifyIcon.Visible = true;

            // Init upload service
            this.uploadService = new Service.Upload();
            this.uploadService.onSuccess(new Service.Upload.SuccessCallback((Models.StaticMd.Image image) => this.Invoke(new OnSuccessDelegate(this.onSuccess), image)));
            this.uploadService.onError(new Service.Upload.ErrorCallback((string message) => this.Invoke(new OnErrorDelegate(this.onError), message)));
            this.uploadService.onComplete(new Service.Upload.CompleteCallback(() => this.Invoke(new OnCompleteDelegate(this.onComplete))));
            this.uploadService.onImage(new Service.Upload.ImageCallback((Image image) => this.Invoke(new OnImageDelegate(this.onImage), image)));

            // Set open file dialog filter
            this.uploadOpenFileDialog.Filter = this.generateOpenFileDialogFilterByAcceptedExtensions();

            // Register global hot keys
            this.registerGlobalHotKeys();

            // Append app version to main form
            this.Text += " | " + Application.ProductVersion;
        }


        // Override: WndProc and receive WM_ACTIVATE_ME message
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == Helpers.SingleInstance.WM_ACTIVATE_ME)
            {
                this.Visible = true;
                this.Activate();
            }

            base.WndProc(ref message);
        }


        // Upload: On success
        private void onSuccess(Models.StaticMd.Image image)
        {
            this.imageListBox.Items.Add(image.image);
            this.imageListBox.ClearSelected();
            this.imageListBox.SelectedIndex = this.imageListBox.Items.Count - 1;
            this.imageListBox.Focus();

            // Setting: Copy URL to clipboard immediately
            if (this.appSettings.settingIsCopyImageURLToClipboard)
            {
                this.copyStringToClipboard(image.image);
            }

            // Setting: Log image URLs
            if (this.appSettings.settingIsLogImageUrls)
            {
                string append = "[" + DateTime.Now.ToString() + "] " + image.image + Environment.NewLine;
                File.AppendAllText(this.appSettings.settingLogImageUrlsFile, append);
            }
        }

        // Upload: On error
        private void onError(string message)
        {
            MessageBox.Show("Can not upload image. Exception: " + message, "Error: Upload");
        }

        // Upload: On complete
        private void onComplete()
        {
            this.uiFinishUpload();
        }

        // Upload: On image
        private void onImage(Image image)
        {
            try
            {
                if (image.Width <= this.previewPictureBox.Width && image.Height <= this.previewPictureBox.Height)
                {
                    this.previewPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    this.previewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                this.previewPictureBox.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not set image in preview box. Exception: " + ex.Message, "Error: Preview");
            }
        }


        // UI: Start upload
        private void uiStartUpload()
        {
            this.captureButton.Enabled = false;
            this.uploadButton.Enabled = false;
            this.uploadProgressBar.Style = ProgressBarStyle.Marquee;
            this.uploadProgressBar.MarqueeAnimationSpeed = 15;
            this.AllowDrop = false;
        }

        // UI: Finish upload
        private void uiFinishUpload()
        {
            this.captureButton.Enabled = true;
            this.uploadButton.Enabled = true;
            this.uploadProgressBar.MarqueeAnimationSpeed = 0;
            this.uploadProgressBar.Style = ProgressBarStyle.Blocks;
            this.AllowDrop = true;
            this.Visible = true;

            // Flash form if it is not active
            if (!this.Focused)
            {
                Helpers.FlashWindow.Flash(this);
            }
        }


        // Click capture and upload button
        private void captureButton_Click(object sender, EventArgs e)
        {
            // Check if snip form is not already opened
            if (Helpers.Global.isSnipFormOpened)
            {
                return;
            }

            Helpers.Global.isSnipFormOpened = true;

            this.Visible = false;
            Image image = SnippingToolForm.Snip();
            this.Visible = true;

            Helpers.Global.isSnipFormOpened = false;

            if (image == null)
            {
                return;
            }

            this.uiStartUpload();
            this.uploadService.uploadImageAsync(image);
        }

        // Listbox key up event
        private void imageListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.imageListBoxRemoveSelected();
                return;
            }

            if (!e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                        this.imageListBoxCopySelectedToClipboard();
                        break;
                    case Keys.B:
                        this.imageListBoxCopySelectedToClipboard(MenuCopyAs.BBCode);
                        break;
                    case Keys.H:
                        this.imageListBoxCopySelectedToClipboard(MenuCopyAs.HTML);
                        break;
                    case Keys.D:
                        this.imageListBoxRemoveSelected();
                        break;
                    case Keys.A:
                        this.imageListBoxSelectAll();
                        break;
                }
            }
        }

        // Listbox mouse up event
        private void imageListBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Check if it is right click
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            int clickedIndex = this.imageListBox.IndexFromPoint(e.Location);

            // Check if some items are selected
            if (clickedIndex == ListBox.NoMatches)
            {
                this.imageListContextMenuStrip.Visible = false;
                return;
            }

            // Check if selected item is already selected
            if (this.imageListBox.GetSelected(clickedIndex))
            {
                this.imageListContextMenuStrip.Visible = true;
            }
            else
            {
                this.imageListBox.ClearSelected();
                this.imageListBox.SelectedIndex = clickedIndex;
            }
        }

        // Listbox mouse double click
        private void imageListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int clickedIndex = this.imageListBox.IndexFromPoint(e.Location);
            if (clickedIndex == ListBox.NoMatches)
            {
                return;
            }

            System.Diagnostics.Process.Start((string)this.imageListBox.SelectedItem);
        }

        // StripMenu Event: Opening
        private void imageListContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (imageListBox.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        // StripMenu: Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imageListBoxCopySelectedToClipboard();
        }

        // StripMenu: Copy as HTML
        private void copyAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imageListBoxCopySelectedToClipboard(MenuCopyAs.HTML);
        }

        // StripMenu: Copy as BBCode
        private void copyAsBBCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imageListBoxCopySelectedToClipboard(MenuCopyAs.BBCode);
        }

        // StripMenu: Delete
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imageListBoxRemoveSelected();
        }

        // StripMenu: Select all
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.imageListBoxSelectAll();
        }

        // Click settings button
        private void settingButton_Click(object sender, EventArgs e)
        {
            Form setting = new SettingForm();
            setting.ShowDialog();
        }

        // Click help button
        private void helpButton_Click(object sender, EventArgs e)
        {
            Form help = new HelpForm();
            help.ShowDialog();
        }

        // Copy selected items to clipboard
        private void imageListBoxCopySelectedToClipboard(MenuCopyAs copyAs = MenuCopyAs.Text)
        {
            int count = imageListBox.SelectedItems.Count;

            if (count == 0)
            {
                return;
            }

            StringBuilder sb = new StringBuilder();

            int i = 1;
            foreach (string item in this.imageListBox.SelectedItems)
            {
                switch (copyAs)
                {
                    case MenuCopyAs.HTML:
                        string alt = "Screenshot" + (count > 1 ? " " + i : "");
                        sb.AppendLine("<img src=\"" + item + "\" alt=\"" + alt + "\">");
                        break;
                    case MenuCopyAs.BBCode:
                        sb.AppendLine("[img]" + item + "[/img]");
                        break;
                    default:
                        sb.AppendLine(item);
                        break;
                }
                i++;
            }

            this.copyStringToClipboard(sb.ToString());
        }

        // Select all items
        private void imageListBoxSelectAll()
        {
            if (this.imageListBox.Items.Count == 0)
            {
                return;
            }

            for (int i = 0; i < this.imageListBox.Items.Count; i++)
            {
                this.imageListBox.SetSelected(i, true);
            }
        }

        // Copy string to clipboard
        private void copyStringToClipboard(string text)
        {
            try
            {
                Clipboard.SetDataObject(text, true, 2, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show("It looks like another application on your machine might be locking the clipboard. "
                    + "Exception: " + ex.Message, "Error: Clipboard");
            }
        }

        // Remove selected items
        private void imageListBoxRemoveSelected()
        {
            for (int i = this.imageListBox.SelectedItems.Count - 1; i >= 0; i--)
            {
                this.imageListBox.Items.Remove(this.imageListBox.SelectedItems[i]);
            }
        }

        // Drop files event
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            List<Models.ImageFile> images = Helpers.FindImage.find(droppedFiles);

            if (images.Count == 0)
            {
                return;
            }

            this.uiStartUpload();
            this.uploadService.uploadImageFilesAsync(images);
        }

        // Accept files by drag and drop
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        // Click upload button
        private void uploadButton_Click(object sender, EventArgs e)
        {
            this.uploadOpenFileDialog.ShowDialog();
        }

        // Generat open file dialog filter by accepted extensions
        private string generateOpenFileDialogFilterByAcceptedExtensions()
        {
            string filter = "Image files|";

            string lastExtenstion = Config.acceptedImageExtensions.Last();
            foreach (string extension in Config.acceptedImageExtensions)
            {
                filter += "*." + extension
                    + (!extension.Equals(lastExtenstion) ? "; " : "");
            }

            return filter;
        }

        // Image files are selected
        private void uploadOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            List<Models.ImageFile> images = Helpers.FindImage.find(this.uploadOpenFileDialog.FileNames);

            if (images.Count == 0)
            {
                return;
            }

            this.uiStartUpload();
            this.uploadService.uploadImageFilesAsync(images);
        }

        // Register global hot keys
        private void registerGlobalHotKeys()
        {
            try
            {
                // Register the Ctrl+PrtScr combination as hot key
                this.hookKeyCtrlPrtScr.KeyPressed +=
                    new EventHandler<Helpers.KeyboardHook.KeyPressedEventArgs>(hotKeyCtrlPrtScr_KeyPressed);
                this.hookKeyCtrlPrtScr.RegisterHotKey(Helpers.KeyboardHook.ModifierKeys.Control, Keys.PrintScreen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not register global hotkeys. "
                    + "Exception: " + ex.Message, "Error: Global hot keys");
            }
        }

        // Global hot key Ctrl+PrtScr is pressed
        private void hotKeyCtrlPrtScr_KeyPressed(object sender, Helpers.KeyboardHook.KeyPressedEventArgs e)
        {
            // Activate main form
            this.Activate();

            // Call capture button click
            this.captureButton_Click(this.captureButton, new EventArgs());
        }


        // Tray menu: Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tray menu: Double click
        private void mainNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            if (this.Visible)
            {
                this.Activate();
            }
        }

        // Tray menu: Show/Hide
        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainNotifyIcon_DoubleClick(this.mainNotifyIcon, new EventArgs());
        }
    }
}
