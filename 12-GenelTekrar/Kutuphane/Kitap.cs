namespace _12_GenelTekrar.Kutuphane
{

    public enum KitapTuru:byte
    {
        Roman=1,
        Siir,
        Tarih,
        Biyografi,
        Bilim,
        Psikoloji,
        Sosyoloji
    }

    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string? Aciklama { get; set; }
        public KitapTuru Tur { get; set; }
        public int? SayfaSayisi { get; set; }
        public string? ISBN { get; set; }

        public int YazarID { get; set; }

        public Yazar Yazar { get; set; } // Database'e yansimaz. Navigation Property 
    }
}