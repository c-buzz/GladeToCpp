using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladeConstructor.GladeParser
{
    class BindingWidget
    {
        public BindingWidget(string id, string name, string variableName, bool addToClass = true)
        {
            Id = id;
            Name = name;
            VariableName = variableName;
            AddToClass = addToClass;
        }

        public string Id { get; set; }

        /**
         * The NAME of the Gtk Widget 
         */
        public string Name { get; set; }

        // The name of the cpp variable pointing to the widget
        public string VariableName { get; set; }

        public bool AddToClass { get; set; }
    }
}
