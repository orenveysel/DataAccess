using _7_EfCoreLabKutuphane.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EfCoreLabKutuphane.Models.Concrete
{
    public class OduncKitap : BaseEntity
    {
        public int UyeId { get; set; }
        public Uye Uye { get; set; }

        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }

        public DateTime VerilisTarihi { get; set; }
        public DateTime AlinisTarihi { get; set; }

    }
}
