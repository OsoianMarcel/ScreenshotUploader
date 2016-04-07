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
            this.uploadButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.uploadOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.previewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.imageListContextMenuStrip.SuspendLayout();
            this.notifyContextMenuStrip.SuspendLayout();
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
            this.uploadProgressBar.Size = new System.Drawing.Size(532, 10);
            this.uploadProgressBar.TabIndex = 1;
            // 
            // imageListBox
            // 
            this.imageListBox.ContextMenuStrip = this.imageListContextMenuStrip;
            this.imageListBox.FormattingEnabled = true;
            this.imageListBox.Location = new System.Drawing.Point(268, 41);
            this.imageListBox.Name = "imageListBox";
            this.imageListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.imageListBox.Size = new System.Drawing.Size(276, 147);
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
            // uploadButton
            // 
            this.uploadButton.Image = global::App.Properties.Resources.open;
            this.uploadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadButton.Location = new System.Drawing.Point(377, 13);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(103, 22);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Text = "Upload images";
            this.uploadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Image = global::App.Properties.Resources.help;
            this.helpButton.Location = new System.Drawing.Point(518, 13);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(26, 23);
            this.helpButton.TabIndex = 4;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Image = global::App.Properties.Resources.legend;
            this.settingButton.Location = new System.Drawing.Point(486, 13);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(26, 23);
            this.settingButton.TabIndex = 3;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Image = global::App.Properties.Resources.app_window;
            this.captureButton.Location = new System.Drawing.Point(268, 12);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(103, 23);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Capture screen";
            this.captureButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.captureButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // uploadOpenFileDialog
            // 
            this.uploadOpenFileDialog.Multiselect = true;
            this.uploadOpenFileDialog.Title = "Upload images";
            this.uploadOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.uploadOpenFileDialog_FileOk);
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.ContextMenuStrip = this.notifyContextMenuStrip;
            this.mainNotifyIcon.Text = "MainNotifyIcon";
            this.mainNotifyIcon.BalloonTipClicked += new System.EventHandler(this.mainNotifyIcon_BalloonTipClicked);
            this.mainNotifyIcon.DoubleClick += new System.EventHandler(this.mainNotifyIcon_DoubleClick);
            // 
            // notifyContextMenuStrip
            // 
            this.notifyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.notifyContextMenuStrip.Name = "notifyContextMenuStrip";
            this.notifyContextMenuStrip.Size = new System.Drawing.Size(134, 54);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.showHideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 211);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.imageListBox);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.uploadProgressBar);
            this.Controls.Add(this.previewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screenshot uploader";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.previewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.imageListContextMenuStrip.ResumeLayout(false);
            this.notifyContextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog uploadOpenFileDialog;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}