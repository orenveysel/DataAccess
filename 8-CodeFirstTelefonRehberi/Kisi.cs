using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CodeFirstTelefonRehberi
{
    public class Kisi
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public ICollection<Telefon> Telefonlar { get; set; } = new List<Telefon>(); 
        public ICollection<Email> Emailler { get; set; } = new List<Email>();
        public ICollection<Adres> Adresler { get; set; } = new List<Adres>();

    }
}
