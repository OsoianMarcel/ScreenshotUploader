using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class SettingForm : Form
    {
        private App.Properties.Settings appSettings;

        public SettingForm()
        {
            InitializeComponent();

            // Set form icon
            Icon appIcon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Icon = appIcon;

            // Set app settings
            this.appSettings = App.Properties.Settings.Default;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            this.copyImageUrlCheckBox.Checked = this.appSettings.settingIsCopyImageURLToClipboard;
        }

        private void copyImageUrlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.saveSettings();
        }

        private void saveSettings()
        {
            this.appSettings.settingIsCopyImageURLToClipboard = this.copyImageUrlCheckBox.Checked;
        }

        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.appSettings.Save();
        }
    }
}
