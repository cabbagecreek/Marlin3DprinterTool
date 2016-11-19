using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace MarlinComunicationHelper
{
    public class Configuration
    {


        public string STLcolor
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/STLviewer");
                if (xmlNode == null) return "Blue";
                return xmlNode.GetAttribute("color");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/STLviewer");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement) CreateMissingXmlNode(xml, "STLviewer");
                }

                xmlNode?.SetAttribute("color", value);
                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));

            }
            
        }

        private static XmlNode CreateMissingXmlNode(XmlDocument xml,string tag)
        {
            XmlNode xmlNode = xml.CreateElement(tag);
            XmlNode configurationXmlNode = xml.DocumentElement;
            if (configurationXmlNode != null)
            {
                configurationXmlNode.AppendChild(xmlNode);
                xmlNode = (XmlElement)xml.SelectSingleNode($"/configuration/{tag}");
                return xmlNode;
            }
            return null;
        }

        public string BedType
        {
            get 
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile( GetConfigurationFile( "Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/bed");
                if (xmlNode == null) return "4point";

                return xmlNode.GetAttribute("bedtype");
            }

            set 
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/bed");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement) CreateMissingXmlNode(xml, "bed");
                }
                // 4point, 3pointLeft, 3pointRight
                xmlNode?.SetAttribute("bedtype", value);
                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
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
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/NeverClear");
                if (xmlNode == null) return false;

                return xmlNode.GetAttribute("value").ToLower() == "true";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/NeverClear");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, "NeverClear");
                }
                xmlNode?.SetAttribute("value", value.ToString()); // boolian.ToString = True/False
                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
            }
        }


        public string Adjuster
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/Adjuster");
                if (xmlNode == null) return "M3";

                return xmlNode.GetAttribute("type");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/Adjuster");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, "Adjuster");
                }
                xmlNode?.SetAttribute("type", value); //(xmlNodeAdjuster != null)
                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
            }
        }


        public int ZmaxTravel
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/ZmaxTravel");
                if (xmlNode == null) return 300;

                return Convert.ToInt16(xmlNode.GetAttribute("zmax"));
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/ZmaxTravel");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, "ZmaxTravel");
                }
                xmlNode?.SetAttribute("zmax", value.ToString()); // if (xmlNodeZmax != null) Int = no need for decimal 
                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
            }
        }

       

        public string ComPort {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/comport");
                if (xmlNode == null) return "";

                return xmlNode.GetAttribute("port");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/comport");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, "comport");
                }
                xmlNode?.SetAttribute("port", value);
                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));

            }
        }

        public string Baudrate
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/comport");
                if (xmlNode == null) return "";

                return xmlNode.GetAttribute("baudrate");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/baudrate");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, "baudrate");
                }
                xmlNode?.SetAttribute("baudrate", value);
                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));

            }
        }

        public string ArduinoIde
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/ArduinoIDE");
                if (xmlNode == null) return "";

                return xmlNode.GetAttribute("directory");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement) xml.SelectSingleNode("/configuration/ArduinoIDE");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, "ArduinoIDE");
                }
                xmlNode?.SetAttribute("directory", value);
                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
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
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));

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
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));

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
                    newRow.SetAttribute("order", order.ToString()); // Int = no need for decimal
                    newRow.InnerXml = gcode;
                    gcodeAssistZprobeEngare?.AppendChild(newRow);
                }

                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
            }
        }

        public List<string> GcodeAssistZprobeRelease
        {
            get
            {
                var returnList = new List<string>();

                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));

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
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));

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
                    newRow.SetAttribute("order", order.ToString()); // Int = no need for decimal
                    newRow.InnerXml = gcode;
                    gcodeAssistZprobeRelease?.AppendChild(newRow);
                }

                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
            }
        }

        public string LicenseKey
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/LicenseKey");
                if (xmlNode == null) return "";


                return xmlNode.GetAttribute("key");
                
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/LicenseKey");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, "LicenseKey");
                }
                xmlNode?.SetAttribute("key", value);
                xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
            }
        }

        public static string Decrypt(string text)
        {
            try
            {
                byte[] key = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
                byte[] iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
                SymmetricAlgorithm algorithm = DES.Create();
                ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
                byte[] inputbuffer = Convert.FromBase64String(text);
                byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
                return Encoding.Unicode.GetString(outputBuffer);
            }
            catch (Exception)
            {

                return null;
            }
            
        }



        private Position GetPosition(string tag)
        {
            var xml = new XmlDocument();
            xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
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
            xml.Load(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
            var xmlNodePosition = (XmlElement) xml.SelectSingleNode($"/configuration/{tag}");
            if (xmlNodePosition == null)
            {
                xmlNodePosition = (XmlElement)CreateMissingXmlNode(xml, tag);
            }

            if (xmlNodePosition != null)
            {
                xmlNodePosition.SetAttribute("x", position.X.ToString(CultureInfo.InvariantCulture).Replace(',','.') ); // Allways decimal point
                xmlNodePosition.SetAttribute("y", position.Y.ToString(CultureInfo.InvariantCulture).Replace(',', '.')); // Allways decimal point
            }

            xml.Save(GetConfigurationFile(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml")));
        }
    }

    public class Position
    {
        
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}