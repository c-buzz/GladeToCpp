using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace GladeConstructor.GladeParser
{
    class BindingSignal
    {
        public string Name { get; set; }
        public string Method { get; set; }

        // Specify if the method is present into the built class or if it is external
        public bool IsInClass { get; set; }

        /*
         * IsInClass = true -> it represents the class in which the widget is inserted
         * IsInClass = false -> it represents the class where the callback is located
         * */
        public string Class { get; set; }

        XmlElement ConfigDocument;

        public BindingSignal(XmlNode node, string _class, bool isInClass = true)
        {
            InitConfigDocument();
            ParseNode(node);
            IsInClass = isInClass;
            Class = _class;
        }

        public BindingSignal(string name, string method, string _class, bool isInClass = true)
        {
            Name = name;
            Method = method;
            IsInClass = isInClass;
            Class = _class;
            InitConfigDocument();
        }

        private void InitConfigDocument()
        {
            //TODO: implement the xml configuration document as an internal resource
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load("SignalConfig.xml");
            ConfigDocument = xml_doc.DocumentElement;
        }

        private void ParseNode(XmlNode node)
        {
            //foreach (XmlNode signalNode in node.SelectNodes("//signal"))
            {
                string signalName = node.Attributes["name"].Value;
                Method = GetMethod(signalName);
                Name = signalName;
            }
        }

        private string GetMethod(string signalName)
        {
            XmlNode node = ConfigDocument.SelectSingleNode("//signal[name='" + signalName + "']/method");
            if (node != null)
            {
                return node.InnerText;
            }
            else
            {
                //MessageBox.Show("Error: Signal " + signalName + " not found in configuration file!");
            }
            return null;
        }

        // It represents the prototype to be written in .cpp/.h files
        private string GetPrototype(string signalName)
        {
            XmlNode node = ConfigDocument.SelectSingleNode("//signal[name='" + signalName + "']/prototype");
            if (node != null)
            {
                return node.InnerText;
            }
            else
            {
               // MessageBox.Show("Error: Signal " + signalName + " not found in configuration file!");
            }
            return null;
        }
    }
}
