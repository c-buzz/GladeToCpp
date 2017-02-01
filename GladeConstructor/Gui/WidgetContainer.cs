using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GladeConstructor.GladeParser;
using WeifenLuo.WinFormsUI.Docking;

namespace GladeConstructor.Gui
{
    public partial class WidgetContainer : DockContent
    {
        public static ObjectIDGenerator WidgetContainerId = new ObjectIDGenerator();

        private bool isFirstTime;

        public long ID
        {
            get
            {
                return WidgetContainerId.GetId(this, out isFirstTime);
            }
        }

        public WidgetContainer()
        {
            InitializeComponent();
        }

        public WidgetContainer(BindingForm form)
        {
            InitializeComponent();
            SetDataSource(form.Widgets);
        }

        public void SetDataSource(BindingSource source)
        {
            ObjectsDataGrid.DataSource = source;
        }

        private void ObjectsDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ObjectsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
