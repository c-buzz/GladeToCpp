using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace GladeConstructor
{
    class GtkParser
    {
        private XmlReader reader;
        public List<string> GtkWindowsId;
        

        public List<BindingSource> ObjectBindingSources = new List<BindingSource>();
        public List<BindingSource> ObjectBindingSourcesWithoutEmptyId = new List<BindingSource>();
       


        public struct GtkObject
        {
            public int parentWindow;
            public string id;
            public string type;
        }

        public List<GtkObject> GtkObjectList = new List<GtkObject>();

        public GtkParser(string FileName)
        {
            reader = XmlReader.Create(FileName);
            XmlDocument doc = new XmlDocument();
            doc.Load(FileName);
            
            XmlNodeList nodelist = doc.GetElementsByTagName("object");
            SelectWindowNode(nodelist);
            ExtractForms(doc);

        }

        void ExtractForms(XmlDocument doc)
        {
            GtkWindowsId = new List<string>();
            int index = 0;
            foreach (XmlNode node in doc.DocumentElement.SelectNodes("//object[@class='GtkWindow']"))
            {
                if (node.Attributes["id"]!= null)
                {
                    GtkWindowsId.Add(node.Attributes["id"].Value);
                }
                else
                {
                    GtkWindowsId.Add("");
                }

                // Extract subobject
                ObjectBindingSources.Add(new BindingSource());
                ObjectBindingSourcesWithoutEmptyId.Add(new BindingSource());
                foreach (XmlNode subobject in node.SelectNodes(".//object"))
                {
                    if (subobject.Attributes["class"] != null)
                    {
                        GtkObject gtkobj;
                        gtkobj.parentWindow = index;
                        gtkobj.type = subobject.Attributes["class"].Value;
                        gtkobj.id = (subobject.Attributes["id"] != null) ? subobject.Attributes["id"].Value : "";
                        GtkObjectList.Add(gtkobj);
                        BindingObject bindingObj = new BindingObject(gtkobj.id, gtkobj.type, gtkobj.id, gtkobj.id != "");


                        // Build signals
                        //XmlNodeList childrens = subobject.ChildNodes;
                        foreach (XmlNode child in subobject.SelectNodes(".//signal"))
                        {
                            if (child.Attributes["name"] != null)
                            {
                                BindingObject.SignalStruct signal_struct;
                                signal_struct.callback = child.Attributes["handler"].Value;
                                signal_struct.type = child.Attributes["name"].Value;
                                bindingObj.Signals.Add(signal_struct);
                            }
                        }

                        ObjectBindingSources[index].Add(bindingObj);
                        if (subobject.Attributes["id"] != null)
                        {
                            ObjectBindingSourcesWithoutEmptyId[index].Add(bindingObj);
                        }
                    }
                }
                index++;
            }
        }

        void SelectWindowNode(XmlNodeList input)
        {
            foreach (XmlNode node in input)
            {
                if (node.Attributes["class"] != null)
                {
                    if (node.Attributes["class"].Value == "GtkWindow")
                    {
                        //this.WindowsNodes.Add(node);
                        if (node.Attributes["id"] != null)
                            System.Console.WriteLine(node.Attributes["id"].Value);
                    }
                        
                }
            }
        }

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
        }
        
    }
}
