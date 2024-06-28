using _6_EntityConfiguration.EntityConfigs;
using _6_EntityConfiguration.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6_EntityConfiguration.Dbcontexts
{
    public class SqlDbconetext : DbContext
    {

        public DbSet<Brans> Branslar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Sinif> Sinifar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Database=Istka2024Okul;User Id=postgres;Password=qweasd");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 1. yol Olusturdugumuz config dosyalarini burada tek tek instance almak

            // 1. yol Olusturdugumuz config dosyalarini burada tek tek instance almak
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig());
            //modelBuilder.ApplyConfiguration(new BransConfig()); 
            #endregion
           
            //ApplyConfigurationFromAssembly metodu mevcut projemiz uzerinde
            // IEntityTypeConfiguration interface'inden inherit almiş butun class'lari bulur ve 
            // Herbirini tek tek uygular

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
