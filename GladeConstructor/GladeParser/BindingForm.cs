using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GladeConstructor.GladeParser
{
    public class BindingForm
    {
        [Browsable(false)] // Hide in datagridview
        public long GUIContainerId { get; set; }

        public string Id { get; set; }

        /// <summary>
        ///     C++ Class name referring to the current Window Form
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        ///     It establish whether the C++ class is to be created or not
        /// </summary>
        public bool CodeProcess { get; set; }

        // List of widgets belonging to the Window. To be built into GtkParser
        public BindingSource Widgets = new BindingSource();

        public BindingSource Signals = new BindingSource();

        public BindingForm(XmlNode xmlNode)
        {
            Id = GetId(xmlNode);
            ParseFormNode(xmlNode);
            // Class name is initialized to Form id
            Class = Id;
            CodeProcess = true;
            GUIContainerId = -1;
        }

        private string GetId(XmlNode xmlNode)
        {
            if (xmlNode.Attributes["id"] != null)
            {
                return xmlNode.Attributes["id"].Value;
            }
            else
            {
                return null;
            }

        }

        private void ParseFormNode(XmlNode formNode)
        {
            XmlNodeList xnList = formNode.SelectNodes(".//object");
            foreach (XmlNode node in xnList)
            {
                // ToDo: Consider also idless node
                if (node.Attributes["id"] != null)
                {
                    if (ParseWidget(node))
                    {
                        ParseWidgetSignals(node);
                    }
                }
            }
        }

        private bool ParseWidget(XmlNode widgetNode)
        {
            if (widgetNode.Attributes["id"] != null)
            {
                // Create new widget
                //TODO: Distinguish between object and widget
                string id = widgetNode.Attributes["id"].Value;
                string name = widgetNode.Attributes["class"].Value;
                string variableName = name;
                BindingWidget bindingWidget = new BindingWidget(id, name, variableName);
                Widgets.Add(bindingWidget);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ParseWidgetSignals(XmlNode widgetNode)
        {
            // If we are here, the widget has the Attribute id
            foreach (XmlNode node in widgetNode.SelectNodes("//signal"))
            {
                BindingSignal bindingSignal = new BindingSignal(node, Class);
                Signals.Add(bindingSignal);
            }
        }

    }
}
