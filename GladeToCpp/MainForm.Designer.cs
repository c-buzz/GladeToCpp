namespace GladeConstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gladeFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.ClassFileDirectoryChooseButton = new System.Windows.Forms.Button();
            this.folderBrowserClass = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormMenu = new System.Windows.Forms.MenuStrip();
            this.FormMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGladeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.BuildCodeButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.FormMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gladeFileOpen
            // 
            this.gladeFileOpen.FileName = "gladeOpener";
            this.gladeFileOpen.Filter = "Glade files|*.glade|Xml|.xml";
            // 
            // ClassFileDirectoryChooseButton
            // 
            this.ClassFileDirectoryChooseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassFileDirectoryChooseButton.Location = new System.Drawing.Point(-196, 4);
            this.ClassFileDirectoryChooseButton.Name = "ClassFileDirectoryChooseButton";
            this.ClassFileDirectoryChooseButton.Size = new System.Drawing.Size(28, 20);
            this.ClassFileDirectoryChooseButton.TabIndex = 10;
            this.ClassFileDirectoryChooseButton.Text = "...";
            this.ClassFileDirectoryChooseButton.UseVisualStyleBackColor = true;
            this.ClassFileDirectoryChooseButton.Click += new System.EventHandler(this.ClassFileDirectoryChooseButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // FormMenu
            // 
            this.FormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormMenuFile});
            this.FormMenu.Location = new System.Drawing.Point(0, 0);
            this.FormMenu.Name = "FormMenu";
            this.FormMenu.Size = new System.Drawing.Size(645, 24);
            this.FormMenu.TabIndex = 6;
            this.FormMenu.Text = "Form Menu";
            // 
            // FormMenuFile
            // 
            this.FormMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.closeGladeFileToolStripMenuItem});
            this.FormMenuFile.Name = "FormMenuFile";
            this.FormMenuFile.Size = new System.Drawing.Size(37, 20);
            this.FormMenuFile.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click_1);
            // 
            // closeGladeFileToolStripMenuItem
            // 
            this.closeGladeFileToolStripMenuItem.Name = "closeGladeFileToolStripMenuItem";
            this.closeGladeFileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.closeGladeFileToolStripMenuItem.Text = "Close Glade File";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildCodeButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 24);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(645, 279);
            this.dockPanel1.TabIndex = 15;
            // 
            // BuildCodeButton
            // 
            this.BuildCodeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BuildCodeButton.Image = ((System.Drawing.Image)(resources.GetObject("BuildCodeButton.Image")));
            this.BuildCodeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuildCodeButton.Name = "BuildCodeButton";
            this.BuildCodeButton.Size = new System.Drawing.Size(94, 22);
            this.BuildCodeButton.Text = "Build C++ code";
            this.BuildCodeButton.Click += new System.EventHandler(this.BuildCodeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 303);
            this.Controls.Add(this.ClassFileDirectoryChooseButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.FormMenu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "GladeConstructor";
            this.contextMenuStrip1.ResumeLayout(false);
            this.FormMenu.ResumeLayout(false);
            this.FormMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog gladeFileOpen;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button ClassFileDirectoryChooseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserClass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.MenuStrip FormMenu;
        private System.Windows.Forms.ToolStripMenuItem FormMenuFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeGladeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripButton BuildCodeButton;
    }
}

