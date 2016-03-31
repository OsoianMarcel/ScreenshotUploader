using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace App
{
    public partial class SettingForm : Form
    {
        private App.Properties.Settings appSettings;

        // Constructor
        public SettingForm()
        {
            InitializeComponent();

            // Set form icon
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // Set app settings
            this.appSettings = App.Properties.Settings.Default;
        }

        // Load form
        private void SettingForm_Load(object sender, EventArgs e)
        {
            this.loadSettings();
        }

        // Close form
        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.saveSettings();
        }

        // Click the choose log file button
        private void logUrlsSaveDialogButton_Click(object sender, EventArgs e)
        {
            this.logUrlsSaveFileDialog.ShowDialog();
        }

        // Click the log text box
        private void logUrlsPathTextBox_Click(object sender, EventArgs e)
        {
            this.logUrlsSaveFileDialog.ShowDialog();
        }

        // Event fires when user clicks the save button in the file dialog
        private void logUrlsSaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog dialog = (SaveFileDialog)sender;

            this.logUrlsPathTextBox.Text = dialog.FileName;
            this.appSettings.settingLogImageUrlsFile = dialog.FileName;
        }

        // Event fires when the log checkbox is changed
        private void logUrlscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;

            this.logUrlsSaveDialogButton.Enabled = checkbox.Checked;
            this.logUrlsPathTextBox.Enabled = checkbox.Checked;

            // Set default log file
            if (this.logUrlsPathTextBox.Text == "")
            {
                this.logUrlsPathTextBox.Text = Path.GetDirectoryName(Application.ExecutablePath)
                    + "\\ScreenshotUploaderLog.txt";
            }
        }

        // Set settings
        private void saveSettings()
        {
            this.appSettings.settingIsCopyImageURLToClipboard = this.copyImageUrlCheckBox.Checked;

            this.appSettings.settingIsLogImageUrls = this.logUrlsCheckBox.Checked;
            this.appSettings.settingLogImageUrlsFile = this.logUrlsPathTextBox.Text;

            this.appSettings.Save();
        }

        // Load settings
        private void loadSettings()
        {
            this.copyImageUrlCheckBox.Checked = this.appSettings.settingIsCopyImageURLToClipboard;

            this.logUrlsCheckBox.Checked = this.appSettings.settingIsLogImageUrls;
            this.logUrlsPathTextBox.Text = this.appSettings.settingLogImageUrlsFile;
            this.logUrlsSaveFileDialog.FileName = this.appSettings.settingLogImageUrlsFile;
            this.logUrlsSaveDialogButton.Enabled = this.appSettings.settingIsLogImageUrls;
        }
    }
}
