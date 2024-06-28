using _7_EfCoreLabKutuphane.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EfCoreLabKutuphane.Models.Concrete
{
    public class Raf:BaseEntity
    {
        public string RafAdi { get; set; }
        public string RafKodu { get; set; }
        public short En { get; set; }
        public short Boy { get; set; }

        public ICollection<Kitap> Kitaplar { get; set; }

    }
}
