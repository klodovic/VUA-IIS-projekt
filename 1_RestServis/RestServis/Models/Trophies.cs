using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RestServis.Models
{
    [DataContract]  
    public class Trophies
    {
        [JsonProperty("response")]
        public List<Trophy> AllTrophies { get; set; }
        public Trophies(){}

        public Trophies (List<Trophy> allTrophies)
        {
            AllTrophies = allTrophies;
        }
    }
}
