using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BuildSignalsConfiguration
{
    class Program
    {
        static XmlDocument doc = new XmlDocument();
        static XmlNode signalsNode;

        static void Main(string[] args)
        {
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            signalsNode = doc.CreateElement("signals");
            
            string[] file_list = Directory.GetFiles(@"C:\msys64\mingw64\include\gtkmm-3.0\gtkmm", "*.h");

            foreach (string filename in file_list)
            {
                ProcessFile(filename);
            }

            doc.AppendChild(signalsNode);

            doc.Save("foo.xml");


        }

        static void ProcessFile(string filename)
        {
            StreamReader file = new StreamReader(filename);
            
            while ((file.ReadLine() != "  //Default Signal Handlers::") && (!file.EndOfStream))
            {

            }
            if (!file.EndOfStream)
            {
                string handler_line, proto_line;
                handler_line = file.ReadLine();
                proto_line = file.ReadLine();
                while (handler_line.StartsWith("  /// This is a default handler for the signal"))
                {
                    ProcessXmlNode(handler_line, proto_line, Path.GetFileNameWithoutExtension(filename));
                    handler_line = file.ReadLine();
                    proto_line = file.ReadLine();
                }
            }



        }

        static void ProcessXmlNode(string handler_line, string prototype_line, string caller) 
        {
            var signal_node = doc.CreateElement("signal");
            
            /* Work on handlerline */
            int start = handler_line.IndexOf("signal_") + 7;
            int length = handler_line.IndexOf(".") - start;
            string name = handler_line.Substring(start, length);

            /* work on prototype_line */
            start = prototype_line.IndexOf("virtual ") + 8;
            length = prototype_line.IndexOf(";") - start;
            string prototype = prototype_line.Substring(start, length);


            // Add name attribute 
            var nameattr = doc.CreateAttribute("name");
            nameattr.Value = name.Substring(0, name.Length - 2).Replace('_', '-');
            signal_node.Attributes.Append(nameattr);

            // Add caller attribute
            var callerattr = doc.CreateAttribute("caller");
            callerattr.Value = caller;
            signal_node.Attributes.Append(callerattr);

            // Append method attribute
            var method_node = doc.CreateElement("method");
            method_node.InnerText = @"signal_" + @name;
            signal_node.AppendChild(method_node);

            // Append prototype attribute
            // Append method attribute
            var proto_node = doc.CreateElement("prototype");
            proto_node.InnerText = @prototype;
            signal_node.AppendChild(proto_node);

            signalsNode.AppendChild(signal_node);
       

        }
    }
}
