using _7_EfCoreLabKutuphane.Models.Abstract;
using System.Globalization;

namespace _7_EfCoreLabKutuphane.Models.Concrete
{
    public class Kitap :BaseEntity
    {
        public string KitapAdi { get; set; }
        public string  Aciklama { get; set; }

        public short SayfaSayisi { get; set; }

        public int YazarId { get; set; }

        public Yazar Yazar { get; set; }


        public int RafId { get; set; }
        public Raf Raf { get; set; }

        public ICollection<OduncKitap> OduncKitaplar { get; set; }


    }
}