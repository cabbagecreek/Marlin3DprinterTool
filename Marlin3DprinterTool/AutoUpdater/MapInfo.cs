using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
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
                StreamReader getMyLocationStreamReader = new StreamReader(getMyLocationResponse.GetResponseStream() ?? throw new InvalidOperationException());

                xml.LoadXml(getMyLocationStreamReader.ReadToEnd().Trim());

                XmlNode xmlNodeLatitude = xml.SelectSingleNode(@"/Response/Latitude");
                XmlNode xmlNodeLongitude = xml.SelectSingleNode(@"/Response/Longitude");
                




                MarkerPoint markerPoint = new MarkerPoint();

                Updater updater = new Updater();
                
                bool isDonator = updater.IsDonator();

                if (xmlNodeLatitude != null && xmlNodeLongitude != null)
                {
                    markerPoint = 
                         GetMyLocation(xmlNodeLatitude.InnerText, xmlNodeLongitude.InnerText, isDonator);
                    return markerPoint;
                }
                
                return null;

            }
            catch (Exception)
            {
                return null;
            }

        }

        private MarkerPoint GetMyLocation(string lat, string lng, bool isDonator)
        {
            string coordinate = $"{lat},{lng}";
            XmlDocument xDoc = new XmlDocument();


            try
            {
                xDoc.Load("https://maps.googleapis.com/maps/api/geocode/xml?latlng=" + coordinate + "&location_type=ROOFTOP&result_type=street_address&key=AIzaSyDfNL99sHWyLZu_Fpwu4-erhQgymdH5EFI");


                XmlNodeList xNodelst = xDoc.GetElementsByTagName("result");
                XmlNode xNode = xNodelst.Item(0);

                if (xNode != null)
                {
                    MarkerPoint marker = new MarkerPoint();
                    marker.City = GetCity(xNode);
                    marker.CountryName = GetCountry(xNode);
                    marker.Latitude = lat;
                    marker.Longitude = lng;
                    marker.IsDonator = isDonator;
                    return marker;
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(lat + " " + lng + ":" + e.Message);

                Thread.Sleep(1000);
            }





            return null;
        }


        private string GetCity(XmlNode xNode)
        {
            string city = null;
            XmlNode roadNode = xNode.SelectSingleNode("address_component[2]/long_name");
            if (roadNode != null)
            {
                city += roadNode.InnerText + " ";
            }

            XmlNode townNode = xNode.SelectSingleNode("address_component[3]/long_name");
            if (townNode != null)
            {
                city += townNode.InnerText + " ";
            }

            XmlNode areaNode = xNode.SelectSingleNode("address_component[4]/long_name");
            if (areaNode != null)
            {
                city += areaNode.InnerText + " ";
            }

            XmlNode countryNode = xNode.SelectSingleNode("address_component[6]/long_name");
            if (countryNode != null)
            {
                city += countryNode.InnerText + " ";
            }

            return city;

        }

        private string GetCountry(XmlNode xNode)
        {
            string country = null;


            XmlNode countryNode = xNode.SelectSingleNode("address_component[6]/long_name");
            if (countryNode != null)
            {
                country += countryNode.InnerText + " ";
            }

            return country;

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
                string category = isDonator ? "2" : "1";
                                
                                          
                string sql = "INSERT INTO xvom_wpgmza(map_id,address,description,pic,link,icon,lat,lng,anim,title,infoopen,category,approved,retina,type,did,other_data) " +
                             $"VALUES(1,'{markerPoint.City}','','','','','{markerPoint.Latitude}','{markerPoint.Longitude}',0,'',0,{category},1,0,'','','')";





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
