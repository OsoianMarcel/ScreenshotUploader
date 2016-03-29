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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            // Set form icon
            Icon appIcon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Icon = appIcon;
        }

        // Open browser
        private void staticLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel self = (LinkLabel)sender;
            System.Diagnostics.Process.Start(self.Text);
        }

        // Select email
        private void EmailValueLabel_Click(object sender, EventArgs e)
        {
            TextBox self = (TextBox)sender;
            self.SelectAll();
        }
    }
}
