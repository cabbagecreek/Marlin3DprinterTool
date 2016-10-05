using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace MarlinComunicationHelper
{
    public class Configuration
    {



        public string BedType
        {
            get 
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml")));
                var xmlNodeBed = (XmlElement) xml.SelectSingleNode("/configuration/bed");
                if (xmlNodeBed == null) return "4point";

                return xmlNodeBed.GetAttribute("bedtype");
            }

            set 
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeBed = (XmlElement) xml.SelectSingleNode("/configuration/bed");
                // 4point, 3pointLeft, 3pointRight
                xmlNodeBed?.SetAttribute("bedtype", value);
                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            }
         }

        private static string GetConfigurationFile(string filename )
        {
            string programDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            programDataDirectory = Path.Combine(programDataDirectory, "cabbagecreek");
            programDataDirectory = Path.Combine(programDataDirectory, "Marlin3DprinterTool");
            return Path.Combine(programDataDirectory, filename);
        }

        public Position LowerLeftCorner
        {
            get { return GetPosition("LowerLeftCorner"); }
            set { SetPosition(value, "LowerLeftCorner"); }
        }


        public static bool NeverClear
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeNeverClear = (XmlElement) xml.SelectSingleNode("/configuration/NeverClear");
                if (xmlNodeNeverClear == null) return false;

                return xmlNodeNeverClear.GetAttribute("value") == "true";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeNeverClear = (XmlElement) xml.SelectSingleNode("/configuration/NeverClear");
                xmlNodeNeverClear?.SetAttribute("value", value.ToString());
                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            }
        }


        public string Adjuster
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeAdjuster = (XmlElement) xml.SelectSingleNode("/configuration/Adjuster");
                if (xmlNodeAdjuster == null) return "M3";

                return xmlNodeAdjuster.GetAttribute("type");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeAdjuster = (XmlElement) xml.SelectSingleNode("/configuration/Adjuster");
                xmlNodeAdjuster?.SetAttribute("type", value); //(xmlNodeAdjuster != null)
                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            }
        }


        public int ZmaxTravel
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeZmax = (XmlElement) xml.SelectSingleNode("/configuration/ZmaxTravel");
                if (xmlNodeZmax == null) return 300;

                return Convert.ToInt16(xmlNodeZmax.GetAttribute("zmax"));
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeZmax = (XmlElement) xml.SelectSingleNode("/configuration/ZmaxTravel");
                xmlNodeZmax?.SetAttribute("zmax", value.ToString()); // if (xmlNodeZmax != null)
                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            }
        }

        public string FirmwareLocation
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeFirmware = (XmlElement) xml.SelectSingleNode("/configuration/Firmware");

                return xmlNodeFirmware?.GetAttribute("directory") ?? "";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeFirmware = (XmlElement) xml.SelectSingleNode("/configuration/Firmware");
                xmlNodeFirmware?.SetAttribute("directory", value); // if (xmlNodeFirmware != null)
                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            }
        }

        public string NewFirmwareLocation
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeFirmware = (XmlElement) xml.SelectSingleNode("/configuration/NewFirmware");

                return xmlNodeFirmware?.GetAttribute("directory") ?? "";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeFirmware = (XmlElement) xml.SelectSingleNode("/configuration/NewFirmware");
                xmlNodeFirmware?.SetAttribute("directory", value); // if (xmlNodeFirmware != null)
                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            }
        }

        public string ComPort {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeArduinoIde = (XmlElement)xml.SelectSingleNode("/configuration/comport");
                if (xmlNodeArduinoIde == null) return "";

                return xmlNodeArduinoIde.GetAttribute("port");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeArduinoIde = (XmlElement)xml.SelectSingleNode("/configuration/comport");
                xmlNodeArduinoIde?.SetAttribute("port", value);
                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));

            }
        }

        public string Baudrate
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeArduinoIde = (XmlElement)xml.SelectSingleNode("/configuration/comport");
                if (xmlNodeArduinoIde == null) return "";

                return xmlNodeArduinoIde.GetAttribute("baudrate");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeArduinoIde = (XmlElement)xml.SelectSingleNode("/configuration/baudrate");
                xmlNodeArduinoIde?.SetAttribute("baudrate", value);
                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));

            }
        }

        public string ArduinoIde
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeArduinoIde = (XmlElement) xml.SelectSingleNode("/configuration/ArduinoIDE");
                if (xmlNodeArduinoIde == null) return "";

                return xmlNodeArduinoIde.GetAttribute("directory");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
                var xmlNodeArduinoIde = (XmlElement) xml.SelectSingleNode("/configuration/ArduinoIDE");
                xmlNodeArduinoIde?.SetAttribute("directory", value);
                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            }
        }


        public Position LowerRightCorner
        {
            get { return GetPosition("LowerRightCorner"); }
            set { SetPosition(value, "LowerRightCorner"); }
        }

        public Position UpperLeftCorner
        {
            get { return GetPosition("UpperLeftCorner"); }
            set { SetPosition(value, "UpperLeftCorner"); }
        }

        public Position UpperRightCorner
        {
            get { return GetPosition("UpperRightCorner"); }
            set { SetPosition(value, "UpperRightCorner"); }
        }

        public Position LowerLeftAdjuster
        {
            get { return GetPosition("LowerLeftAdjuster"); }
            set { SetPosition(value, "LowerLeftAdjuster"); }
        }

        public Position LowerRightAdjuster
        {
            get { return GetPosition("LowerRightAdjuster"); }
            set { SetPosition(value, "LowerRightAdjuster"); }
        }

        public Position UpperLeftAdjuster
        {
            get { return GetPosition("UpperLeftAdjuster"); }
            set { SetPosition(value, "UpperLeftAdjuster"); }
        }

        public Position UpperRightAdjuster
        {
            get { return GetPosition("UpperRightAdjuster"); }
            set { SetPosition(value, "UpperRightAdjuster"); }
        }

        public Position SafeHome
        {
            get { return GetPosition("SafeHome"); }
            set { SetPosition(value, "SafeHome"); }
        }

        public List<string> GcodeAssistZprobeEngage
        {
            get
            {
                var returnList = new List<string>();

                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));

                var nav = xml.CreateNavigator();

                var exp = nav.Compile(@"/configuration/GcodeAssistZprobeEngage/Row");

                exp.AddSort("@order", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);

                foreach (XPathNavigator gcode in nav.Select(exp))
                {
                    returnList.Add(gcode.InnerXml);
                }

                return returnList;
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));

                var gcodeAssistZprobeEngare = xml.SelectSingleNode("/configuration/GcodeAssistZprobeEngage");

                var gcodeAssistZprobeEngageChilds = xml.SelectNodes("/configuration/GcodeAssistZprobeEngage/Row");

                if (gcodeAssistZprobeEngageChilds != null)
                {
                    foreach (XmlNode gcode in gcodeAssistZprobeEngageChilds)
                    {
                        gcode.ParentNode?.RemoveChild(gcode);
                    }
                }

                for (var order = 0; order < value.Count; order++)
                {
                    var gcode = value[order];
                    var newRow = xml.CreateElement("Row");
                    newRow.SetAttribute("order", order.ToString());
                    newRow.InnerXml = gcode;
                    gcodeAssistZprobeEngare?.AppendChild(newRow);
                }

                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            }
        }

        public List<string> GcodeAssistZprobeRelease
        {
            get
            {
                var returnList = new List<string>();

                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));

                var nav = xml.CreateNavigator();

                var exp = nav.Compile(@"/configuration/GcodeAssistZprobeRelease/Row");

                exp.AddSort("@order", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);

                foreach (XPathNavigator gcode in nav.Select(exp))
                {
                    returnList.Add(gcode.InnerXml);
                }

                return returnList;
            }
            set
            {
                //List<string> returnList = new List<string>();

                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));

                var gcodeAssistZprobeRelease = xml.SelectSingleNode("/configuration/GcodeAssistZprobeRelease");

                var gcodeAssistZprobeReleaseChilds = xml.SelectNodes("/configuration/GcodeAssistZprobeRelease/Row");

                if (gcodeAssistZprobeReleaseChilds != null)
                {
                    foreach (XmlNode gcode in gcodeAssistZprobeReleaseChilds)
                    {
                        gcode.ParentNode?.RemoveChild(gcode);
                    }
                }

                for (var order = 0; order < value.Count; order++)
                {
                    var gcode = value[order];
                    var newRow = xml.CreateElement("Row");
                    newRow.SetAttribute("order", order.ToString());
                    newRow.InnerXml = gcode;
                    gcodeAssistZprobeRelease?.AppendChild(newRow);
                }

                xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            }
        }

       

        private Position GetPosition(string tag)
        {
            var xml = new XmlDocument();
            xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            var xmlNodePosition = (XmlElement) xml.SelectSingleNode($"/configuration/{tag}");
            if (xmlNodePosition == null) return null;
            try
            {
                var position = new Position
                {
                    X =
                        Convert.ToDouble(xmlNodePosition.Attributes["x"].Value,
                            CultureInfo.CreateSpecificCulture("en-GB")),
                    Y =
                        Convert.ToDouble(xmlNodePosition.Attributes["y"].Value,
                            CultureInfo.CreateSpecificCulture("en-GB"))
                };
                return position;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void SetPosition(Position position, string tag)
        {
            var xml = new XmlDocument();
            xml.Load(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
            var xmlNodePosition = (XmlElement) xml.SelectSingleNode($"/configuration/{tag}");
            if (xmlNodePosition != null)
            {
                xmlNodePosition.SetAttribute("x", position.X.ToString(CultureInfo.CreateSpecificCulture("en-GB")));
                xmlNodePosition.SetAttribute("y", position.Y.ToString(CultureInfo.CreateSpecificCulture("en-GB")));
            }

            xml.Save(GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml"));
        }
    }

    public class Position
    {
        
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}