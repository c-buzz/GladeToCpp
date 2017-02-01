namespace GladeConstructor.Gui
{
    partial class WindowContainer
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
            this.FormGridView = new System.Windows.Forms.DataGridView();
            this.CodeProcess = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.FormGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FormGridView
            // 
            this.FormGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProcess,
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
            this.FormGridView.Location = new System.Drawing.Point(0, 28);
            this.FormGridView.MultiSelect = false;
            this.FormGridView.Name = "FormGridView";
            this.FormGridView.RowHeadersVisible = false;
            this.FormGridView.Size = new System.Drawing.Size(522, 219);
            this.FormGridView.TabIndex = 12;
            this.FormGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FormGridView_CellContentDoubleClick);
            this.FormGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FormGridView_CellDoubleClick);
            // 
            // CodeProcess
            // 
            this.CodeProcess.DataPropertyName = "CodeProcess";
            this.CodeProcess.HeaderText = "Include";
            this.CodeProcess.Name = "CodeProcess";
            this.CodeProcess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // Toolbar
            // 
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(522, 25);
            this.Toolbar.TabIndex = 13;
            this.Toolbar.Text = "toolStrip1";
            // 
            // WindowContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 247);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.FormGridView);
            this.Name = "WindowContainer";
            ((System.ComponentModel.ISupportInitialize)(this.FormGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FormGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CodeProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.ToolStrip Toolbar;
    }
}
