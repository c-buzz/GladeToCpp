using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;
using GladeConstructor.Parser;

namespace GladeConstructor.Parser
{
    public class GladeParser
    {

        /*
         * ToDo: For the moment, only widgets, windows and objects with a valid id will be considered
         * */
        //public List<BindingSource> ObjectBindingSources = new List<BindingSource>();
        public BindingSource FormBindingSources = new BindingSource();
        public List<BindingSource> OuterObjects = new List<BindingSource>();
        
        public GladeParser(string GladeFileName)
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
                        //TODO It is an Outer object
                    }
                }
            }

        }        
    }
}
