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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gladeFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.FormGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassFileDirectoryChooseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DirectoryClassFilesTextBox = new System.Windows.Forms.TextBox();
            this.CreateClassFilesButton = new System.Windows.Forms.Button();
            this.ObjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserClass = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormMenu = new System.Windows.Forms.MenuStrip();
            this.FormMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGladeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InClass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FormGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.FormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gladeFileOpen
            // 
            this.gladeFileOpen.FileName = "gladeOpener";
            this.gladeFileOpen.Filter = "Glade files|*.glade|Xml|.xml";
            // 
            // FormGridView
            // 
            this.FormGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Class});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FormGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.FormGridView.Location = new System.Drawing.Point(0, 27);
            this.FormGridView.MultiSelect = false;
            this.FormGridView.Name = "FormGridView";
            this.FormGridView.RowHeadersVisible = false;
            this.FormGridView.Size = new System.Drawing.Size(511, 231);
            this.FormGridView.TabIndex = 11;
            this.FormGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FormGridView_CellContentClick);
            this.FormGridView.SelectionChanged += new System.EventHandler(this.FormGridView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Class.DataPropertyName = "Class";
            this.Class.HeaderText = "Class Name";
            this.Class.Name = "Class";
            // 
            // ClassFileDirectoryChooseButton
            // 
            this.ClassFileDirectoryChooseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassFileDirectoryChooseButton.Location = new System.Drawing.Point(761, 58);
            this.ClassFileDirectoryChooseButton.Name = "ClassFileDirectoryChooseButton";
            this.ClassFileDirectoryChooseButton.Size = new System.Drawing.Size(28, 20);
            this.ClassFileDirectoryChooseButton.TabIndex = 10;
            this.ClassFileDirectoryChooseButton.Text = "...";
            this.ClassFileDirectoryChooseButton.UseVisualStyleBackColor = true;
            this.ClassFileDirectoryChooseButton.Click += new System.EventHandler(this.ClassFileDirectoryChooseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Directory for saving class files";
            // 
            // DirectoryClassFilesTextBox
            // 
            this.DirectoryClassFilesTextBox.Location = new System.Drawing.Point(516, 43);
            this.DirectoryClassFilesTextBox.Name = "DirectoryClassFilesTextBox";
            this.DirectoryClassFilesTextBox.Size = new System.Drawing.Size(256, 20);
            this.DirectoryClassFilesTextBox.TabIndex = 8;
            this.DirectoryClassFilesTextBox.Text = "C:\\Users\\Buzz\\Desktop";
            // 
            // CreateClassFilesButton
            // 
            this.CreateClassFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateClassFilesButton.Location = new System.Drawing.Point(726, 115);
            this.CreateClassFilesButton.Name = "CreateClassFilesButton";
            this.CreateClassFilesButton.Size = new System.Drawing.Size(75, 23);
            this.CreateClassFilesButton.TabIndex = 7;
            this.CreateClassFilesButton.Text = "Create Class";
            this.CreateClassFilesButton.UseVisualStyleBackColor = true;
            this.CreateClassFilesButton.Click += new System.EventHandler(this.CreateClassFilesButton_Click);
            // 
            // ObjectsDataGrid
            // 
            this.ObjectsDataGrid.AllowUserToAddRows = false;
            this.ObjectsDataGrid.AllowUserToDeleteRows = false;
            this.ObjectsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsDataGrid.AutoGenerateColumns = false;
            this.ObjectsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ObjectsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ObjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InClass,
            this.ObjectId,
            this.ObjectClass,
            this.VariableName});
            this.ObjectsDataGrid.DataSource = this.bindingSource1;
            this.ObjectsDataGrid.Location = new System.Drawing.Point(0, 264);
            this.ObjectsDataGrid.Name = "ObjectsDataGrid";
            this.ObjectsDataGrid.RowHeadersVisible = false;
            this.ObjectsDataGrid.Size = new System.Drawing.Size(511, 289);
            this.ObjectsDataGrid.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
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
            this.FormMenu.Size = new System.Drawing.Size(801, 24);
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
            // InClass
            // 
            this.InClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InClass.DataPropertyName = "AddToClass";
            this.InClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InClass.HeaderText = "Add to class";
            this.InClass.Name = "InClass";
            this.InClass.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.InClass.ToolTipText = "Add to C++ class";
            // 
            // ObjectId
            // 
            this.ObjectId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ObjectId.DataPropertyName = "Id";
            this.ObjectId.HeaderText = "Widget Id";
            this.ObjectId.Name = "ObjectId";
            // 
            // ObjectClass
            // 
            this.ObjectClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ObjectClass.DataPropertyName = "Name";
            this.ObjectClass.HeaderText = "Widget name";
            this.ObjectClass.Name = "ObjectClass";
            // 
            // VariableName
            // 
            this.VariableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VariableName.DataPropertyName = "VariableName";
            this.VariableName.HeaderText = "C++ Variable name";
            this.VariableName.Name = "VariableName";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.FormGridView);
            this.Controls.Add(this.CreateClassFilesButton);
            this.Controls.Add(this.ObjectsDataGrid);
            this.Controls.Add(this.ClassFileDirectoryChooseButton);
            this.Controls.Add(this.FormMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirectoryClassFilesTextBox);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.FormMenu.ResumeLayout(false);
            this.FormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog gladeFileOpen;
        private System.Windows.Forms.DataGridView ObjectsDataGrid;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button ClassFileDirectoryChooseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DirectoryClassFilesTextBox;
        private System.Windows.Forms.Button CreateClassFilesButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserClass;
        private System.Windows.Forms.DataGridView FormGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.MenuStrip FormMenu;
        private System.Windows.Forms.ToolStripMenuItem FormMenuFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeGladeFileToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableName;
    }
}

