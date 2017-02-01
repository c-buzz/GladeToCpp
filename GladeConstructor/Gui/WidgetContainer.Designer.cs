namespace GladeConstructor.Gui
{
    partial class WidgetContainer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ObjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.InClass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectsDataGrid
            // 
            this.ObjectsDataGrid.AllowUserToAddRows = false;
            this.ObjectsDataGrid.AllowUserToDeleteRows = false;
            this.ObjectsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ObjectsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ObjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InClass,
            this.ObjectId,
            this.ObjectClass,
            this.VariableName});
            this.ObjectsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ObjectsDataGrid.Name = "ObjectsDataGrid";
            this.ObjectsDataGrid.RowHeadersVisible = false;
            this.ObjectsDataGrid.Size = new System.Drawing.Size(410, 252);
            this.ObjectsDataGrid.TabIndex = 1;
            this.ObjectsDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObjectsDataGrid_CellContentDoubleClick);
            this.ObjectsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObjectsDataGrid_CellDoubleClick);
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
            // WidgetContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 252);
            this.Controls.Add(this.ObjectsDataGrid);
            this.Name = "WidgetContainer";
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ObjectsDataGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableName;
    }
}
