using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MarlinEditor
{
    public static class MarlinDocumentationHarvestClass
    {



        public static string GetMarlinConfigurationDocumentation(string url)
        {

            try
            {
                HttpWebRequest req = (HttpWebRequest) HttpWebRequest.Create(url);
                HttpWebResponse responce = (HttpWebResponse) req.GetResponse();

                StreamReader responceStream = new StreamReader(responce.GetResponseStream());

                string documentation = responceStream.ReadToEnd();
                responceStream.Close();
                responce.Close();
                return documentation;

            }
            catch (Exception)
            {

                return "";
            }
            
        }
    }
}
