using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SoapService.Models
{
    [DataContract]
    public class Trophies
    {
        [JsonProperty("response")]
        public List<Trophy> AllTrophies { get; set; }
        public Trophies(){}

        public Trophies(List<Trophy> allTrophies)
        {
            AllTrophies = allTrophies;
        }
    }
}