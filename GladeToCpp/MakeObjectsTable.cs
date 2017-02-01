using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GladeConstructor
{
    class MakeObjectsTable
    {
        public BindingSource bindingSource;

        public enum Title
        {
            Add,
            Object
        };

        public MakeObjectsTable(DataGridView dgv)
        {
            bindingSource = new BindingSource();

            // Column 0: CheckBox for "Add to class"
            

        }

    }
}
