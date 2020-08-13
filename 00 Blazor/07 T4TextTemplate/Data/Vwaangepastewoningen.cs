using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_T4TextTemplate.Data
{
    public class Vwaangepastewoningen
    {
        public string Aanvraagnummer { get; set; }
        public DateTime? Aanvraagdatum { get; set; }
        public string Typeadres { get; set; }
        public string Straat { get; set; }
        public string Postcode1 { get; set; }
        public string Plaats { get; set; }
        public string Geraanpassingen { get; set; }
        public string Product { get; set; }
        public string Bsn { get; set; }
        public string Client { get; set; }
        public int Vwaangepastewoningenid { get; set; }
    }
}
}
