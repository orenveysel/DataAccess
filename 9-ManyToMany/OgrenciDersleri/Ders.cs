using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ManyToMany.OgrenciDersleri
{

    public class Adress
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }

       
    }
    //public class OgrenciVeli
    //{
    //    public int Id { get; set; }
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public List<Ogrenci> Ogrenciler { get; set; }
    //}

    public class Ogrenci
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public List<Ders> AldigiDersler { get; set; } = [];
        public List<Adress> Adresler{ get; set; } = [];
       
        public List<Iletisim> Iletisim { get; set; } = [];
    }
    public class Iletisim
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }

        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }

    public class Ders
    {
        public int Id { get; set; }
        public string DersAdi { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; }
    }

    public class OkulDBContext : DbContext
    {
        
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }



        public DbSet<Iletisim> Iletisim { get; set; }
        //public DbSet<OgrenciVeli> OgrenciVelileri { get; set; }
        public DbSet<Adress> Adres { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Istka2024ManyToManyOgrenciDersleri;Trusted_Connection=true");

        }

    }
}
