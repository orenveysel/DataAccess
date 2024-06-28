using _13_GenelTekrar2.OkulEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_GenelTekrar2.OkulEntities.Concrete
{
    public class Ogrenci : BaseEntity
    {
        public string Adsoyad { get; set; }
        public string TcNo { get; set; }
        public string? Gsm { get; set; }
        public string? Email { get; set; }

        public ICollection<Adres> Adresler { get; set; }

        public ICollection<Ders> AldigiDersler { get; set; }
    }
}
