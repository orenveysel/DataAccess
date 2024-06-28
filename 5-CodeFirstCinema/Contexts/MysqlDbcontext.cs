using _5_CodeFirstCinema.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CodeFirstCinema.Contexts
{
    public class MysqlDbcontext:DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Seans> Seans { get; set; }
        public DbSet<Yonetmen> Yonetmen { get; set; }

        public DbSet<Gosterim> Gosterim { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=localhost;Database=Istka2024Cinema;Uid=root;Pwd=1q2w3E*");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Salon Entity Ayarlari
            modelBuilder.Entity<Salon>()
                   .HasKey(p => p.Id);
            modelBuilder.Entity<Salon>()
                .Property(p => p.SalonAdi)
                .HasMaxLength(50);

            modelBuilder.Entity<Salon>().HasIndex(p => p.SalonAdi).IsUnique();
            #endregion
            #region Seans Entity Ayarlari
            modelBuilder.Entity<Seans>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Seans>()
                .Property(p => p.SeansAdi).HasMaxLength(50);

            modelBuilder.Entity<Seans>()
                .HasIndex(p => p.SeansAdi).IsUnique();


            #endregion
            #region Yonetmen Entity Ayarlari
            modelBuilder.Entity<Yonetmen>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Yonetmen>()
                .Property(p => p.AdSoyad).HasMaxLength(50);
            modelBuilder.Entity<Yonetmen>()
                .HasIndex(p => p.AdSoyad).IsUnique();





            #endregion

            #region Kategori Entity Ayarlari
            #region Kategori Property Ayarlari
            modelBuilder.Entity<Kategori>()
                  .HasKey(p => p.Id);
            modelBuilder.Entity<Kategori>()
                .Property(p => p.Aciklama).HasMaxLength(50);
            modelBuilder.Entity<Kategori>()
                .Property(p => p.KategoriAdi).HasMaxLength(50);
            modelBuilder.Entity<Kategori>()
                .Property(p => p.KayitTarihi).HasDefaultValue(DateTime.Now);
            #endregion

            #endregion

            #region Film Entity Ayarlari
            #region Film Propertyleri 
            modelBuilder.Entity<Film>().HasKey(p => p.Id);
            modelBuilder.Entity<Film>().Property(p => p.FilmAdi).HasMaxLength(50);
            modelBuilder.Entity<Film>().HasIndex(p => p.FilmAdi).IsUnique();
            modelBuilder.Entity<Film>().Property(p => p.FilmAdi).IsRequired();
            modelBuilder.Entity<Film>().Property(p => p.Aciklama).HasMaxLength(50);
            modelBuilder.Entity<Film>().Property(p => p.Aciklama).IsRequired();
            modelBuilder.Entity<Film>().Property(p => p.Aciklama).HasMaxLength(50);
            #endregion


            #region Kategori => Film iliskisi
            modelBuilder.Entity<Film>().HasOne(p => p.Kategori)
        .WithMany(p => p.Filmler)
        .HasForeignKey(p => p.KategoriId);
            #endregion


            #region Film=> Yonetmen iliskisi
            modelBuilder.Entity<Film>().HasOne(p => p.Yonetmen)
                 .WithMany(p => p.Filmler)
                 .HasForeignKey(p => p.YonetmenId);
            #endregion
            #endregion

            #region Gosterim Entity Ayarlari
            modelBuilder.Entity<Gosterim>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Gosterim>()
                    .HasIndex(p => new { p.SenanId, p.SalonId, p.FilmId }).IsUnique();
            #endregion
        }
    }
}
