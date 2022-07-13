using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SoapService.Models
{
    [DataContract]
    public class Trophy
    {
        [DataMember(Order = 0)]
        public string League { get; set; }

        [DataMember(Order = 1)]
        public string Country { get; set; }

        [DataMember(Order = 2)]
        public string Season { get; set; }

        [DataMember(Order = 3)]
        public string Place { get; set; }

        public Trophy(string league, string country, string season, string place)
        {
            League = league;
            Country = country;
            Season = season;
            Place = place;
        }

        public Trophy()
        {
        }

        public override string ToString() => $"{League}, {Country}, {Season}, {Place}";
    }
}