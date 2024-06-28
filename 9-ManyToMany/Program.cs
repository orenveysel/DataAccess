using _9_ManyToMany.OgrenciDersleri;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _9_ManyToMany.BlogPostModel;
namespace _9_ManyToMany
{
    public enum Gunler
    {
        Pazaretesi,
        Sali,
        Carsamba,
        Persembe
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //BlogDbContext dbcontext = new BlogDbContext();

            //Post post = new Post { Entry = "Html" };
            //Tag tag = new Tag { TagName = "Html Giris" };
            //Tag tag1 = new Tag { TagName = "Html Gelisme" };

            //PostTag postTag = new PostTag {Post=post, Tag=tag};
            //PostTag tag2 = new PostTag { Post=post, Tag=tag1};
            //post.PostTags.Add(postTag);
            //post.PostTags.Add(tag2);
            //dbcontext.Posts.Add(post);
            //dbcontext.SaveChanges();




            //Kategori Elektronik = new Kategori { KaegoriAdi = "Eletronik" };
            //Kategori Bilgisayar = new Kategori { KaegoriAdi = "Bilgisyara" };

            //Urun asus = new Urun { UrunAdi = "Asus Notebook I7 32GB" };
            //asus.Kategoriler = new List<Kategori>();
            //asus.Kategoriler.Add(Elektronik); ;
            //asus.Kategoriler.Add(Bilgisayar);

            //dbcontext.Urunler.Add(asus);
            //dbcontext.SaveChanges();

            //Console.WriteLine(Enum.GetName(typeof(Gunler),2));

            OkulDBContext dBContext = new OkulDBContext();
            //    Ogrenci ali = new Ogrenci { AdSoyad = "Ali Kaya" };
            //    Ogrenci ayse = new Ogrenci { AdSoyad = "Ayse Gezer" };
            //    Ders ders1 = new Ders { DersAdi="Matematik"};
            //    Ders ders2 = new Ders { DersAdi = "Fizik" };
            //    Ders ders3 = new Ders { DersAdi = "Muzik" };

            //    ali.AldigiDersler.Add(ders1);
            //    ali.AldigiDersler.Add(ders2);
            //    ali.AldigiDersler.Add(ders3);
            //    dBContext.Ogrenciler.Add(ali);


            //    ayse.AldigiDersler.Add(ders3);
            //    ayse.AldigiDersler.Add(ders2);
            //    ayse.AldigiDersler.Add(ders1);

            //    dBContext.Ogrenciler.Add(ayse);

            //    dBContext.SaveChanges();

            //    Console.WriteLine("Hello, World!");

            #region Coka Cok Iliskide Veri Silme
            //var ogrenci = dBContext.Ogrenciler.Include(p => p.AldigiDersler).Where(p=>p.Id==1).FirstOrDefault();
            //var muzik = ogrenci.AldigiDersler.Where(p=>p.DersAdi=="Muzik").FirstOrDefault();
            //ogrenci.AldigiDersler.Remove(muzik);
            //dBContext.SaveChanges();
            #endregion
            #region Coka Cok iliskide yeni kayit ekleme
            //var kimya = new Ders { DersAdi = "Kimya" };
            //dBContext.Dersler.Add(kimya);

