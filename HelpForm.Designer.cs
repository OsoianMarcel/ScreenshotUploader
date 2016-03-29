namespace App
{
    partial class HelpForm
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
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.imageUploaderValueLabel = new System.Windows.Forms.Label();
            this.imageUplaoderLabel = new System.Windows.Forms.Label();
            this.createdByValueLabel = new System.Windows.Forms.Label();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.EmailValueLabel = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.appPictureBox = new System.Windows.Forms.PictureBox();
            this.thanksGroupBox = new System.Windows.Forms.GroupBox();
            this.HowLongRLabel = new System.Windows.Forms.Label();
            this.HowLongALabel = new System.Windows.Forms.Label();
            this.howToDeleteRLabel = new System.Windows.Forms.Label();
            this.howToDeleteALabel = new System.Windows.Forms.Label();
            this.whatAreLimitsRLabel = new System.Windows.Forms.Label();
            this.whatAreLimitsALabel = new System.Windows.Forms.Label();
            this.whatIsStaticRLabel = new System.Windows.Forms.Label();
            this.whatIsStaticALabel = new System.Windows.Forms.Label();
            this.staticLinkLabel = new System.Windows.Forms.LinkLabel();
            this.staticWebsiteLabel = new System.Windows.Forms.Label();
            this.staticPictureBox = new System.Windows.Forms.PictureBox();
            this.generalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appPictureBox)).BeginInit();
            this.thanksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staticPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.imageUploaderValueLabel);
            this.generalGroupBox.Controls.Add(this.imageUplaoderLabel);
            this.generalGroupBox.Controls.Add(this.createdByValueLabel);
            this.generalGroupBox.Controls.Add(this.createdByLabel);
            this.generalGroupBox.Controls.Add(this.EmailValueLabel);
            this.generalGroupBox.Controls.Add(this.EmailLabel);
            this.generalGroupBox.Controls.Add(this.appPictureBox);
            this.generalGroupBox.Location = new System.Drawing.Point(12, 12);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(359, 104);
            this.generalGroupBox.TabIndex = 0;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // imageUploaderValueLabel
            // 
            this.imageUploaderValueLabel.AutoSize = true;
            this.imageUploaderValueLabel.Location = new System.Drawing.Point(90, 39);
            this.imageUploaderValueLabel.Name = "imageUploaderValueLabel";
            this.imageUploaderValueLabel.Size = new System.Drawing.Size(162, 13);
            this.imageUploaderValueLabel.TabIndex = 18;
            this.imageUploaderValueLabel.Text = "Simple screenshot uploading tool";
            // 
            // imageUplaoderLabel
            // 
            this.imageUplaoderLabel.AutoSize = true;
            this.imageUplaoderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageUplaoderLabel.Location = new System.Drawing.Point(89, 19);
            this.imageUplaoderLabel.Name = "imageUplaoderLabel";
            this.imageUplaoderLabel.Size = new System.Drawing.Size(120, 20);
            this.imageUplaoderLabel.TabIndex = 17;
            this.imageUplaoderLabel.Text = "Image uploader";
            // 
            // createdByValueLabel
            // 
            this.createdByValueLabel.AutoSize = true;
            this.createdByValueLabel.Location = new System.Drawing.Point(148, 81);
            this.createdByValueLabel.Name = "createdByValueLabel";
            this.createdByValueLabel.Size = new System.Drawing.Size(86, 13);
            this.createdByValueLabel.TabIndex = 16;
            this.createdByValueLabel.Text = "Osoian Marcel D";
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Location = new System.Drawing.Point(90, 81);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(61, 13);
            this.createdByLabel.TabIndex = 15;
            this.createdByLabel.Text = "Created by:";
            // 
            // EmailValueLabel
            // 
            this.EmailValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailValueLabel.Location = new System.Drawing.Point(151, 65);
            this.EmailValueLabel.Name = "EmailValueLabel";
            this.EmailValueLabel.ReadOnly = true;
            this.EmailValueLabel.Size = new System.Drawing.Size(134, 13);
            this.EmailValueLabel.TabIndex = 14;
            this.EmailValueLabel.TabStop = false;
            this.EmailValueLabel.Text = "osoian.marcel.d@gmail.com";
            this.EmailValueLabel.Click += new System.EventHandler(this.EmailValueLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(90, 65);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "E-mail:";
            // 
            // appPictureBox
            // 
            this.appPictureBox.Image = global::App.Properties.Resources.app_logo;
            this.appPictureBox.Location = new System.Drawing.Point(8, 19);
            this.appPictureBox.Name = "appPictureBox";
            this.appPictureBox.Size = new System.Drawing.Size(75, 75);
            this.appPictureBox.TabIndex = 12;
            this.appPictureBox.TabStop = false;
            // 
            // thanksGroupBox
            // 
            this.thanksGroupBox.Controls.Add(this.HowLongRLabel);
            this.thanksGroupBox.Controls.Add(this.HowLongALabel);
            this.thanksGroupBox.Controls.Add(this.howToDeleteRLabel);
            this.thanksGroupBox.Controls.Add(this.howToDeleteALabel);
            this.thanksGroupBox.Controls.Add(this.whatAreLimitsRLabel);
            this.thanksGroupBox.Controls.Add(this.whatAreLimitsALabel);
            this.thanksGroupBox.Controls.Add(this.whatIsStaticRLabel);
            this.thanksGroupBox.Controls.Add(this.whatIsStaticALabel);
            this.thanksGroupBox.Controls.Add(this.staticLinkLabel);
            this.thanksGroupBox.Controls.Add(this.staticWebsiteLabel);
            this.thanksGroupBox.Controls.Add(this.staticPictureBox);
            this.thanksGroupBox.Location = new System.Drawing.Point(12, 122);
            this.thanksGroupBox.Name = "thanksGroupBox";
            this.thanksGroupBox.Size = new System.Drawing.Size(359, 247);
            this.thanksGroupBox.TabIndex = 2;
            this.thanksGroupBox.TabStop = false;
            this.thanksGroupBox.Text = "Thanks to static.md";
            // 
            // HowLongRLabel
            // 
            this.HowLongRLabel.AutoSize = true;
            this.HowLongRLabel.Location = new System.Drawing.Point(88, 186);
            this.HowLongRLabel.Name = "HowLongRLabel";
            this.HowLongRLabel.Size = new System.Drawing.Size(269, 26);
            this.HowLongRLabel.TabIndex = 11;
            this.HowLongRLabel.Text = "The images are stored forever, unless violates the terms\r\nand conditions.";
            // 
            // HowLongALabel
            // 
            this.HowLongALabel.AutoSize = true;
            this.HowLongALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HowLongALabel.Location = new System.Drawing.Point(87, 165);
            this.HowLongALabel.Name = "HowLongALabel";
            this.HowLongALabel.Size = new System.Drawing.Size(261, 20);
            this.HowLongALabel.TabIndex = 10;
            this.HowLongALabel.Text = "How long the images will be stored?";
            // 
            // howToDeleteRLabel
            // 
            this.howToDeleteRLabel.AutoSize = true;
            this.howToDeleteRLabel.Location = new System.Drawing.Point(88, 130);
            this.howToDeleteRLabel.Name = "howToDeleteRLabel";
            this.howToDeleteRLabel.Size = new System.Drawing.Size(255, 26);
            this.howToDeleteRLabel.TabIndex = 9;
            this.howToDeleteRLabel.Text = "There is no possibility to detele the uploaded images.\r\nIn exceptional cases, you" +
                " can contact us.";
            // 
            // howToDeleteALabel
            // 
            this.howToDeleteALabel.AutoSize = true;
            this.howToDeleteALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.howToDeleteALabel.Location = new System.Drawing.Point(87, 110);
            this.howToDeleteALabel.Name = "howToDeleteALabel";
            this.howToDeleteALabel.Size = new System.Drawing.Size(268, 20);
            this.howToDeleteALabel.TabIndex = 8;
            this.howToDeleteALabel.Text = "How to delete the uploaded images?";
            // 
            // whatAreLimitsRLabel
            // 
            this.whatAreLimitsRLabel.AutoSize = true;
            this.whatAreLimitsRLabel.Location = new System.Drawing.Point(88, 79);
            this.whatAreLimitsRLabel.Name = "whatAreLimitsRLabel";
            this.whatAreLimitsRLabel.Size = new System.Drawing.Size(192, 26);
            this.whatAreLimitsRLabel.TabIndex = 7;
            this.whatAreLimitsRLabel.Text = "You can upload any number of images.\r\nThe image size must not exceed 10Mb.";
            // 
            // whatAreLimitsALabel
            // 
            this.whatAreLimitsALabel.AutoSize = true;
            this.whatAreLimitsALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whatAreLimitsALabel.Location = new System.Drawing.Point(87, 58);
            this.whatAreLimitsALabel.Name = "whatAreLimitsALabel";
            this.whatAreLimitsALabel.Size = new System.Drawing.Size(201, 20);
            this.whatAreLimitsALabel.TabIndex = 6;
            this.whatAreLimitsALabel.Text = "What are the upload limits?";
            // 
            // whatIsStaticRLabel
            // 
            this.whatIsStaticRLabel.AutoSize = true;
            this.whatIsStaticRLabel.Location = new System.Drawing.Point(88, 36);
            this.whatIsStaticRLabel.Name = "whatIsStaticRLabel";
            this.whatIsStaticRLabel.Size = new System.Drawing.Size(162, 13);
            this.whatIsStaticRLabel.TabIndex = 5;
            this.whatIsStaticRLabel.Text = "Static.md is a free image hosting.";
            // 
            // whatIsStaticALabel
            // 
            this.whatIsStaticALabel.AutoSize = true;
            this.whatIsStaticALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whatIsStaticALabel.Location = new System.Drawing.Point(87, 16);
            this.whatIsStaticALabel.Name = "whatIsStaticALabel";
            this.whatIsStaticALabel.Size = new System.Drawing.Size(142, 20);
            this.whatIsStaticALabel.TabIndex = 4;
            this.whatIsStaticALabel.Text = "What is Static.md?";
            // 
            // staticLinkLabel
            // 
            this.staticLinkLabel.AutoSize = true;
            this.staticLinkLabel.Location = new System.Drawing.Point(134, 226);
            this.staticLinkLabel.Name = "staticLinkLabel";
            this.staticLinkLabel.Size = new System.Drawing.Size(85, 13);
            this.staticLinkLabel.TabIndex = 3;
            this.staticLinkLabel.TabStop = true;
            this.staticLinkLabel.Text = "https://static.md";
            this.staticLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.staticLinkLabel_LinkClicked);
            // 
            // staticWebsiteLabel
            // 
            this.staticWebsiteLabel.AutoSize = true;
            this.staticWebsiteLabel.Location = new System.Drawing.Point(88, 226);
            this.staticWebsiteLabel.Name = "staticWebsiteLabel";
            this.staticWebsiteLabel.Size = new System.Drawing.Size(49, 13);
            this.staticWebsiteLabel.TabIndex = 2;
            this.staticWebsiteLabel.Text = "Website:";
            // 
            // staticPictureBox
            // 
            this.staticPictureBox.Image = global::App.Properties.Resources.static_md;
            this.staticPictureBox.Location = new System.Drawing.Point(6, 17);
            this.staticPictureBox.Name = "staticPictureBox";
            this.staticPictureBox.Size = new System.Drawing.Size(75, 75);
            this.staticPictureBox.TabIndex = 1;
            this.staticPictureBox.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 376);
            this.Controls.Add(this.thanksGroupBox);
            this.Controls.Add(this.generalGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appPictureBox)).EndInit();
            this.thanksGroupBox.ResumeLayout(false);
            this.thanksGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staticPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.PictureBox staticPictureBox;
        private System.Windows.Forms.GroupBox thanksGroupBox;
        private System.Windows.Forms.LinkLabel staticLinkLabel;
        private System.Windows.Forms.Label staticWebsiteLabel;
        private System.Windows.Forms.Label HowLongRLabel;
        private System.Windows.Forms.Label HowLongALabel;
        private System.Windows.Forms.Label howToDeleteRLabel;
        private System.Windows.Forms.Label howToDeleteALabel;
        private System.Windows.Forms.Label whatAreLimitsRLabel;
        private System.Windows.Forms.Label whatAreLimitsALabel;
        private System.Windows.Forms.Label whatIsStaticRLabel;
        private System.Windows.Forms.Label whatIsStaticALabel;
        private System.Windows.Forms.PictureBox appPictureBox;
        private System.Windows.Forms.TextBox EmailValueLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label createdByValueLabel;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label imageUplaoderLabel;
        private System.Windows.Forms.Label imageUploaderValueLabel;
    }
}