using _7_EfCoreLabKutuphane.Models.Abstract;

namespace _7_EfCoreLabKutuphane.Models.Concrete
{
    public class Uye : BaseEntity
    {
        public string  AdSoyad { get; set; }
        public bool Cinsiyet { get; set; }

        public ICollection<OduncKitap> Kitaplar { get; set; }
    }
}