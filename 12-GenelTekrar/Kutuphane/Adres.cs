namespace _12_GenelTekrar.Kutuphane
{
    public class Adres
    {
        public int Id { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string CaddeSokak { get; set; }
        public string PostaKodu { get; set; }

        public int YazarID { get; set; }
        public Yazar Yazar { get; set; }
    }
}