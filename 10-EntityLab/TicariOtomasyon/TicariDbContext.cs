using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EntityLab.TicariOtomasyon
{
    public class TicariDbContext:DbContext
    {
        public DbSet<Cari> CariKartlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }

        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<DepoHareket> DepoHareketleri { get; set; }

        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Istka2024TicariOtomasyon;Trusted_Connection=true");

        }


    }
}
