using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GladeConstructor.Parser
{
    public class BindingForm
    {
        [Browsable(false)] // Hide in datagridview
        public long GUIContainerId { get; set; }
        [Browsable(false)] // Hide in datagridview
        public Stream HeaderCodeStream { get; set; }
        [Browsable(false)] // Hide in datagridview
        public Stream SourceCodeStream { get; set; }
        /// <summary>
        /// Id of the signal container the Window is referred to. It is used to track the SignalContainer
        /// opened.
        /// </summary>
        [Browsable(false)] // Hide in datagridview
        public long GUISignalContainerId { get; set; }

        public string Id { get; set; }

        /// <summary>
        ///     C++ Class name referring to the current Window Form
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        ///     It establish whether the C++ class is to be created or not
        /// </summary>
        public bool CodeProcess { get; set; }

        /// <summary>
        /// List of widgets belonging to the Window. To be built into GladeParser
        /// </summary>
        public BindingSource Widgets = new BindingSource();

        public BindingSource Signals = new BindingSource();

        public BindingForm(XmlNode xmlNode)
        {
            Id = GetId(xmlNode);
            Init();
            ParseFormNode(xmlNode);
        }

        private void Init()
        {
            // Class name is initialized to Form id
            Class = Id;
            CodeProcess = true;
            GUIContainerId = -1;
            GUISignalContainerId = -1;
            Signals = new BindingSource();
            HeaderCodeStream = null;
            SourceCodeStream = null;
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
                    Widgets.Add(new BindingWidget(node));
                    //ParseWidget(node);
                    
                }
            }

            ParseSignals(formNode);
        }

        /// <summary>
        /// Establishes if the object has an Id. If so, a new widget is built
        /// </summary>
        /// <param name="widgetNode">XmlNode containing the object</param>
        /// <returns></returns>
        private bool ParseWidget(XmlNode widgetNode)
        {
            if (widgetNode.Attributes["id"] != null)
            {
                // Create new widget
                //TODO: Distinguish between object and widget
                string id = widgetNode.Attributes["id"].Value;
                string name = widgetNode.Attributes["class"].Value;
                string variableName = id;
                BindingWidget bindingWidget = new BindingWidget(id, name, variableName);
                Widgets.Add(bindingWidget);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsWidget()
        {
            return false;
        }

        private void ParseSignals(XmlNode formNode)
        {
            // If we are here, the widget has the Attribute id
            foreach (XmlNode node in formNode.SelectNodes("./signal"))
            {
                BindingSignal bindingSignal = new BindingSignal(node);
                Signals.Add(bindingSignal);
            }
        }

    }
}
