using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace ClientApp.Model
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/RestServis.Models")]
    class Trophy
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

        public override string ToString() => $"LEAGUE: {League}, COUNTRY: {Country}, SEASON: {Season}, PLACE: {Place}";
    }
}
