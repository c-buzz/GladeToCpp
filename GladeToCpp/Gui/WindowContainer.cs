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
using GladeConstructor.GladeParser;

namespace GladeConstructor.Gui
{
    public partial class WindowContainer : DockContent
    {
        public GtkParser gladeParser { get; set; }
        
        public WindowContainer()
        {
            InitializeComponent();
        }

        public WindowContainer(GtkParser parser)
        {
            gladeParser = parser;
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
            BindingForm source = (BindingForm)gladeParser.FormBindingSources[pressed_cell];
            var WidgetContainer = GuiManager.CreateWidgetPanel(source);

            
        }
    }
}
