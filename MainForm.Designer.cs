namespace App
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.uploadProgressBar = new System.Windows.Forms.ProgressBar();
            this.imageListBox = new System.Windows.Forms.ListBox();
            this.imageListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsBBCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.previewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.imageListContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.Color.White;
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPanel.Controls.Add(this.previewPictureBox);
            this.previewPanel.Location = new System.Drawing.Point(12, 12);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(250, 175);
            this.previewPanel.TabIndex = 0;
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Image = global::App.Properties.Resources.pixture_box_crop;
            this.previewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(248, 173);
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            // 
            // uploadProgressBar
            // 
            this.uploadProgressBar.Location = new System.Drawing.Point(12, 192);
            this.uploadProgressBar.Name = "uploadProgressBar";
            this.uploadProgressBar.Size = new System.Drawing.Size(504, 10);
            this.uploadProgressBar.TabIndex = 1;
            // 
            // imageListBox
            // 
            this.imageListBox.ContextMenuStrip = this.imageListContextMenuStrip;
            this.imageListBox.FormattingEnabled = true;
            this.imageListBox.Location = new System.Drawing.Point(268, 41);
            this.imageListBox.Name = "imageListBox";
            this.imageListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.imageListBox.Size = new System.Drawing.Size(248, 147);
            this.imageListBox.TabIndex = 2;
            this.imageListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.imageListBox_KeyUp);
            this.imageListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imageListBox_MouseDoubleClick);
            this.imageListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageListBox_MouseUp);
            // 
            // imageListContextMenuStrip
            // 
            this.imageListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyAsHTMLToolStripMenuItem,
            this.copyAsBBCodeToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectAllToolStripMenuItem});
            this.imageListContextMenuStrip.Name = "imageListContextMenuStrip";
            this.imageListContextMenuStrip.Size = new System.Drawing.Size(212, 120);
            this.imageListContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.imageListContextMenuStrip_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::App.Properties.Resources.copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyAsHTMLToolStripMenuItem
            // 
            this.copyAsHTMLToolStripMenuItem.Image = global::App.Properties.Resources.copy_html;
            this.copyAsHTMLToolStripMenuItem.Name = "copyAsHTMLToolStripMenuItem";
            this.copyAsHTMLToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+H";
            this.copyAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.copyAsHTMLToolStripMenuItem.Text = "Copy as HTML";
            this.copyAsHTMLToolStripMenuItem.Click += new System.EventHandler(this.copyAsHTMLToolStripMenuItem_Click);
            // 
            // copyAsBBCodeToolStripMenuItem
            // 
            this.copyAsBBCodeToolStripMenuItem.Image = global::App.Properties.Resources.copy_bbcode;
            this.copyAsBBCodeToolStripMenuItem.Name = "copyAsBBCodeToolStripMenuItem";
            this.copyAsBBCodeToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+B";
            this.copyAsBBCodeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.copyAsBBCodeToolStripMenuItem.Text = "Copy as BBCode";
            this.copyAsBBCodeToolStripMenuItem.Click += new System.EventHandler(this.copyAsBBCodeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::App.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+D";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::App.Properties.Resources.html_balance_braces;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+A";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // helpButton
            // 
            this.helpButton.Image = global::App.Properties.Resources.help;
            this.helpButton.Location = new System.Drawing.Point(492, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(24, 23);
            this.helpButton.TabIndex = 4;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Image = global::App.Properties.Resources.legend;
            this.settingButton.Location = new System.Drawing.Point(267, 12);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(24, 23);
            this.settingButton.TabIndex = 3;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Image = global::App.Properties.Resources.app_window;
            this.captureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.captureButton.Location = new System.Drawing.Point(297, 12);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(189, 23);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Capture screen and upload";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 211);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.imageListBox);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.uploadProgressBar);
            this.Controls.Add(this.previewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screenshot uploader";
            this.previewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.imageListContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.ProgressBar uploadProgressBar;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.ListBox imageListBox;
        private System.Windows.Forms.ContextMenuStrip imageListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAsHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAsBBCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button helpButton;
    }
}