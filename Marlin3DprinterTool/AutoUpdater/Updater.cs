using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace AutoUpdater
{
    public class Updater
    {
        private string XmlUrl = "http://www.marlin3DprinterTool.se/LatestVersion/LatestVersion.xml";

        public Version CurrentVersion { get; set; }


        public Version NewVersion { get; set; }

        public DialogResult ForceUpdate()
        {




            FrmAutoUpdate autoUpdate = new FrmAutoUpdate
            {
                CurrentVersion = CurrentVersion,
                NewVersion = CurrentVersion,
                XmlUrl = XmlUrl
            };
            return autoUpdate.ShowDialog();


            

        }

        private void MapInfo()
        {
            MapInfo mapInfo = new MapInfo();
            MarkerPoint myLocation = mapInfo.GetMyLocation();
            var xmlMarkers = mapInfo.GetAllExistingMarkers();
            mapInfo.InsertNewMarker(myLocation, xmlMarkers, IsDonator());
            Location = myLocation;



            //if (Location != null
            //    &&
            //    String.Equals(IsDonator().ToString(), true.ToString(), StringComparison.CurrentCultureIgnoreCase)
            //)
            //{
            //    // The user has allready set a maker and donation status is not changed from that point    
            //}
            //else
            //{
            //    MapInfo mapInfo = new MapInfo();
            //    MarkerPoint myLocation = mapInfo.GetMyLocation();
            //    var xmlMarkers = mapInfo.GetAllExistingMarkers();
            //    mapInfo.InsertNewMarker(myLocation, xmlMarkers, IsDonator());
            //    Location = myLocation;
            //}
            
        }

        public DialogResult SearchForUpdate()
        {
            MapInfo();

            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(XmlUrl);

                XmlNode latestVersion = xml.SelectSingleNode("/Marlin3DprinterTool/Version");
                if (latestVersion != null)
                {
                    NewVersion = new Version(latestVersion.InnerText);
                }

                Version currentVersion = System.Reflection.Assembly.GetCallingAssembly().GetName().Version;

                if (currentVersion.CompareTo(NewVersion) < 0)
                {
                    FrmAutoUpdate autoUpdate = new FrmAutoUpdate
                    {
                        CurrentVersion = currentVersion,
                        NewVersion = NewVersion,
                        XmlUrl = XmlUrl
                    };
                    return autoUpdate.ShowDialog();


                }
            }
            catch (Exception)
            {

                return DialogResult.No;
            }
            return  DialogResult.No;
            
        }


        

        public bool IsDonator()
        {
            return (string.IsNullOrEmpty(LicenseKey) == false);

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
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/LicenseKey") ?? (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "LicenseKey");
                xmlNode?.SetAttribute("key", value);
                xml.Save(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
            }
        }

        /// <summary>
        /// Licensekey
        /// </summary>
        public MarkerPoint Location
        {
            get
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                var xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Location");
                if (xmlNode == null) return null;

                MarkerPoint returnMarkerPoint = new MarkerPoint
                {
                    City = xmlNode.GetAttribute("City"),
                    CountryName = xmlNode.GetAttribute("CountryName"),
                    Latitude = xmlNode.GetAttribute("Latitude"),
                    Longitude = xmlNode.GetAttribute("Longitude"),
                    IsDonator = xmlNode.GetAttribute("IsDonator").ToLower() == "true"
                };

                return returnMarkerPoint;

            }
            set
            {
                var xml = new XmlDocument();
                xml.Load(GetConfigurationFile("Marlin3DprinterToolConfiguration.xml"));
                XmlElement xmlNode = (XmlElement)xml.SelectSingleNode("/configuration/Location") ?? (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Location");
                if (xmlNode == null)
                {
                    xmlNode = (XmlElement)CreateMissingXmlNode(xml, xml.DocumentElement, "Location");
                }
                if (value != null)
                {
                    if (string.IsNullOrEmpty(value.City)) xmlNode?.SetAttribute("City", value.City);
                    if (string.IsNullOrEmpty(value.CountryName))xmlNode?.SetAttribute("CountryName", value.CountryName);
                    if (string.IsNullOrEmpty(value.Latitude)) xmlNode?.SetAttribute("Latitude", value.Latitude);
                    if (string.IsNullOrEmpty(value.Latitude)) xmlNode?.SetAttribute("Latitude", value.Latitude);
                    xmlNode?.SetAttribute("IsDonator", value.IsDonator.ToString().ToLower());
                }
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

        private static XmlNode CreateMissingXmlNode(XmlDocument xml, XmlNode parentNode, string tag)
        {
            XmlNode xmlNode = xml.CreateElement(tag);

            parentNode.AppendChild(xmlNode);
            return xmlNode;

        }




    }
}
