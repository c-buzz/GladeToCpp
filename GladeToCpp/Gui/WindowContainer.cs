using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using GladeConstructor.Parser;

namespace GladeConstructor.Gui
{
    public partial class WindowContainer : DockContent
    {
        private int RightClickedCell = -1;

        public WindowContainer()
        {
            InitializeComponent();
        }

        public void SetDataSource(BindingSource source)
        {
            FormGridView.DataSource = source;
        }

        private void FormGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Open a new form with the corresponding widget lists
            var pressed_cell = e.RowIndex;
            BindingForm source = (BindingForm)Storage.Parser.FormBindingSources[pressed_cell];
            var WidgetContainer = GuiManager.CreateWidgetPanel(source);

            
        }

        private void GtkWindowsDataGridMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showSignalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RightClickedCell >= 0)
            {
                var signalContainer = GuiManager.CreateSignalPanel(Storage.Parser.FormBindingSources[RightClickedCell] as BindingForm);
                //signalContainer.SetDataSource()
            }
        }

        private void FormGridView_Click(object sender, EventArgs e)
        {
        }

        private void FormGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void GtkWindowsDataGridMenuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            //RightClickedCell = -2;
        }

        private void FormGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightClickedCell = e.RowIndex;
            }
        }
    }
}
