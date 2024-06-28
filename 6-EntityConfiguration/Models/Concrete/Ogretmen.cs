using _6_EntityConfiguration.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_EntityConfiguration.Models.Concrete
{
    public class Ogretmen:BaseEntity
    {
        public string AdSoyad { get; set; }
        public bool Cinsiyet { get; set; }

        public int BransId { get; set; }
        public Brans Brans { get; set; }
    }
}
