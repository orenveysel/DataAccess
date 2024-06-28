namespace _8_CodeFirstTelefonRehberi
{
    public class Adres
    {
        public int Id { get; set; }
        public string? Ulke { get; set; }
        public string? Sehir { get; set; }
        public string? Ilce { get; set; }
        public string? CaddeSokak { get; set; }

        public int KisiId { get; set; }
        public Kisi Kisi { get; set; }
    }
}