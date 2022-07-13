using Newtonsoft.Json;
using SoapService.Models;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Services;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;


namespace SoapService
{
    /// <summary>
    /// Summary description for TrophySearchService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TrophySearchService : System.Web.Services.WebService
    {
        private Trophies trophies;
        private Trophy t;
        private List<Trophy> returnedTrophies = new List<Trophy>();
        string rawData;
        string dataPath = @"C:\Users\Next Design\Desktop\IIS_Projekt\SoapServis\SoapService\SoapService\data.xml";
        string searchedParams;

        [WebMethod]
        public List<Trophy> SearchTrophies(string key, string value)
        {
            //Retrieve data from API
            using(var webClient = new WebClient())
            {
                webClient.Headers.Add("X-RapidAPI-Key", "9ebb09ff61msh1860d6141d0d303p102320jsn0a33561d5907");
                webClient.Headers.Add("X-RapidAPI-Host", "api-football-beta.p.rapidapi.com");
                rawData = webClient.DownloadString("https://api-football-beta.p.rapidapi.com/trophies?player=276");
                trophies = JsonConvert.DeserializeObject<Trophies>(rawData);
            }

            //Save XML data to file
            var ser = new XmlSerializer(typeof(Trophies));
            TextWriter writer = new StreamWriter(dataPath);
            ser.Serialize(writer, trophies);
            writer.Close();

            //Load XML data for search
            XDocument doc = XDocument.Load(dataPath);
            searchedParams = "/Trophies/AllTrophies/Trophy[" + key + "=" + "'" + value + "']";
            var result = doc.XPathSelectElements(searchedParams);

            //Converting XElement to Trophy and adding to list
            foreach (var item in result)
            {
                StringReader reader = new StringReader(item.ToString());
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Trophy));
                t = (Trophy)xmlSerializer.Deserialize(reader);
                returnedTrophies.Add(t);
            }

            return returnedTrophies;
        }
    }
}
