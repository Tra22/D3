namespace DDD
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelMainSource = new System.Windows.Forms.Panel();
            this.panelSourceTree = new System.Windows.Forms.Panel();
            this.panelSource = new System.Windows.Forms.Panel();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.panelMainDirectory = new System.Windows.Forms.Panel();
            this.panelDirectoryTree = new System.Windows.Forms.Panel();
            this.panelDirectory = new System.Windows.Forms.Panel();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelMainSource.SuspendLayout();
            this.panelSource.SuspendLayout();
            this.panelMainDirectory.SuspendLayout();
            this.panelDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.viewToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.copyToolStripMenuItem.Text = "Copy ";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchToolStripMenuItem,
            this.misMatchToolStripMenuItem,
            this.bothToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "View";
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.matchToolStripMenuItem.Text = "Match";
            // 
            // misMatchToolStripMenuItem
            // 
            this.misMatchToolStripMenuItem.Name = "misMatchToolStripMenuItem";
            this.misMatchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.misMatchToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.misMatchToolStripMenuItem.Text = "MisMatch";
            // 
            // bothToolStripMenuItem
            // 
            this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
            this.bothToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.bothToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.bothToolStripMenuItem.Text = "Both";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.AutoScroll = true;
            this.splitContainerMain.Panel1.Controls.Add(this.panelMainSource);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.AutoScroll = true;
            this.splitContainerMain.Panel2.Controls.Add(this.panelMainDirectory);
            this.splitContainerMain.Size = new System.Drawing.Size(934, 531);
            this.splitContainerMain.SplitterDistance = 450;
            this.splitContainerMain.TabIndex = 1;
            // 
            // panelMainSource
            // 
            this.panelMainSource.Controls.Add(this.panelSourceTree);
            this.panelMainSource.Controls.Add(this.panelSource);
            this.panelMainSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainSource.Location = new System.Drawing.Point(0, 0);
            this.panelMainSource.Name = "panelMainSource";
            this.panelMainSource.Size = new System.Drawing.Size(450, 531);
            this.panelMainSource.TabIndex = 0;
            // 
            // panelSourceTree
            // 
            this.panelSourceTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSourceTree.Location = new System.Drawing.Point(0, 38);
            this.panelSourceTree.Name = "panelSourceTree";
            this.panelSourceTree.Size = new System.Drawing.Size(450, 493);
            this.panelSourceTree.TabIndex = 1;
            // 
            // panelSource
            // 
            this.panelSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSource.Controls.Add(this.button2);
            this.panelSource.Controls.Add(this.button1);
            this.panelSource.Controls.Add(this.btnBrowseSource);
            this.panelSource.Controls.Add(this.txtSource);
            this.panelSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSource.ForeColor = System.Drawing.SystemColors.Control;
            this.panelSource.Location = new System.Drawing.Point(0, 0);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(450, 38);
            this.panelSource.TabIndex = 0;
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.ForeColor = System.Drawing.Color.Silver;
            this.txtSource.Location = new System.Drawing.Point(13, 8);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(322, 20);
            this.txtSource.TabIndex = 1;
            this.txtSource.Text = "Source path";
            this.txtSource.Enter += new System.EventHandler(this.txtSource_Enter);
            this.txtSource.Leave += new System.EventHandler(this.txtSource_Leave);
            // 
            // panelMainDirectory
            // 
            this.panelMainDirectory.Controls.Add(this.panelDirectoryTree);
            this.panelMainDirectory.Controls.Add(this.panelDirectory);
            this.panelMainDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainDirectory.Location = new System.Drawing.Point(0, 0);
            this.panelMainDirectory.Name = "panelMainDirectory";
            this.panelMainDirectory.Size = new System.Drawing.Size(480, 531);
            this.panelMainDirectory.TabIndex = 0;
            // 
            // panelDirectoryTree
            // 
            this.panelDirectoryTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDirectoryTree.Location = new System.Drawing.Point(0, 38);
            this.panelDirectoryTree.Name = "panelDirectoryTree";
            this.panelDirectoryTree.Size = new System.Drawing.Size(480, 493);
            this.panelDirectoryTree.TabIndex = 1;
            // 
            // panelDirectory
            // 
            this.panelDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDirectory.Controls.Add(this.button3);
            this.panelDirectory.Controls.Add(this.txtDirectory);
            this.panelDirectory.Controls.Add(this.button4);
            this.panelDirectory.Controls.Add(this.button5);
            this.panelDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDirectory.Location = new System.Drawing.Point(0, 0);
            this.panelDirectory.Name = "panelDirectory";
            this.panelDirectory.Size = new System.Drawing.Size(480, 38);
            this.panelDirectory.TabIndex = 0;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.ForeColor = System.Drawing.Color.Silver;
            this.txtDirectory.Location = new System.Drawing.Point(18, 8);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(350, 20);
            this.txtDirectory.TabIndex = 2;
            this.txtDirectory.Text = "Directory path";
            this.txtDirectory.Enter += new System.EventHandler(this.txtDirectory_Enter);
            this.txtDirectory.Leave += new System.EventHandler(this.txtDirectory_Leave);
            // 
            // PanelFooter
            // 
            this.PanelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 555);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(934, 40);
            this.PanelFooter.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::DDD.Properties.Resources.Close;
            this.button2.Location = new System.Drawing.Point(404, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::DDD.Properties.Resources.Back;
            this.button1.Location = new System.Drawing.Point(370, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSource.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowseSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSource.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrowseSource.Image = global::DDD.Properties.Resources.Folder;
            this.btnBrowseSource.Location = new System.Drawing.Point(341, 8);
            this.btnBrowseSource.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(20, 20);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.UseVisualStyleBackColor = false;
            
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::DDD.Properties.Resources.Close;
            this.button3.Location = new System.Drawing.Point(442, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::DDD.Properties.Resources.Back;
            this.button4.Location = new System.Drawing.Point(408, 6);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Image = global::DDD.Properties.Resources.Folder;
            this.button5.Location = new System.Drawing.Point(379, 8);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 20);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 595);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PanelFooter);
            this.Name = "Form1";
            this.Text = "DDD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelMainSource.ResumeLayout(false);
            this.panelSource.ResumeLayout(false);
            this.panelSource.PerformLayout();
            this.panelMainDirectory.ResumeLayout(false);
            this.panelDirectory.ResumeLayout(false);
            this.panelDirectory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelMainSource;
        private System.Windows.Forms.Panel panelMainDirectory;
        private System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.Panel panelSourceTree;
        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.Panel panelDirectoryTree;
        private System.Windows.Forms.Panel panelDirectory;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

