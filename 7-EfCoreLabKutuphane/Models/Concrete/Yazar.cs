using _7_EfCoreLabKutuphane.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _7_EfCoreLabKutuphane.Models.Concrete
{
    public class Yazar : BaseEntity
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public bool Cinsiyet { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }

        public ICollection<Kitap> Kitaplar { get; set; }

    }
}
