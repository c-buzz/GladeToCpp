using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using GladeConstructor.GladeParser;

namespace GladeConstructor
{
    public class GtkParser
    {

        /*
         * ToDo: For the moment, only widgets, windows and objects with a valid id will be considered
         * */
        //public List<BindingSource> ObjectBindingSources = new List<BindingSource>();
        public BindingSource FormBindingSources = new BindingSource();
        public List<BindingSource> OuterObjects = new List<BindingSource>();
        //public List<BindingSource> WidgetsBindingSources = new List<BindingSource>();
        
            // To Be Erased!
        public List<BindingSource> ObjectBindingSourcesWithoutEmptyId = new List<BindingSource>();
       
        

        public GtkParser(string GladeFileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(GladeFileName);
            XmlElement element = doc.DocumentElement;
            ProcessGladeXml(element);
        }

        private void ProcessGladeXml(XmlElement doc_element)
        {
            foreach (XmlNode node in doc_element.SelectNodes("/interface/object"))
            {
                // Nameless nodes are not considered
                if (node.Attributes["id"] != null)
                {
                    if (node.Attributes["class"].Value == "GtkWindow")
                    {
                        // We found a window!
                        BindingForm form = new BindingForm(node);
                        FormBindingSources.Add(form);                        
                    }
                    else
                    {
                        // It is an Outer object
                        //TODO
                    }
                }
            }

        }

    /*

        private string[] ExtractSignalCallbacks(BindingObject widget)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SignalConfig.xml");

            string[] output = new string[widget.Signals.Count];

            int i = 0;
            foreach (BindingObject.SignalStruct signal in widget.Signals)
            {

                string signal_name = signal.type;
                XmlNode SignalNode = doc.DocumentElement.SelectSingleNode("//signal[@name='" + signal_name + "']/struct");
                string callback = SignalNode.InnerText;
                output[i] = callback;
            }
            return output;
        }

        public string[] BuildHeaderCallback(BindingObject widget)
        {
            string[] callbacks = ExtractSignalCallbacks(widget);
            string[] output = new string[callbacks.Length];
            int i = 0;
            foreach (string callback in callbacks)
            {
                output[i] = callback.Replace("callback", widget.Signals[i].callback);
                i++;
            }
            return output;
        }
        
        public string[] BuildSourceCallback(BindingObject widget, string ClassName)
        {
            string[] callbacks = ExtractSignalCallbacks(widget);
            string[] output = new string[callbacks.Length];
            int i = 0;
            foreach (string callback in callbacks)
            {
                output[i] = callback.Replace("callback", ClassName + "::" + widget.Signals[i].callback);
                i++;
            }
            return output;
        }

        public string ExtractGtkmmSignalMethod(string signal_name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SignalConfig.xml");
            XmlNode node = doc.DocumentElement.SelectSingleNode("//signal[@name='" + signal_name + "']/method");
            if (node != null)
            {
                return node.InnerText;
            }
            else
            {
                return null;
            }
        }*/
        
    }
}
