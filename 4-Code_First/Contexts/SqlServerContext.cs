using _4_Code_First.Models;
using Microsoft.EntityFrameworkCore;

namespace _4_Code_First
{
    /*
     * Olusturulan Context'i db'ye gondermek icin 2 farkli yontem var.
     * 
     * 1. Yontem. Command Line Interface uzerinden yani cli ile siyah ekran uzerinden gonderim
     * 
     * 2. Nuget paketlerinden Microsoft.EntityFrameWorkjCore.Tools paketini kurarak PM uzerinden calismak
     * 
     *  Bu yonetemlerden hangisini secerseniz secin , Mutlaka Migratin cikartmaniz lazim. 
     *  Iste bu migration 'i cikartmak icin yukaridaki yontemlerden birisini kullanmak gereklidir.
     */
    public class SqlServerContext:DbContext
    {
        // burada verdigimiz prop ismi database de tablo ismi olarak yansiyacaktir
        public DbSet<Product> Urunler { get; set; }
        public DbSet<Customer> Musteriler { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Musteri> Cariler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        #region EF Core Yapilandirma
        //Default davranışları yeri geldiğinde geçersiz kılmak ve özelleştirmek isteyebiliriz. Bundan dolayı yapılandırmalara ihtiyacımız olacaktır.
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=Iska2024Test;Trusted_Connection=true;");
        }
        #region OnModelCreating
        //EF Core'da yapılandırma deyince akla ilk gelen metot OnModelCreating metodudur.
        //Bu metot, DbContext sınıfı içerisinde virtual olarak ayarlanmış bir metottur.
        //Bizler bu metodu kullanarak model'larımızla ilgili temel konfigürasyonel davranışları(Fluent API) sergileyeibliriz.
        //Bir model'ın yaratılışıyla ilgili tüm konfigürasyonları burada gerçekleştirebilmekteyiz.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Fluent APİ
            #region GetEntityTypes
            // EF Core'da kullanılan entity'leri elde etmek, programatik olarak öğrenmek istiyorsak eğer GetEntityTypes fonksiyonunu kullanabiliriz.
            var entities = modelBuilder.Model.GetEntityTypes();
            //foreach (var item in entities)
            //{ 

            //}
            #endregion

            #region Column
            modelBuilder.Entity<Product>()
                        .Property(p => p.Quantity)
                        .HasColumnName("Adet")
                        .HasColumnType("decimal")
                        .HasColumnOrder(4)
                        .HasDefaultValue(0);

            modelBuilder.Entity<Product>()
                        .Property(p => p.CreateDate)
                        .HasDefaultValue(DateTime.Now);
           

            #endregion
            #region ToTable
            modelBuilder.Entity<Product>().ToTable("Stoklar");
            #endregion

            #region Required => Hangi property'lerin zorunlu oldugunu belirtir
            modelBuilder.Entity<Customer>()
                        .Property(p => p.CompanyName)
                        .IsRequired();
            #endregion

            #region MaxLength

            modelBuilder.Entity<Product>()
                        .Property(p => p.Name)
                        .HasMaxLength(50);
            #endregion


            #region Index Olusturma
            // Ayni produt isminden 2.si olmasin 

            #region Unique Index
            modelBuilder.Entity<Product>()
                  .HasIndex(p => p.Name).IsUnique(); 
            #endregion
            #region Coklu property'lere gore index atma
            modelBuilder.Entity<Customer>()
                .HasIndex(p => new { p.City, p.Country });

            #endregion

            #region Primary Key Vermek icin 

            modelBuilder.Entity<Customer>()
                .HasKey(p => p.CustomerId);
            #endregion

            #region ForignKey - HasForeignKeyn
            //İlişkisel tablo tasarımlarında, bağımlı tabloda esas tabloya karşılık gelecek verilerin tutulduğu kolonu foreign key olarak temsil etmekteyiz.
            //EF Core'da foreign key kolonu genellikle Entity Tnaımlama kuralları gereği default yapılanmalarla oluşturulur.
            //ForeignKey Data Annotations Attribute'unu direkt kullanabilirsiniz. Lakin Fluent api ile bu konfigürasyonu yapacaksanız iki entity arasındaki ilişkiyide modellemeniz gerekmektedir. Aksi taktirde fluent api üzerinde HasForeignKey fonksiyonunu kullanamnazsınız!

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category) // Product Entity icerisindeki Category property'si bir tane olacak 
                .WithMany(p => p.Products) // Ancak Category Entity icerisindeki products lar cok olacak 
                .HasForeignKey(p => p.CategoryId); // Relation burada CategoryId uzerinden olacak

            #region Siparis ile Urunler ve Cariler arasindaki iliskiyi tanimlayalim
            modelBuilder.Entity<Siparis>()
                .HasOne(p => p.Musteri)
                .WithMany(p => p.Siparisler)
                .HasForeignKey(s => s.MusteriId);

            modelBuilder.Entity<Siparis>()
                .HasOne(p => p.Urun)
                .WithMany(p => p.Siparisler)
                .HasForeignKey(x => x.ProductId);
            #endregion

            #endregion

            #endregion


            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
