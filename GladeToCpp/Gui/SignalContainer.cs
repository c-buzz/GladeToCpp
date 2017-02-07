using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using WeifenLuo.WinFormsUI.Docking;

namespace GladeConstructor.Gui
{
    public partial class SignalContainer : DockContent
    {
        public static ObjectIDGenerator SignalContainerId = new ObjectIDGenerator();

        private bool isFirstTime;

        public long ID
        {
            get
            {
                return SignalContainerId.GetId(this, out isFirstTime);
            }
        }

        public void SetDataSource(BindingSource source)
        {
            dataGridView1.DataSource = source;
        }

        public SignalContainer()
        {
            InitializeComponent();
        }
    }
}
