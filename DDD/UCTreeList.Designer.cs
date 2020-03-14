namespace DDD
{
    partial class UCTreeList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TreeViewFolder = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // TreeViewFolder
            // 
            this.TreeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewFolder.Location = new System.Drawing.Point(0, 0);
            this.TreeViewFolder.Name = "TreeViewFolder";
            this.TreeViewFolder.Size = new System.Drawing.Size(725, 626);
            this.TreeViewFolder.TabIndex = 0;
            this.TreeViewFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewFolder_BeforeExpand);
            this.TreeViewFolder.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewFolder_NodeMouseClick);
            // 
            // UCTreeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.TreeViewFolder);
            this.Name = "UCTreeList";
            this.Size = new System.Drawing.Size(725, 626);
            this.Load += new System.EventHandler(this.UCTreeList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewFolder;
    }
}
