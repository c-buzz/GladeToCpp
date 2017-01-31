using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GladeConstructor.GladeParser
{
    class BindingForm
    {
        private string id, classname;
        public string Id { get { return id; } set { id = value; } }
        public string Class { get { return classname; } set { classname = value; } }

        // List of widgets belonging to the Window. To be built into GtkParser
        public BindingSource Widgets = new BindingSource();

        public BindingSource Signals = new BindingSource();

        public BindingForm(XmlNode xmlNode)
        {
            Id = GetId(xmlNode);
            ParseFormNode(xmlNode);
            // Class name is initialized to Form id
            Class = Id;
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
            XmlNodeList xnList = formNode.SelectNodes(".//object");//[@id='"+Id+"']/object");
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
