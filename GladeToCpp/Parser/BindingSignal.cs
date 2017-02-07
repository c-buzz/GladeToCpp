using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.ComponentModel;

namespace GladeConstructor.Parser
{
    class BindingSignal
    {

        /// <summary>
        /// The name of the signal
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Signal handler: it represents the method of the widget that send the signal
        /// </summary>
        [Browsable(false)]
        public string Method { get; set; }

        /// <summary>
        /// The C++ prototype string for the signal callback
        /// </summary>
        public string Prototype
        {
            get
            {
                return return_type + " " + Callback + "(" + arguments + ")";
            }
        }

        public string BuildSourceCallback(string classname)
        {
            return return_type + " " + classname + "::" + Callback + "(" + arguments + ")";
        } 

        // Specify if the method is present into the built class or if it is external
        public bool AddToClass { get; set; }

        /*
         * IsInClass = true -> it represents the class in which the widget is inserted
         * IsInClass = false -> it represents the class where the callback is located
         * */
        //public string Class { get; set; }

        private string return_type, arguments;

        public string Callback { get; set; }

        private XmlNode SignalNode;

        public BindingSignal(XmlNode node, bool isInClass = true)
        {
            SignalNode = node;
            ParseNode();
            AddToClass = isInClass;
            //Class = _class;
        }

        public BindingSignal(string name, string method, bool isInClass = true)
        {
            Name = name;
            Method = method;
            AddToClass = isInClass;
            //Class = _class;
        }

        private void ParseNode()
        {
            string signalName = SignalNode.Attributes["name"].Value;
            Method = GetMethod(signalName);
            Name = signalName;
            GetPrototype(signalName);
        }

        private void GetPrototype(string signalName)
        {
            XmlNode node = Storage.SignalConfig.SelectSingleNode("//signal[@name='" + signalName + "']/prototype");
            if (node != null)
            {
                string proto = node.InnerText;
                // extract return_type
                return_type = proto.Substring(0, proto.IndexOf(" "));
                // Extract arguments
                int start = proto.IndexOf("(") + 1;
                int stop = proto.LastIndexOf(")");
                arguments = (start == stop) ? "" : proto.Substring(start, stop - start);

                // Extract callback
                start = proto.IndexOf(" ") + 1;
                stop = proto.IndexOf("(");
                Callback = proto.Substring(start, stop - start);
            }
            else
            {
                MessageBox.Show("Signal named '" + signalName + "' not found in configuration file\n" +
                    "Please report this on https://github.com/c-buzz/GladeToCpp/issues");
            }
        }

        private string GetMethod(string signalName)
        {
            XmlNode node = Storage.SignalConfig.SelectSingleNode("//signal[@name='" + signalName + "']/method");
            if (node != null)
            {
                return node.InnerText;
            }
            else
            {
                MessageBox.Show("Signal named '" + signalName + "' not found in configuration file\n" +
                    "Please report this on https://github.com/c-buzz/GladeToCpp/issues");
            }
            return null;
        }

    }
}
