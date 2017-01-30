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
            this.gladeFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.GladeFileNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GtkWindowGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassNameTextBox = new System.Windows.Forms.TextBox();
            this.GtkWindowListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ObjectsGroupBox = new System.Windows.Forms.GroupBox();
            this.HideNonIdObjectCheckBox = new System.Windows.Forms.CheckBox();
            this.ObjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.InClass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CreateClassFilesButton = new System.Windows.Forms.Button();
            this.DirectoryClassFilesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassFileDirectoryChooseButton = new System.Windows.Forms.Button();
            this.folderBrowserClass = new System.Windows.Forms.FolderBrowserDialog();
            this.GtkWindowGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ObjectsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gladeFileOpen
            // 
            this.gladeFileOpen.FileName = "gladeOpener";
            this.gladeFileOpen.Filter = "Glade files|*.glade|Xml|.xml";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(573, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GladeFileNameTextbox
            // 
            this.GladeFileNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GladeFileNameTextbox.Location = new System.Drawing.Point(12, 25);
            this.GladeFileNameTextbox.Name = "GladeFileNameTextbox";
            this.GladeFileNameTextbox.Size = new System.Drawing.Size(555, 20);
            this.GladeFileNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Open Glade file";
            // 
            // GtkWindowGroupBox
            // 
            this.GtkWindowGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GtkWindowGroupBox.Controls.Add(this.ClassFileDirectoryChooseButton);
            this.GtkWindowGroupBox.Controls.Add(this.label3);
            this.GtkWindowGroupBox.Controls.Add(this.DirectoryClassFilesTextBox);
            this.GtkWindowGroupBox.Controls.Add(this.CreateClassFilesButton);
            this.GtkWindowGroupBox.Controls.Add(this.label2);
            this.GtkWindowGroupBox.Controls.Add(this.ClassNameTextBox);
            this.GtkWindowGroupBox.Controls.Add(this.GtkWindowListBox);
            this.GtkWindowGroupBox.Enabled = false;
            this.GtkWindowGroupBox.Location = new System.Drawing.Point(15, 13);
            this.GtkWindowGroupBox.Name = "GtkWindowGroupBox";
            this.GtkWindowGroupBox.Size = new System.Drawing.Size(567, 160);
            this.GtkWindowGroupBox.TabIndex = 3;
            this.GtkWindowGroupBox.TabStop = false;
            this.GtkWindowGroupBox.Text = "GtkWindow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Class Name";
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.Location = new System.Drawing.Point(262, 39);
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.Size = new System.Drawing.Size(290, 20);
            this.ClassNameTextBox.TabIndex = 5;
            // 
            // GtkWindowListBox
            // 
            this.GtkWindowListBox.Location = new System.Drawing.Point(6, 19);
            this.GtkWindowListBox.Name = "GtkWindowListBox";
            this.GtkWindowListBox.Size = new System.Drawing.Size(244, 134);
            this.GtkWindowListBox.TabIndex = 0;
            this.GtkWindowListBox.SelectedIndexChanged += new System.EventHandler(this.GtkWindowListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ObjectsGroupBox);
            this.panel1.Controls.Add(this.GtkWindowGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 514);
            this.panel1.TabIndex = 4;
            // 
            // ObjectsGroupBox
            // 
            this.ObjectsGroupBox.Controls.Add(this.HideNonIdObjectCheckBox);
            this.ObjectsGroupBox.Controls.Add(this.ObjectsDataGrid);
            this.ObjectsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ObjectsGroupBox.Enabled = false;
            this.ObjectsGroupBox.Location = new System.Drawing.Point(0, 179);
            this.ObjectsGroupBox.Name = "ObjectsGroupBox";
            this.ObjectsGroupBox.Size = new System.Drawing.Size(633, 335);
            this.ObjectsGroupBox.TabIndex = 4;
            this.ObjectsGroupBox.TabStop = false;
            this.ObjectsGroupBox.Text = "Objects";
            // 
            // HideNonIdObjectCheckBox
            // 
            this.HideNonIdObjectCheckBox.AutoSize = true;
            this.HideNonIdObjectCheckBox.Location = new System.Drawing.Point(13, 20);
            this.HideNonIdObjectCheckBox.Name = "HideNonIdObjectCheckBox";
            this.HideNonIdObjectCheckBox.Size = new System.Drawing.Size(162, 17);
            this.HideNonIdObjectCheckBox.TabIndex = 1;
            this.HideNonIdObjectCheckBox.Text = "Hide object with an empty ID";
            this.HideNonIdObjectCheckBox.UseVisualStyleBackColor = true;
            this.HideNonIdObjectCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ObjectsDataGrid
            // 
            this.ObjectsDataGrid.AutoGenerateColumns = false;
            this.ObjectsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ObjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InClass,
            this.ObjectId,
            this.ObjectClass,
            this.VariableName});
            this.ObjectsDataGrid.DataSource = this.bindingSource1;
            this.ObjectsDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ObjectsDataGrid.Location = new System.Drawing.Point(3, 43);
            this.ObjectsDataGrid.Name = "ObjectsDataGrid";
            this.ObjectsDataGrid.Size = new System.Drawing.Size(627, 289);
            this.ObjectsDataGrid.TabIndex = 0;
            // 
            // InClass
            // 
            this.InClass.DataPropertyName = "AddObjectToClass";
            this.InClass.HeaderText = "";
            this.InClass.Name = "InClass";
            this.InClass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.InClass.ToolTipText = "Add to C++ class";
            // 
            // ObjectId
            // 
            this.ObjectId.DataPropertyName = "ObjectId";
            this.ObjectId.HeaderText = "Object Id";
            this.ObjectId.Name = "ObjectId";
            this.ObjectId.ReadOnly = true;
            // 
            // ObjectClass
            // 
            this.ObjectClass.DataPropertyName = "ObjectType";
            this.ObjectClass.HeaderText = "Type";
            this.ObjectClass.Name = "ObjectClass";
            this.ObjectClass.ReadOnly = true;
            // 
            // VariableName
            // 
            this.VariableName.DataPropertyName = "ObjectNameInClass";
            this.VariableName.HeaderText = "Variable";
            this.VariableName.Name = "VariableName";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // CreateClassFilesButton
            // 
            this.CreateClassFilesButton.Location = new System.Drawing.Point(477, 130);
            this.CreateClassFilesButton.Name = "CreateClassFilesButton";
            this.CreateClassFilesButton.Size = new System.Drawing.Size(75, 23);
            this.CreateClassFilesButton.TabIndex = 7;
            this.CreateClassFilesButton.Text = "Create Class";
            this.CreateClassFilesButton.UseVisualStyleBackColor = true;
            this.CreateClassFilesButton.Click += new System.EventHandler(this.CreateClassFilesButton_Click);
            // 
            // DirectoryClassFilesTextBox
            // 
            this.DirectoryClassFilesTextBox.Location = new System.Drawing.Point(262, 87);
            this.DirectoryClassFilesTextBox.Name = "DirectoryClassFilesTextBox";
            this.DirectoryClassFilesTextBox.Size = new System.Drawing.Size(256, 20);
            this.DirectoryClassFilesTextBox.TabIndex = 8;
            this.DirectoryClassFilesTextBox.Text = "C:\\Users\\Buzz\\Desktop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Directory for saving class files";
            // 
            // ClassFileDirectoryChooseButton
            // 
            this.ClassFileDirectoryChooseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassFileDirectoryChooseButton.Location = new System.Drawing.Point(524, 87);
            this.ClassFileDirectoryChooseButton.Name = "ClassFileDirectoryChooseButton";
            this.ClassFileDirectoryChooseButton.Size = new System.Drawing.Size(28, 20);
            this.ClassFileDirectoryChooseButton.TabIndex = 10;
            this.ClassFileDirectoryChooseButton.Text = "...";
            this.ClassFileDirectoryChooseButton.UseVisualStyleBackColor = true;
            this.ClassFileDirectoryChooseButton.Click += new System.EventHandler(this.ClassFileDirectoryChooseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GladeFileNameTextbox);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GtkWindowGroupBox.ResumeLayout(false);
            this.GtkWindowGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ObjectsGroupBox.ResumeLayout(false);
            this.ObjectsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog gladeFileOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GladeFileNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GtkWindowGroupBox;
        private System.Windows.Forms.ListBox GtkWindowListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassNameTextBox;
        private System.Windows.Forms.GroupBox ObjectsGroupBox;
        private System.Windows.Forms.DataGridView ObjectsDataGrid;
        private System.Windows.Forms.CheckBox HideNonIdObjectCheckBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableName;
        private System.Windows.Forms.Button ClassFileDirectoryChooseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DirectoryClassFilesTextBox;
        private System.Windows.Forms.Button CreateClassFilesButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserClass;
    }
}

