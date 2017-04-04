using System;
using System.IO;
using System.Net;
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

        
    }
}
