using _13_GenelTekrar2.DbContexts;
using _13_GenelTekrar2.OkulEntities.Concrete;
using Microsoft.EntityFrameworkCore;
namespace _13_GenelTekrar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext dbContext = new AppDbContext();

            #region 1-N Iliskili tablolarda CRUD Islemleri
            //Ali ogrencisine adres ekleyelim
            
            var ali = dbContext.Ogrenciler.Include(p=>p.Adresler).Include(p=>p.AldigiDersler).Where(p => p.Adsoyad.Contains("Ali")).FirstOrDefault();

            #region Yeni Adres Ekleme
            //Adres adres = new Adres();
            //adres.Ulke = "TC";
            //adres.Sehir = "Van";
            //adres.Ilce = "Muradiye";

            //ali.Adresler.Add(adres);

            //dbContext.SaveChanges();     
            #endregion
            #region Update
            //var adres = ali.Adresler.Where(p => p.Sehir == "Van").FirstOrDefault();
            //adres.Sehir = "Istanbul";
            //adres.Ilce = "Besiktas";
            //dbContext.SaveChanges();
            #endregion
            #region Delete
            //var adres = ali.Adresler.Where(p => p.Sehir == "Mus").FirstOrDefault();
            //ali.Adresler.Remove(adres);
            //dbContext.SaveChanges();
            #endregion

            #endregion


            #region N-N iliskili tablolarda CRUD Islemleri
            #region Create
            //Matematik 
            //var mat = dbContext.Dersler
            //                .Where(p => p.DersAdi.Contains("Mate"))
            //                .FirstOrDefault();
            //var fizik = dbContext.Dersler
            //                .Where(p => p.DersAdi.Contains("Fizik"))
            //                .FirstOrDefault();
            //var kimya = dbContext.Dersler
            //               .Where(p => p.DersAdi.Contains("Kimya"))
            //               .FirstOrDefault();

            //ali.AldigiDersler.Add(mat);
            //ali.AldigiDersler.Add(fizik);
            //ali.AldigiDersler.Add (kimya);
            //dbContext.SaveChanges();

            #region Yeni Bir DErs Ekleme

            //Ders felsefe = new Ders { DersAdi = "Felsefe" };

            //ali.AldigiDersler.Add(felsefe);
            //dbContext.SaveChanges();

            #endregion

            #region Update
            //Silinecek olan kayit
            var felsefe = ali.AldigiDersler.FirstOrDefault(p => p.DersAdi == "Felsefe");
            //Eklenecek olan kayit
            var edebiyat = dbContext.Dersler.FirstOrDefault(p => p.DersAdi == "Edebiyat");

            ali.AldigiDersler.Remove(felsefe);
            ali.AldigiDersler.Add(edebiyat);
            dbContext.SaveChanges();
            #endregion
            #endregion
            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
