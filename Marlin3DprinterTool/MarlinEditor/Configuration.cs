using System;
using System.IO;
using System.Xml;

namespace MarlinEditor
{
    public class Configuration
    {



        public string CurrentFirmware
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( GetConfigurationFile( "MarlinEditorConfiguration.xml" ) ));
                var xmlNodeFirmware = (XmlElement) xml.SelectSingleNode("/configuration/CurrentFirmware");

                return xmlNodeFirmware?.GetAttribute("directory") ?? "";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "MarlinEditorConfiguration.xml" ));
                var xmlNodeFirmware = (XmlElement) xml.SelectSingleNode("/configuration/CurrentFirmware");
                xmlNodeFirmware?.SetAttribute("directory", value); // if (xmlNodeFirmware != null)
                xml.Save(GetConfigurationFile( "MarlinEditorConfiguration.xml" ));
            }
        }


        public string NewFirmware
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "MarlinEditorConfiguration.xml" ));
                var xmlNodeFirmware = (XmlElement)xml.SelectSingleNode("/configuration/NewFirmware");

                return xmlNodeFirmware?.GetAttribute("directory") ?? "";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "MarlinEditorConfiguration.xml" ));
                var xmlNodeFirmware = (XmlElement)xml.SelectSingleNode("/configuration/NewFirmware");
                xmlNodeFirmware?.SetAttribute("directory", value); // if (xmlNodeFirmware != null)
                xml.Save(GetConfigurationFile( "MarlinEditorConfiguration.xml" ));
            }
        }



        public string ArduinoIde
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "MarlinEditorConfiguration.xml" ));
                var xmlNodeArduinoIde = (XmlElement) xml.SelectSingleNode("/configuration/ArduinoIDE");
                if (xmlNodeArduinoIde == null) return "";

                return xmlNodeArduinoIde.GetAttribute("directory");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "MarlinEditorConfiguration.xml" ));
                var xmlNodeArduinoIde = (XmlElement) xml.SelectSingleNode("/configuration/ArduinoIDE");
                xmlNodeArduinoIde?.SetAttribute("directory", value);
                xml.Save(GetConfigurationFile( "MarlinEditorConfiguration.xml" ));
            }
        }

        private static string GetConfigurationFile(string filename)
        {
            string programDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            return Path.Combine(programDataDirectory, filename);
        }

    }

   
}
