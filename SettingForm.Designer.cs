namespace App
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.copyImageUrlCheckBox = new System.Windows.Forms.CheckBox();
            this.logUrlsGroupBox = new System.Windows.Forms.GroupBox();
            this.logUrlsSaveDialogButton = new System.Windows.Forms.Button();
            this.logUrlsPathTextBox = new System.Windows.Forms.TextBox();
            this.logUrlsCheckBox = new System.Windows.Forms.CheckBox();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.logUrlsSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.logUrlsGroupBox.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyImageUrlCheckBox
            // 
            this.copyImageUrlCheckBox.AutoSize = true;
            this.copyImageUrlCheckBox.Location = new System.Drawing.Point(12, 19);
            this.copyImageUrlCheckBox.Name = "copyImageUrlCheckBox";
            this.copyImageUrlCheckBox.Size = new System.Drawing.Size(190, 17);
            this.copyImageUrlCheckBox.TabIndex = 0;
            this.copyImageUrlCheckBox.Text = "Copy URL to clipboard immediately";
            this.copyImageUrlCheckBox.UseVisualStyleBackColor = true;
            // 
            // logUrlsGroupBox
            // 
            this.logUrlsGroupBox.Controls.Add(this.logUrlsSaveDialogButton);
            this.logUrlsGroupBox.Controls.Add(this.logUrlsPathTextBox);
            this.logUrlsGroupBox.Controls.Add(this.logUrlsCheckBox);
            this.logUrlsGroupBox.Location = new System.Drawing.Point(12, 61);
            this.logUrlsGroupBox.Name = "logUrlsGroupBox";
            this.logUrlsGroupBox.Size = new System.Drawing.Size(319, 75);
            this.logUrlsGroupBox.TabIndex = 1;
            this.logUrlsGroupBox.TabStop = false;
            this.logUrlsGroupBox.Text = "Log URLs";
            // 
            // logUrlsSaveDialogButton
            // 
            this.logUrlsSaveDialogButton.Enabled = false;
            this.logUrlsSaveDialogButton.Location = new System.Drawing.Point(238, 40);
            this.logUrlsSaveDialogButton.Name = "logUrlsSaveDialogButton";
            this.logUrlsSaveDialogButton.Size = new System.Drawing.Size(75, 22);
            this.logUrlsSaveDialogButton.TabIndex = 2;
            this.logUrlsSaveDialogButton.Text = "Choose file";
            this.logUrlsSaveDialogButton.UseVisualStyleBackColor = true;
            this.logUrlsSaveDialogButton.Click += new System.EventHandler(this.logUrlsSaveDialogButton_Click);
            // 
            // logUrlsPathTextBox
            // 
            this.logUrlsPathTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.logUrlsPathTextBox.Enabled = false;
            this.logUrlsPathTextBox.Location = new System.Drawing.Point(12, 42);
            this.logUrlsPathTextBox.Name = "logUrlsPathTextBox";
            this.logUrlsPathTextBox.ReadOnly = true;
            this.logUrlsPathTextBox.Size = new System.Drawing.Size(220, 20);
            this.logUrlsPathTextBox.TabIndex = 1;
            this.logUrlsPathTextBox.Click += new System.EventHandler(this.logUrlsPathTextBox_Click);
            // 
            // logUrlsCheckBox
            // 
            this.logUrlsCheckBox.AutoSize = true;
            this.logUrlsCheckBox.Location = new System.Drawing.Point(12, 19);
            this.logUrlsCheckBox.Name = "logUrlsCheckBox";
            this.logUrlsCheckBox.Size = new System.Drawing.Size(135, 17);
            this.logUrlsCheckBox.TabIndex = 0;
            this.logUrlsCheckBox.Text = "Save image URL to file";
            this.logUrlsCheckBox.UseVisualStyleBackColor = true;
            this.logUrlsCheckBox.CheckedChanged += new System.EventHandler(this.logUrlscheckBox_CheckedChanged);
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.copyImageUrlCheckBox);
            this.generalGroupBox.Location = new System.Drawing.Point(12, 12);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(319, 43);
            this.generalGroupBox.TabIndex = 2;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // logUrlsSaveFileDialog
            // 
            this.logUrlsSaveFileDialog.Filter = "Text|*.txt|All files|*.*";
            this.logUrlsSaveFileDialog.Title = "Set log file";
            this.logUrlsSaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.logUrlsSaveFileDialog_FileOk);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 147);
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.logUrlsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.logUrlsGroupBox.ResumeLayout(false);
            this.logUrlsGroupBox.PerformLayout();
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox copyImageUrlCheckBox;
        private System.Windows.Forms.GroupBox logUrlsGroupBox;
        private System.Windows.Forms.Button logUrlsSaveDialogButton;
        private System.Windows.Forms.TextBox logUrlsPathTextBox;
        private System.Windows.Forms.CheckBox logUrlsCheckBox;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.SaveFileDialog logUrlsSaveFileDialog;
    }
}