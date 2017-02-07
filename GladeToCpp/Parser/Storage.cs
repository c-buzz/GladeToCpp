using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GladeConstructor.Parser
{
    public class Storage
    {
        public static GladeParser Parser;

        public static XmlElement ConfigurationDocument;
        public static XmlElement SignalConfig;

        public static void LoadConfigurationDocument()
        {
            Console.WriteLine(ConfigurationResource.config);
            XmlDocument doc = new XmlDocument();
            /*doc.LoadXml(ConfigurationResource.config);
            ConfigurationDocument = doc.DocumentElement;*/

            doc = new XmlDocument();
            doc.LoadXml(ConfigurationResource.signals);
            SignalConfig = doc.DocumentElement;
        }
    }
}
