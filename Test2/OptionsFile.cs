using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Mod
{
    [GeneratedCode("xsd", "4.0.30319.1")]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "Options", Namespace = "", IsNullable = false)]
    [Serializable]
    public class Options
    {

        public static string fileName= "twitch.xml";

        [XmlElement("enableTwitchVoting", Form = XmlSchemaForm.Unqualified)]
        public string enableTwitchVoting { get; set; }


        [XmlElement("twitchChannelName", Form = XmlSchemaForm.Unqualified)]
        public string twitchChannelName { get; set; }


        [XmlElement("twitchUserName", Form = XmlSchemaForm.Unqualified)]
        public string twitchUserName { get; set; }


        [XmlElement("oAuth", Form = XmlSchemaForm.Unqualified)]
        public string oAuth { get; set; }

        private Options()
        {}


        public static Options createDefaultOptions()
        {
            return new Options();
        }
    }



    internal class OptionsFile
	{

        public static Options readFile()
        {
            Options objectOut = Options.createDefaultOptions();

            if (!File.Exists(Options.fileName) || string.IsNullOrEmpty(Options.fileName))
            {
                return objectOut;
            }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(Options.fileName);

                using (StringReader read = new StringReader(xmlDocument.OuterXml))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Options));
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (Options)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO add some logs
            }

            return objectOut;
        }


        public static void writeFile(Options options)
        {
            //TODO  see if it works
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(options.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, options);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(Options.fileName);
                }
            }
            catch (Exception e)
            {
                //TODO add some logs
            }
        }
    }
}