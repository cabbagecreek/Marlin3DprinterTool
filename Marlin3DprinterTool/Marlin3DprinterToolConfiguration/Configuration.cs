using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace Marlin3DprinterToolConfiguration
{
    public class Configuration
    {
        readonly NumberConversion _numberConversion = new NumberConversion();
        public string CurrentFirmware
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile(GetConfigurationFile("MarlinEditorConfiguration.xml")));
                var xmlNodeFirmware = (XmlElement)xml.SelectSingleNode("/configuration/CurrentFirmware");

                return xmlNodeFirmware?.GetAttribute("directory") ?? "";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("MarlinEditorConfiguration.xml"));
                var xmlNodeFirmware = (XmlElement)xml.SelectSingleNode("/configuration/CurrentFirmware");
                xmlNodeFirmware?.SetAttribute("directory", value); // if (xmlNodeFirmware != null)
                xml.Save(GetConfigurationFile("MarlinEditorConfiguration.xml"));
            }
        }


        public string NewFirmware
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("MarlinEditorConfiguration.xml"));
                var xmlNodeFirmware = (XmlElement)xml.SelectSingleNode("/configuration/NewFirmware");

                return xmlNodeFirmware?.GetAttribute("directory") ?? "";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("MarlinEditorConfiguration.xml"));
                var xmlNodeFirmware = (XmlElement)xml.SelectSingleNode("/configuration/NewFirmware");
                xmlNodeFirmware?.SetAttribute("directory", value); // if (xmlNodeFirmware != null)
                xml.Save(GetConfigurationFile("MarlinEditorConfiguration.xml"));
            }
        }




        /// <summary>
        /// Path where Arduino IDE is located
        /// </summary>
        public string ArduinoIde
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/ArduinoIDE");
                if (xmlNode == null) return "";

                return xmlNode.GetAttribute("directory");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/ArduinoIDE");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "ArduinoIDE");
                }
                xmlNode?.SetAttribute("directory", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }



        /// <summary>
        /// Set the color used for showing 3D model
        /// </summary>
        public string STLcolor
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/STLviewer");
                if (xmlNode == null) return "Blue";
                return xmlNode.GetAttribute("color");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/STLviewer");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "STLviewer");
                }

                xmlNode?.SetAttribute("color", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));

            }

        }

        private static XmlNode CreateMissingXmlNode(XmlDocument xml, XmlNode parentNode, string tag)
        {
            XmlNode xmlNode = xml.CreateElement(tag);

            parentNode.AppendChild(xmlNode);
            return xmlNode;

        }

        






        /// <summary>
        /// Configure the type of Bed
        /// </summary>
        public BedTypeEnum BedType
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/bed");
                if (xmlNode == null) return BedTypeEnum.FourPoint;



                // Enum.Parse(typeof(Colors), colorString);  
                return (BedTypeEnum)Enum.Parse(typeof(BedTypeEnum), xmlNode.GetAttribute("bedtype"));
            }

            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/bed");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "bed");
                }


                if (xmlNode != null) xmlNode.SetAttribute("bedtype", value.ToString());

                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }

        private static string GetConfigurationFile(string filename)
        {
            string programDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            programDataDirectory = Path.Combine(programDataDirectory, "cabbagecreek");
            programDataDirectory = Path.Combine(programDataDirectory, "Marlin3DprinterTool");
            return Path.Combine(programDataDirectory, filename);
        }


        /// <summary>
        /// Define the lower Left Corner
        /// </summary>
        public Position FrontLeftCorner
        {
            get { return GetPosition("FrontLeftCorner"); }
            set { SetPosition(value, "FrontLeftCorner"); }
        }


        /// <summary>
        /// Never clear The ShowCommands window
        /// </summary>
        public static bool NeverClear
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/NeverClear");
                if (xmlNode == null) return false;

                return xmlNode.GetAttribute("value").ToLower() == "true";
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/NeverClear");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "NeverClear");
                }
                xmlNode?.SetAttribute("value", value.ToString()); // boolian.ToString = True/False
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }


        /// <summary>
        /// Type of adjuster for the bed
        /// </summary>
        public string Adjuster
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Adjuster");
                if (xmlNode == null) return "M3";

                return xmlNode.GetAttribute("type");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Adjuster");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Adjuster");
                }
                xmlNode?.SetAttribute("type", value); //(xmlNodeAdjuster != null)
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }

        /// <summary>
        /// Define the max travel for the Z-axis
        /// </summary>
        public int ZmaxTravel
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/ZmaxTravel");
                if (xmlNode == null) return 300;

                return Convert.ToInt16(xmlNode.GetAttribute("zmax"));
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/ZmaxTravel");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "ZmaxTravel");
                }
                xmlNode?.SetAttribute("zmax", value.ToString()); // if (xmlNodeZmax != null) Int = no need for decimal 
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }


        /// <summary>
        /// The latest connected COM-port
        /// </summary>
        public string ComPort
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/comport");
                if (xmlNode == null) return "";

                return xmlNode.GetAttribute("port");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/comport");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "comport");
                }
                xmlNode?.SetAttribute("port", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));

            }
        }

        /// <summary>
        /// Last connected Baudrate
        /// </summary>
        public string Baudrate
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/comport");
                if (xmlNode == null) return "";

                return xmlNode.GetAttribute("baudrate");
            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/baudrate");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "baudrate");
                }
                xmlNode?.SetAttribute("baudrate", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));

            }
        }

        


        /// <summary>
        /// Lower Right Coner
        /// </summary>
        public Position FrontRightCorner
        {
            get { return GetPosition("FrontRightCorner"); }
            set { SetPosition(value, "FrontRightCorner"); }
        }

        /// <summary>
        /// Upper Left Corner
        /// </summary>
        public Position BackLeftCorner
        {
            get { return GetPosition("BackLeftCorner"); }
            set { SetPosition(value, "BackLeftCorner"); }
        }

        /// <summary>
        /// Upper Right Corner
        /// </summary>
        public Position BackRightCorner
        {
            get { return GetPosition("BackRightCorner"); }
            set { SetPosition(value, "BackRightCorner"); }
        }





        /// <summary>
        /// Position where the probe is in a safe position
        /// and its possible to work with the adjusters of the bed
        /// </summary>
        public Position SafeHome
        {
            get { return GetPosition("SafeHome"); }
            set { SetPosition(value, "SafeHome"); }
        }


        /// <summary>
        /// Describe how a probe is engaged with GCODE
        /// </summary>
        public List<string> GcodeAssistZprobeEngage
        {
            get
            {
                var returnList = new List<string>();

                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));

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
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));

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

                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }

        /// <summary>
        /// Describe how a probe is disengaged with GCODE
        /// </summary>
        public List<string> GcodeAssistZprobeRelease
        {
            get
            {
                var returnList = new List<string>();

                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));

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
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));

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

                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }


        /// <summary>
        /// Licensekey
        /// </summary>
        public string LicenseKey
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/LicenseKey");
                if (xmlNode == null) return "";


                return xmlNode.GetAttribute("key");

            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/LicenseKey");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "LicenseKey");
                }
                xmlNode?.SetAttribute("key", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }


        /// <summary>
        /// Extra distance that lifts the Z-Probe during travel
        /// If not entered a value of 50 is default.
        /// </summary>
        public string ZextraDistance
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null) return "50";  // Default is 50

                return xmlNode.GetAttribute("safedistance");
            }

            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Zprobe");
                }
                if (!value.Contains(".")) value = value + ".00";
                xmlNode?.SetAttribute("safedistance", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }


        /// <summary>
        /// Z probe X Offset Left/Right
        /// </summary>
        public string ZprobeXoffset
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null) return "to the left of the nozzle";  // to the left of the nozzle

                return xmlNode.GetAttribute("Xoffset");
            }

            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Zprobe");
                }
                xmlNode?.SetAttribute("Xoffset", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }

        /// <summary>
        /// Z probe Offset in X-axis in mm
        /// </summary>
        public string ZprobeXoffsetValue
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null) return "0";  // Default is 0

                return xmlNode.GetAttribute("X");
            }

            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Zprobe");
                }
                xmlNode?.SetAttribute("X", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }



        /// <summary>
        /// Z probe Offset in Z-axis in mm
        /// </summary>
        public string ZprobeZoffsetValue
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null) return "0";  // Default is 0

                return xmlNode.GetAttribute("Z");
            }

            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Zprobe");
                }
                xmlNode?.SetAttribute("Z", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }


        /// <summary>
        /// Z probe Y Offset Front/Behind
        /// </summary>
        public string ZprobeYoffset
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null) return "behind the nozzle";  // Default is 50

                return xmlNode.GetAttribute("Yoffset");
            }

            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Zprobe");
                }
                xmlNode?.SetAttribute("Yoffset", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }

        /// <summary>
        /// Z-probe  Y-offset in mm
        /// </summary>
        public string ZprobeYoffsetValue
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null) return "10";  // Default is 10

                return xmlNode.GetAttribute("Y");
            }

            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Zprobe");
                }
                xmlNode?.SetAttribute("Y", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }

        public bool BLTouch {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null) return false;  // Default is false

                return xmlNode.GetAttribute("BLTouch") == true.ToString();
            }

            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Zprobe");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Zprobe");
                }
                xmlNode?.SetAttribute("BLTouch", value.ToString());
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        } 


        /// <summary>
        /// Decrypt a string. Usage for license key
        /// </summary>
        /// <param name="cryptoText"></param>
        /// <returns>Decrypted sting or null if nota able to Decrypt</returns>
        public static string Decrypt(string cryptoText)
        {
            //try
            //{
            //    byte[] key = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //    byte[] iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //    SymmetricAlgorithm algorithm = DES.Create();
            //    ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
            //    byte[] inputbuffer = Convert.FromBase64String(text);
            //    byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);


            //    return Encoding.Unicode.GetString(outputBuffer);
            //}
            //catch (Exception)
            //{

            //    return null;
            //}


            string decrypted_text = "";
            try
            {
                byte[] keyDes = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
                byte[] ivDes = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
                SymmetricAlgorithm algorithm = DES.Create();
                ICryptoTransform transform = algorithm.CreateDecryptor(keyDes, ivDes);
                byte[] inputbuffer = Convert.FromBase64String(cryptoText);
                byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);


                decrypted_text = Encoding.Unicode.GetString(outputBuffer);
                //TODO: Update to new licensekey

                // Create a new license key from the old license-key
                byte[] decrypted_bytes = Encoding.UTF8.GetBytes(decrypted_text);
                RijndaelManaged aes = new RijndaelManaged();
                aes.KeySize = 256;
                aes.BlockSize = 256;
                aes.Padding = PaddingMode.Zeros;
                aes.Mode = CipherMode.CBC;

                aes.Key = Encoding.Default.GetBytes("12345678123456781234567812345678");
                aes.GenerateIV();

                string IV = ("-[--IV-[-" + Encoding.Default.GetString(aes.IV));

                ICryptoTransform AESEncrypt = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] buffer = decrypted_bytes;

                string new_license = Convert.ToBase64String(Encoding.Default.GetBytes(Encoding.Default.GetString(AESEncrypt.TransformFinalBlock(buffer, 0, buffer.Length)) + IV));

                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/LicenseKey");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "LicenseKey");
                }
                xmlNode?.SetAttribute("key", new_license);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));



                return decrypted_text;
            }
            catch (Exception)
            {

                
            }


            try
            {
                
                RijndaelManaged aes = new RijndaelManaged();
                aes.KeySize = 256;
                aes.BlockSize = 256;
                aes.Padding = PaddingMode.Zeros;
                aes.Mode = CipherMode.CBC;

                aes.Key = Encoding.Default.GetBytes("12345678123456781234567812345678");

                cryptoText = Encoding.Default.GetString(Convert.FromBase64String(cryptoText));

                string IV = cryptoText;
                IV = IV.Substring(IV.IndexOf("-[--IV-[-", StringComparison.Ordinal) + 9);
                cryptoText = cryptoText.Replace("-[--IV-[-" + IV, "");

                cryptoText = Convert.ToBase64String(Encoding.Default.GetBytes(cryptoText));
                aes.IV = Encoding.Default.GetBytes(IV);

                ICryptoTransform aesDecrypt = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] buffer = Convert.FromBase64String(cryptoText);

                return Encoding.UTF8.GetString(aesDecrypt.TransformFinalBlock(buffer, 0, buffer.Length));

                
            }
            catch (Exception)
            {

                return null;
            }



        }
        



        private Position GetPosition(string tag)
        {
            var xml = new XmlDocument();
            xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            var xmlNodePosition = (XmlElement)xml.SelectSingleNode($"/configuration/{tag}");
            if (xmlNodePosition == null) return null;
            try
            {
                var position = new Position
                {
                    X = _numberConversion.ConvertStringToDecimal(xmlNodePosition.Attributes["x"].Value),
                    Y = _numberConversion.ConvertStringToDecimal(xmlNodePosition.Attributes["y"].Value)
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
            xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            var xmlNodePosition = (XmlElement)xml.SelectSingleNode($"/configuration/{tag}");
            if (xmlNodePosition == null)
            {
                xmlNodePosition = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, tag);
            }

            if (xmlNodePosition != null)
            {
                xmlNodePosition.SetAttribute("x", position.Xstring); // Allways decimal point
                xmlNodePosition.SetAttribute("y", position.Ystring); // Allways decimal point
            }

            xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
        }

        /// <summary>
        /// Get all the MeassuredMeshpoints
        /// </summary>
        /// <returns></returns>
        public List<Position> GetMeshpoints()
        {
            List<Position> meshPoints = new List<Position>();
            var xml = new XmlDocument();
            xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));

            XmlNodeList meshPointXmlNodeList = xml.SelectNodes("/configuration/MeassuredMeshPoints/MeshPoint");
            if (meshPointXmlNodeList == null) return meshPoints;
            foreach (XmlNode meshpoint in meshPointXmlNodeList)
            {
                if (meshpoint.Attributes != null)
                {
                    decimal x = _numberConversion.ConvertStringToDecimal(meshpoint.Attributes["X"].Value);
                    decimal y = _numberConversion.ConvertStringToDecimal(meshpoint.Attributes["Y"].Value);
                    decimal z = _numberConversion.ConvertStringToDecimal(meshpoint.Attributes["Z"].Value);

                    meshPoints.Add(new Position {X = x, Y = y, Z = z});
                }
            }

            return meshPoints;
        }






    }


    /// <summary>
    /// The types for different Bedtypes
    /// </summary>
    public enum BedTypeEnum
    {
        /// <summary>
        /// None = Not configured (yet)
        /// </summary>
        None = 0,
        /// <summary>
        /// One adjuster in each corner
        /// </summary>
        FourPoint = 1,
        /// <summary>
        /// 3 Ponts adjuster with the single adjuster on the Left side
        /// </summary>
        ThreePointLeftSingle = 2,
        /// <summary>
        /// 3 Ponts adjuster with the single adjuster on the Front
        /// </summary>
        ThreePointFrontSingle = 3,
        /// <summary>
        /// 3 Ponts adjuster with the single adjuster on the Right side
        /// </summary>
        ThreePointRightSingle = 4
    }


    /// <summary>
    /// Position with X/y/Z values
    /// Conversion to string and tu Double
    /// Uses Decimal.point in all strings
    /// </summary>
    public class Position
    {
        NumberConversion _numberConversion = new NumberConversion();
        private decimal _x;
        private decimal _y;
        private decimal _z;


        /// <summary>
        /// Set/get the X value as double
        /// </summary>
        public decimal X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Set/get the Y value as double
        /// </summary>
        public decimal Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Set/get the Z value as double
        /// </summary>
        public decimal Z
        {
            get { return _z; }
            set { _z = value; }
        }

        /// <summary>
        ///  Set and Get X position as string
        /// </summary>
        public string Xstring
        {
            get { return _numberConversion.ConvertDecimalToString(_x); } // Always decimalpoint
            set { _x = _numberConversion.ConvertStringToDecimal(value); }
        }

        /// <summary>
        ///  Set and Get Y position as string
        /// </summary>
        public string Ystring
        {
            get { return _numberConversion.ConvertDecimalToString(_y); } // Always decimalpoint
            set { _y = _numberConversion.ConvertStringToDecimal(value); }
        }

        /// <summary>
        ///  Set and Get Z position as string
        /// </summary>
        public string Zstring
        {
            get { return _numberConversion.ConvertDecimalToString(_z); } // Always decimalpoint
            set { _z = _numberConversion.ConvertStringToDecimal(value); }
        }
    }

    #region

    public class NumberConversion
    {
        /// <summary>
        /// Convert a string to Decimal
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public decimal ConvertStringToDecimal(string text)
        {


            string incommingText = text;



            int findDot = text.IndexOf('.');
            int findComma = text.IndexOf(',');

            // Both dot and comma
            if ((findDot != -1) && findComma != -1)
            {
                // Dot is 1000 divider
                if (findDot < findComma)
                {
                    incommingText = incommingText.Replace(".", "");
                    incommingText = incommingText.Replace(",", ".");
                }

                // Comma is 1000 divider
                if (findDot > findComma)
                {
                    incommingText = incommingText.Replace(",", "");
                }

            }

            if (findComma != -1)
            {
                incommingText = incommingText.Replace(",", ".");
            }


            decimal tal = Convert.ToDecimal(incommingText, CultureInfo.InvariantCulture);

            return tal;
        }

        public string ConvertDecimalToString(decimal numerDecimal)
        {


            string numericString = numerDecimal.ToString(CultureInfo.InvariantCulture);

            numericString = numericString.Replace(",", ".");
            return numericString;


        }
    }

    #endregion

}
