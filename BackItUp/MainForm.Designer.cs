namespace BackItUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.bitItUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dropboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skyDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEGAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rapidShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megaUploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.localFTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localUSBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localSCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 306);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 249);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(642, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(642, 249);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(642, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitItUpToolStripMenuItem,
            this.toolStripSeparator3,
            this.dropboxToolStripMenuItem,
            this.skyDriveToolStripMenuItem,
            this.mEGAToolStripMenuItem,
            this.toolStripSeparator1,
            this.rapidShareToolStripMenuItem,
            this.megaUploadToolStripMenuItem,
            this.toolStripSeparator2,
            this.localFTPToolStripMenuItem,
            this.localUSBToolStripMenuItem,
            this.localSCPToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // bitItUpToolStripMenuItem
            // 
            this.bitItUpToolStripMenuItem.Name = "bitItUpToolStripMenuItem";
            this.bitItUpToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.bitItUpToolStripMenuItem.Text = "BitItUp";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
            // 
            // dropboxToolStripMenuItem
            // 
            this.dropboxToolStripMenuItem.Name = "dropboxToolStripMenuItem";
            this.dropboxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dropboxToolStripMenuItem.Text = "Dropbox";
            this.dropboxToolStripMenuItem.Click += new System.EventHandler(this.dropboxToolStripMenuItem_Click);
            // 
            // skyDriveToolStripMenuItem
            // 
            this.skyDriveToolStripMenuItem.Name = "skyDriveToolStripMenuItem";
            this.skyDriveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.skyDriveToolStripMenuItem.Text = "SkyDrive";
            // 
            // mEGAToolStripMenuItem
            // 
            this.mEGAToolStripMenuItem.Name = "mEGAToolStripMenuItem";
            this.mEGAToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.mEGAToolStripMenuItem.Text = "MEGA";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // rapidShareToolStripMenuItem
            // 
            this.rapidShareToolStripMenuItem.Name = "rapidShareToolStripMenuItem";
            this.rapidShareToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.rapidShareToolStripMenuItem.Text = "RapidShare";
            // 
            // megaUploadToolStripMenuItem
            // 
            this.megaUploadToolStripMenuItem.Name = "megaUploadToolStripMenuItem";
            this.megaUploadToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.megaUploadToolStripMenuItem.Text = "MegaUpload";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // localFTPToolStripMenuItem
            // 
            this.localFTPToolStripMenuItem.Name = "localFTPToolStripMenuItem";
            this.localFTPToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.localFTPToolStripMenuItem.Text = "Local FTP";
            // 
            // localUSBToolStripMenuItem
            // 
            this.localUSBToolStripMenuItem.Name = "localUSBToolStripMenuItem";
            this.localUSBToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.localUSBToolStripMenuItem.Text = "Local USB";
            // 
            // localSCPToolStripMenuItem
            // 
            this.localSCPToolStripMenuItem.Name = "localSCPToolStripMenuItem";
            this.localSCPToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.localSCPToolStripMenuItem.Text = "Local SCP";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 306);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "BitItUp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem bitItUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem dropboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skyDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEGAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem rapidShareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megaUploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem localFTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localUSBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localSCPToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

    }
}

