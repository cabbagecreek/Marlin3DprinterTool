using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AutoUpdater
{
    public class Updater
    {


        private string XmlUrl = "http://www.Marlin3DprinterTool.se/LatestVersion/LatestVersion.xml";

        private Version _newVersion;


        public DialogResult SearchForUpdate()
        {
            
            XmlDocument xml = new XmlDocument();
            xml.Load(XmlUrl);

            XmlNode latestVersion = xml.SelectSingleNode("/Marlin3DprinterTool/Version");
            if (latestVersion != null)
            {
                _newVersion = new Version(latestVersion.InnerText);
            }

            Version currentVersion = System.Reflection.Assembly.GetCallingAssembly().GetName().Version;

            if (currentVersion.CompareTo(_newVersion) < 0)
            {
                FrmAutoUpdate autoUpdate = new FrmAutoUpdate();
                autoUpdate.CurrentVersion = currentVersion;
                autoUpdate.NewVersion = _newVersion;
                autoUpdate.XmlUrl = XmlUrl;
                return autoUpdate.ShowDialog();
                

            }
            return  DialogResult.No;
            
        }


        public string GetLocation()
        {
            try
            {
                WebClient client = new WebClient();
                string url = @"http://Marlin3DprinterTool.se/MapInfo/GetUserLocation.php";
                byte[] locationBytes = client.DownloadData(url);
                return Encoding.UTF8.GetString(locationBytes);

            }
            catch (Exception)
            {
                return null;

            }
        }

        public bool IsDonator()
        {
            return (string.IsNullOrEmpty(LicenseKey) == false);

        }

        public void UpdateMapMarkers()
        {
            //// Get the object used to communicate with the server.  
            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://marlin3dprintertool.se/wp-content/uploads/wp-google-maps/1markers.xml");
            //request.Method = WebRequestMethods.Ftp.DownloadFile;

            //// This example assumes the FTP site uses anonymous logon.  
            //request.Credentials = new NetworkCredential("137900_master", "1qaz2wsx3edc!");

            //FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            //Stream responseStream = response.GetResponseStream();
           

            //XmlDocument xml = new XmlDocument();
            //xml.Load(responseStream);
            //response.Close();
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
