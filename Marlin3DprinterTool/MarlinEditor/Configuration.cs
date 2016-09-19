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
                xml.Load("MarlinEditorConfiguration.xml");
                var xmlNodeFirmware = (XmlElement) xml.SelectSingleNode("/configuration/CurrentFirmware");

                return xmlNodeFirmware?.GetAttribute("directory") ?? "";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load("MarlinEditorConfiguration.xml");
                var xmlNodeFirmware = (XmlElement) xml.SelectSingleNode("/configuration/CurrentFirmware");
                xmlNodeFirmware?.SetAttribute("directory", value); // if (xmlNodeFirmware != null)
                xml.Save("MarlinEditorConfiguration.xml");
            }
        }


        public string NewFirmware
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load("MarlinEditorConfiguration.xml");
                var xmlNodeFirmware = (XmlElement)xml.SelectSingleNode("/configuration/NewFirmware");

                return xmlNodeFirmware?.GetAttribute("directory") ?? "";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load("MarlinEditorConfiguration.xml");
                var xmlNodeFirmware = (XmlElement)xml.SelectSingleNode("/configuration/NewFirmware");
                xmlNodeFirmware?.SetAttribute("directory", value); // if (xmlNodeFirmware != null)
                xml.Save("MarlinEditorConfiguration.xml");
            }
        }



        public string ArduinoIde
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load("MarlinEditorConfiguration.xml");
                var xmlNodeArduinoIde = (XmlElement) xml.SelectSingleNode("/configuration/ArduinoIDE");
                if (xmlNodeArduinoIde == null) return "";

                return xmlNodeArduinoIde.GetAttribute("directory");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load("MarlinEditorConfiguration.xml");
                var xmlNodeArduinoIde = (XmlElement) xml.SelectSingleNode("/configuration/ArduinoIDE");
                xmlNodeArduinoIde?.SetAttribute("directory", value);
                xml.Save("MarlinEditorConfiguration.xml");
            }
        }

    }

    public class Position
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
