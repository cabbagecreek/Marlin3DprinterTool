using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace AutoUpdater
{
    public class MapInfo
    {
        public MarkerPoint GetMyLocation()
        {
            string myIp = null;
            XmlDocument xml = new XmlDocument();

            try
            {
                var url = "http://checkip.dyndns.org";
                WebRequest getMyIprRequest = WebRequest.Create(url);
                WebResponse getMyIpResponse = getMyIprRequest.GetResponse();
                
                    
                StreamReader getMyIpStreamReader = new StreamReader(getMyIpResponse.GetResponseStream());

                xml.LoadXml(getMyIpStreamReader.ReadToEnd().Trim());

                XmlNode xmlNodeIp = xml.SelectSingleNode(@"/html/body");
                if (xmlNodeIp != null)
                {
                    string currentIp = xmlNodeIp.InnerText;
                    string[] splitData = xmlNodeIp.InnerText.Split(':');
                    if (splitData.Length == 2)
                    {
                        myIp = splitData[1].Trim();
                    }

                }
                    
                

                url = $"http://freegeoip.net/xml/{myIp}";
                WebRequest getMyLocationRequest = WebRequest.Create(url);
                WebResponse getMyLocationResponse = getMyLocationRequest.GetResponse();
                StreamReader getMyLocationStreamReader = new StreamReader(getMyLocationResponse.GetResponseStream());

                xml.LoadXml(getMyLocationStreamReader.ReadToEnd().Trim());

                XmlNode xmlNodeLatitude = xml.SelectSingleNode(@"/Response/Latitude");
                XmlNode xmlNodeLongitude = xml.SelectSingleNode(@"/Response/Longitude");
                XmlNode xmlNodeCity = xml.SelectSingleNode(@"/Response/City");
                XmlNode xmlNodeCountryName = xml.SelectSingleNode(@"/Response/CountryName");


                MarkerPoint markerPoint = new MarkerPoint();
                if (xmlNodeLatitude != null)
                {
                    markerPoint.Latitude = xmlNodeLatitude.InnerText;
                }
                if (xmlNodeLongitude != null)
                {
                    markerPoint.Longitude = xmlNodeLongitude.InnerText;
                }
                if (xmlNodeCity != null)
                {
                    markerPoint.City = xmlNodeCity.InnerText;
                }
                if (xmlNodeCountryName != null)
                {
                    markerPoint.CountryName = xmlNodeCountryName.InnerText;
                }
                return markerPoint;

            }
            catch (Exception)
            {
                return null;
            }

        }

        public XmlDocument GetAllExistingMarkers()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.marlin3DprinterTool.se/MapInfo/GetAllExistingMarkers.php");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //string content;
                //using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                //{
                //    content = reader.ReadToEnd();
                //}
                XmlDocument xml = new XmlDocument();

                xml.Load(response.GetResponseStream());
                //MessageBox.Show(xml.OuterXml);
                return xml;



            }
            catch (Exception)
            {
                //MessageBox.Show(except.ToString());
                return null;
            }

        }



        public void InsertNewMarker(MarkerPoint markerPoint, XmlDocument xml, bool isDonator)
        {
            try
            {
                var category = isDonator ? 2 : 1;

                string sql = "INSERT INTO xvom_wpgmza(map_id,address,description,pic,link,icon,lat,lng,anim,title,infoopen,category,approved,retina,type,did,other_data) " +
                             $"VALUES(1,'{markerPoint.City}','','','','','{markerPoint.Latitude}','{markerPoint.Longitude}',0,'',0,'',{category},0,0,'','')";





                string url = @"http://www.marlin3DprinterTool.se/MapInfo/InsertNewMarker.php";

                WebClient client = new WebClient {Encoding = Encoding.UTF8};
                client.UploadString(url, sql);




            }
            catch (Exception e)
            {
                
            }



        }
    }
    public class MarkerPoint
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }

        public bool IsDonator { get; set; }
    }
}
