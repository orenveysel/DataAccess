namespace _8_CodeFirstTelefonRehberi
{
    internal class Program
    {

        /*
         *  Telefon Defteri
         *  Kisiler ,Telefonlari,Emailleri,Adresleri
         * 
         * 
         */
        static void Main(string[] args)
        {

            Kisi kisi = new Kisi();
            kisi.AdSoyad = "Ali Yilmaz";

            kisi.Telefonlar.Add(new Telefon { Extension = "532", TelefonNo = "111 22 33" });
            kisi.Telefonlar.Add(new Telefon { Extension = "542", TelefonNo = "111 22 33" });

            kisi.Emailler.Add(new Email { EmailAdres = "Ali@gmail.com" });
            kisi.Emailler.Add(new Email { EmailAdres = "Ali@hotmail.com" });
            kisi.Emailler.Add(new Email { EmailAdres = "Ali@outlook.com" });

            kisi.Adresler.Add(new Adres { Ulke = "Tr", Sehir = "Van", Ilce = "Muradiye", CaddeSokak = "Kurtulus Cad" });
            kisi.Adresler.Add(
            new Adres { Ulke = "Tr", Sehir = "Mus", Ilce = "Merkez", CaddeSokak = "Kurtulus Cad" });

            SqlDbcontext dbcontext = new();
            dbcontext.Kisiler.Add(kisi);
            dbcontext.SaveChanges();
            Console.WriteLine("Hello, World!");
        }
    }
}
