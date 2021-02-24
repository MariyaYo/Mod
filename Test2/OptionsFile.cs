using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Test2
{

    internal class Options
    {
        [XmlElement("enableTwitchVoting")]
        public string EnableTwitchVoting;
        [XmlElement("twitchChannelName")]
        public string TwitchChannelName;
        [XmlElement("twitchUserName")]
        public string TwitchUserName;
        [XmlElement("oAuth")]
        public string OAuth;
    }



    internal class OptionsFile
	{
		private string fileName;
        private Options options;


		public OptionsFile(string fileName)
		{
			this.fileName = fileName;
		}

        public void ReadFile()
        {
            //TODO  see if it works

            // Create an instance of the XmlSerializer.
            XmlSerializer serializer = new XmlSerializer(typeof(Options));

            // Declare an object variable of the type to be deserialized.
            using (Stream reader = new FileStream(fileName + ".xml", FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                this.options = (Options)serializer.Deserialize(reader);
            }

        }


        public void WriteFile()
        {
            //TODO  see if it works

            XmlSerializer serilizer = new XmlSerializer(this.options.GetType());
            serilizer.Serialize(Console.Out, this.options);
        }
    }
}