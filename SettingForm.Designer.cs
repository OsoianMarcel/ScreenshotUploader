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
            this.SuspendLayout();
            // 
            // copyImageUrlCheckBox
            // 
            this.copyImageUrlCheckBox.AutoSize = true;
            this.copyImageUrlCheckBox.Location = new System.Drawing.Point(12, 12);
            this.copyImageUrlCheckBox.Name = "copyImageUrlCheckBox";
            this.copyImageUrlCheckBox.Size = new System.Drawing.Size(190, 17);
            this.copyImageUrlCheckBox.TabIndex = 0;
            this.copyImageUrlCheckBox.Text = "Copy URL to clipboard immediately";
            this.copyImageUrlCheckBox.UseVisualStyleBackColor = true;
            this.copyImageUrlCheckBox.CheckedChanged += new System.EventHandler(this.copyImageUrlCheckBox_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 41);
            this.Controls.Add(this.copyImageUrlCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox copyImageUrlCheckBox;
    }
}