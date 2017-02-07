namespace GladeConstructor.Gui
{
    partial class SignalContainer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddToClass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Callback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddToClass,
            this.Callback,
            this.SignalName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(466, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddToClass
            // 
            this.AddToClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AddToClass.DataPropertyName = "AddToClass";
            this.AddToClass.HeaderText = "Add to C++ class";
            this.AddToClass.Name = "AddToClass";
            this.AddToClass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddToClass.Width = 62;
            // 
            // Callback
            // 
            this.Callback.DataPropertyName = "Callback";
            this.Callback.HeaderText = "Callback name";
            this.Callback.Name = "Callback";
            // 
            // SignalName
            // 
            this.SignalName.DataPropertyName = "Name";
            this.SignalName.HeaderText = "Name";
            this.SignalName.Name = "SignalName";
            // 
            // SignalContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 264);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SignalContainer";
            this.Text = "SignalContainer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AddToClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Callback;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalName;
    }
}