            //var ali = dBContext.Ogrenciler.Find(1);
            //ali.AldigiDersler.Add(kimya);
            //dBContext.SaveChanges();
            #endregion
            #region Coka Cok iliskide update
            // 1 numarali ogrenci icin kimya dersini muzik yapalim
            //var ali = dBContext.Ogrenciler.Include(p => p.AldigiDersler).Where(p => p.Id == 1).FirstOrDefault();
            //var kimya = ali.AldigiDersler.FirstOrDefault(p => p.DersAdi == "Kimya");
            //ali.AldigiDersler.Remove(kimya);
            //var muzik = dBContext.Dersler.FirstOrDefault(p => p.DersAdi == "Muzik");
            //ali.AldigiDersler.Add(muzik);
            //dBContext.SaveChanges();
            #endregion
        }
    }

    #region Default Convention
    //İki entity arasındaki ilişkiyi navigation propertyler üzerinden çoğul olarak kurmalıyız. (ICollection, List)
    //Default Convention'da cross table'ı manuel oluşturmak zorunda değiliz. EF Core tasarıma uygun bir şekilde cross table'ı kendisi otomatik basacak ve generate edecektir.
    //Ve oluşturulan cross table'ın içerisinde composite primary key'i de otomatik oluşturmuş olacaktır.


    //public class Kategori
    //{
    //    public int Id { get; set; }
    //    public string KaegoriAdi { get; set; }
    //    public ICollection<Urun> Urunler { get; set; }
    //}

    //public class Urun
    //{
    //    public int Id { get; set; }
    //    public string UrunAdi { get;set; }
    //    public ICollection<Kategori> Kategoriler { get; set; }
    //}
    #endregion

    #region Data Annotation
    //Cross table manuel olarak oluşturulmak zorundadır.
    //Entity'lerde oluşturduğumuz cross table entity si ile bire çok bir ilişki kurulmalı.
    //CT'da composite primary key'i data annotation(Attributes)lar ile manuel kuramıyoruz. Bunun için de Fluent API'da çalışma yaopmamız gerekiyor.
    //Cross table'a karşılık bir entity modeli oluşturuyorsak eğer bunu context sınıfı içerisinde DbSet property'si olarka bildirmek mecburiyetinde değiliz!
   // public class Kategori
   // {
   //     public int Id { get; set; }
   //     public string KategoriAdi { get; set; }
   //     public virtual  IEnumerable<KategoriUrun> Urunler { get; set; }
   // }
   // public class Urun
   // {
   //     public int Id { get; set; }
   //     public string UrunAdi { get; set; }
   //     public virtual IEnumerable<KategoriUrun> Kategoriler { get; set; }
   // }
   //public class KategoriUrun
   // {

   //     //[Key()]
   //     //public int Id { get; set; }
   //     //[Key()]
   //     //public int Id2 { get; set; }
   //     [ForeignKey(nameof(Kategori))]
   //     public int KategoriId { get; set; }
   //     [ForeignKey(nameof(Urun))]
   //     public int UrunId { get; set; }

   //     public Kategori Kategori { get; set; }
   //     public Urun Urun { get; set; }
   // }

    #region Data Annotation Context'i
    //public class SqlDbcontext : DbContext
    //{
    //    public DbSet<Kategori> Kategoriler { get; set; }
    //    public DbSet<Urun> Urunler { get; set; }
    //    public DbSet<KategoriUrun> KategoriUrun { get; set; }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Istka2024ManyToMany;Trusted_Connection=true");

    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        #region Data Anatation
    //        //Composite PK Haskey metodu ile kurulmalı!
    //        //modelBuilder.Entity<KategoriUrun>().HasKey(p => new { p.UrunId, p.KategoriId }); 
    //        #endregion


    //    }
    //}
    #endregion
    #endregion

    #region Fluent Api
    //Cross table manuel oluşturulmalı
    //DbSet olarak eklenmesine lüzum yok, 
    //Composite PK Haskey metodu ile kurulmalı!

    //public class Kategori
    //{
    //    public int Id { get; set; }
    //    public string KategoriAdi { get; set; }
    //    public virtual IEnumerable<KategoriUrun> Urunler { get; set; }
    //}
    //public class Urun
    //{
    //    public int Id { get; set; }
    //    public string UrunAdi { get; set; }
    //    public virtual IEnumerable<KategoriUrun> Kategoriler { get; set; }
    //}
    //public class KategoriUrun
    //{
    //    public int KategoriId { get; set; }
    //    public int UrunId { get; set; }
    //    public Kategori Kategori { get; set; }
    //    public Urun Urun { get; set; }
    //}
    //public class SqlDbcontext : DbContext
    //{
    //    public DbSet<Kategori> Kategoriler { get; set; }
    //    public DbSet<Urun> Urunler { get; set; }
    
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Istka2024ManyToMany;Trusted_Connection=true");

    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<KategoriUrun>()
    //            .HasKey(p => new { p.UrunId, p.KategoriId });

    //        modelBuilder.Entity<KategoriUrun>()
    //            .HasOne(p => p.Kategori).WithMany(u => u.Urunler).HasForeignKey(p => p.KategoriId);

    //        modelBuilder.Entity<KategoriUrun>()
    //            .HasOne(p => p.Urun).WithMany(u => u.Kategoriler).HasForeignKey(p => p.UrunId);


    //    }
    //}

    #endregion
    #region Default convention Contetx'i
    //public class SqlDbcontext : DbContext
    //{
    //    public DbSet<Kategori> Kategoriler { get; set; }
    //    public DbSet<Urun> Urunler { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Istka2024ManyToMany;Trusted_Connection=true");

    //    }
    //} 
    #endregion
}
