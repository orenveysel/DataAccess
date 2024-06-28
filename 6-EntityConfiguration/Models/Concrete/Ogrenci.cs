using _6_EntityConfiguration.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_EntityConfiguration.Models.Concrete
{
    public class Ogrenci:BaseEntity
    {
        public string AdSoyad { get; set; }
        public bool Cinsiyet { get; set; }

        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
    }
}
