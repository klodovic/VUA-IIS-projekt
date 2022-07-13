using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Model
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/RestServis.Models")]
    internal class Trophies
    {
        [JsonProperty("response")]
        public List<Trophy> AllTrophies { get; set; }

        public Trophies(List<Trophy> allTrophies)
        {
            AllTrophies = allTrophies;
        }
    }
}
