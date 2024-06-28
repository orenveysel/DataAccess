using _13_GenelTekrar2.OkulEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_GenelTekrar2.OkulEntities.Concrete
{
    public class Ders :BaseEntity
    {
        public string DersAdi { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
