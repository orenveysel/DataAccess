using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Code_First.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        public string  AdSoyad { get; set; }
        public string Adres { get; set; }

        public ICollection<Siparis> Siparisler { get; set; }
    }
}
