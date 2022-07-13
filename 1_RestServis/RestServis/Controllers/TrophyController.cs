using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestServis.Models;
using RestServis.Util;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Commons.Xml.Relaxng;

namespace RestServis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrophyController : ControllerBase
    {
        private string nameSpace = "http://schemas.datacontract.org/2004/07/RestServis.Models";
        private string path = "trophy.xsd";
        private bool valid = true;
        private Trophies Trophies;
        //private Trophies Trophies;


        public TrophyController(Trophies trophies)
        {
            Trophies = trophies;
        }

        public Trophies Get() => Trophies;



        // XSD Validation
        [HttpPost("XSD")]
        public void Post(XmlElement xmlTrophy)
        {
            try
            {
                XmlDocument document = xmlTrophy.OwnerDocument;
                document.AppendChild(xmlTrophy);
                document.Schemas.Add(nameSpace, path);

                ValidationEventHandler handler = new ValidationEventHandler(XmlValid);
                document.Validate(XmlValid);

                if (valid)
                {
                    saveXmlAndAddTrophy(xmlTrophy);
                    HttpContext.Response.StatusCode = StatusCodes.Status202Accepted;
                }
                else
                {
                    Response.StatusCode = StatusCodes.Status206PartialContent;
                }
            }
            catch (Exception)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }


        //RNG Validation
        [HttpPost("RNG")]
        public void XmlAgainstRNG(XmlElement xmlTrophy)
        {
            XmlDocument document = xmlTrophy.OwnerDocument;
            document.AppendChild(xmlTrophy);
            MemoryStream memoryStream = new MemoryStream();
            document.Save(memoryStream);

            memoryStream.Flush();
            memoryStream.Position = 0;

            XmlTextReader xmlStreamReader = new XmlTextReader(memoryStream);
            XmlReader xmlValidRng = new XmlTextReader("trophy.rng");
            using (RelaxngValidatingReader reader = new RelaxngValidatingReader(xmlStreamReader, xmlValidRng))
            {
                try
                {
                    while (!reader.EOF)
                    {
                        reader.Read();
                    }

                    saveXmlAndAddTrophy(xmlTrophy);
                    Response.StatusCode = StatusCodes.Status202Accepted;
                }
                catch (Exception)
                {
                    Response.StatusCode = StatusCodes.Status206PartialContent;
                }
            }
        }

        //Save xml file and adding new Trophy after validating XSD or RNG
        private void saveXmlAndAddTrophy(XmlElement xmlTrophy)
        {  
            string ns = xmlTrophy.OuterXml;
            string strXMLPattern = @"xmlns(:\w+)?=""([^""]+)""|xsi(:\w+)?=""([^""]+)""";
            ns = Regex.Replace(ns, strXMLPattern, "");
            using (StreamWriter writer = new StreamWriter("data.xml"))
            {
                writer.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                writer.Write(ns);
            }

            ////////////////add new trophies to list/////////////////////////////////////
            XmlHandler xmlHandler = new XmlHandler();
            string trophy = xmlHandler.getTrophyXML();

            //parse to XDocument
            XDocument xmlDoc = XDocument.Parse(trophy);
            //Deserialize to model Trophy
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Trophy));
            Trophy addedTrophy = (Trophy)xmlSerializer.Deserialize(xmlDoc.CreateReader());

            Trophies.AllTrophies.Add(addedTrophy);     
        }


        private void XmlValid(object? sender, ValidationEventArgs e)
        {
            valid = false;
        }
    }
}

