using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace RestServis.Models
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

        public override string ToString() => $"LEAGUE: {League}, COUNTRY: {Country}, SEASON: {Season}, PLACE: {Place}";
    }
}