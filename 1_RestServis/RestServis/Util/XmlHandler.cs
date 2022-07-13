using System.Xml.Linq;

namespace RestServis.Util
{
    public class XmlHandler
    {
        public string getTrophyXML()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "data.xml");
            return XDocument.Load(path).ToString();
        }
    }
}
