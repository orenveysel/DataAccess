using _13_GenelTekrar2.OkulEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_GenelTekrar2.OkulEntities.Concrete
{
    public class Adres:BaseEntity
    {

        public string Ulke { get; set; }
        public string Sehir { get; set; }

        public string Ilce { get; set; }
        public string? CaddeSokak { get; set; }

        public string? KapiNo { get; set; }
        public string? PostaKod { get; set; }

        public string OgrenciId { get; set; }

        public Ogrenci Ogrenci { get; set; } // Navigation Property
    }
}
