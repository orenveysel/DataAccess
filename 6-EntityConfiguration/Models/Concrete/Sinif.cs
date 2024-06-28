using _6_EntityConfiguration.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_EntityConfiguration.Models.Concrete
{
    public class Sinif:BaseEntity
    {
        public string SinifAdi { get; set; }
        public byte Kapasite { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
