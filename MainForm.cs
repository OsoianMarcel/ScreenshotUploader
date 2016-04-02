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
        private delegate void OnSuccessDelegate(Model.Image image);
        private delegate void OnErrorDelegate(string message);
        private delegate void OnCompleteDelegate();

        private enum MenuCopyAs { Text, BBCode, HTML }

        private App.Properties.Settings appSettings;

        private Service.Upload uploadService;

        // Constructor
        public MainForm()
        {
            InitializeComponent();

            // Set app settings
            this.appSettings = App.Properties.Settings.Default;

            // Set form icon
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // Init upload service
            this.uploadService = new Service.Upload();
            this.uploadService.onSuccess(new Service.Upload.SuccessCallback((Model.Image image) => this.Invoke(new OnSuccessDelegate(this.onSuccess), image)));
            this.uploadService.onError(new Service.Upload.ErrorCallback((string message) => this.Invoke(new OnErrorDelegate(this.onError), message)));
            this.uploadService.onComplete(new Service.Upload.CompleteCallback(() => this.Invoke(new OnCompleteDelegate(this.onComplete))));

            // Append app version to main form
            this.Text += " | " + Application.ProductVersion;
        }

        // Upload: On success
        private void onSuccess(Model.Image image)
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
            this.captureButton.Enabled = true;
            this.uploadProgressBar.MarqueeAnimationSpeed = 0;
            this.uploadProgressBar.Style = ProgressBarStyle.Blocks;

            // Flash form if it is not active
            if (!this.Focused)
            {
                Helpers.FlashWindow.Flash(this);
            }
        }

        // Click capture and upload button
        private void captureButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Image image = SnippingToolForm.Snip();
            this.Visible = true;

            if (image == null)
            {
                return;
            }

            try
            {
                Image cloneImage = (Image)image.Clone();
                if (cloneImage.Width <= this.previewPictureBox.Width && cloneImage.Height <= this.previewPictureBox.Height)
                {
                    this.previewPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    this.previewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                this.previewPictureBox.Image = cloneImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not set image in preview box. Exception: " + ex.Message, "Error: Preview");
            }

            this.uploadService.doRequestAsync(image);

            this.captureButton.Enabled = false;
            this.uploadProgressBar.Style = ProgressBarStyle.Marquee;
            this.uploadProgressBar.MarqueeAnimationSpeed = 15;
        }

        // Listbox key up event
        private void imageListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                return;
            }

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
        void imageListBoxCopySelectedToClipboard(MenuCopyAs copyAs = MenuCopyAs.Text)
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
                MessageBox.Show("It looks like another application on your machine might be locking the clipboard. Exception: " + ex.Message, "Error: Clipboard");
            }
        }

        // Remove selected items
        void imageListBoxRemoveSelected()
        {
            for (int i = this.imageListBox.SelectedItems.Count - 1; i >= 0; i--)
            {
                this.imageListBox.Items.Remove(this.imageListBox.SelectedItems[i]);
            }
        }
    }
}
