using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radioo.Models
{
    public class RadioStation
    {
        public string StationUuid { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string UrlResolved { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Tags { get; set; }
        public int Votes { get; set; }
        public string Codec { get; set; }
        public int Bitrate { get; set; }
    }
}
