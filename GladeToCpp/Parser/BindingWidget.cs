using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace GladeConstructor.Parser
{
    public class BindingWidget
    {
        public BindingWidget(string id, string name, string variableName, bool addToClass = true)
        {
            Id = id;
            Name = name;
            VariableName = variableName;
            AddToClass = addToClass;
            Signals = new BindingSource();
        }

        public BindingWidget(XmlNode node, bool addToClass = true)
        {
            Signals = new BindingSource();
            if (node.Attributes["id"] != null)
            {
                Id = node.Attributes["id"].Value;
                Name = node.Attributes["class"].Value;
                VariableName = Id;
                ParseNode(node);
                AddToClass = addToClass;
            }
            
        }

        private void ParseNode(XmlNode node)
        {
            foreach (XmlNode signalNode in node.SelectNodes(".//signal"))
            {
                BindingSignal signal = new BindingSignal(signalNode);
                Signals.Add(signal);
            }
        }


        /// <summary>
        /// Id of the signal container to which the Widget is referred. It is used to track the SignalContainer
        /// opened.
        /// </summary>
        [Browsable(false)] // Hide in datagridview
        public long GUISignalContainerId { get; set; }

        /// <summary>
        ///     Id given to the widget in glade file
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     The NAME of the widget in Gtk libraries [Gtk::Name]
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The name of the C++ variable pointing to the widget
        /// </summary>
        public string VariableName { get; set; }

        /// <summary>
        /// A bool variable stating whether the widgets is to be considered into class building or not
        /// </summary>
        public bool AddToClass { get; set; }

        /// <summary>
        /// Collection of signals referred to the widget
        /// </summary>
        public BindingSource Signals { get; set; }
    }
}
