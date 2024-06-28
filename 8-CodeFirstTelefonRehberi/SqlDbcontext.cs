using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CodeFirstTelefonRehberi
{
    public class SqlDbcontext : DbContext
    {
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Telefon> Telefonlar { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Adres> Adresler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Database=Istka2024TelefonRehberi;User Id=postgres;Password=qweasd");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>().HasKey(p => p.Id);// Id alani Primary Keydir

            #region NoAction  => Hiçbirsey yapma
            modelBuilder.Entity<Kisi>()
                .HasMany(p => p.Telefonlar)
                .WithOne(t => t.Kisi)
                .HasForeignKey(p => p.KisiId);

            #endregion

            #region Iliskili kayitlara Null deger ata
            modelBuilder.Entity<Kisi>()
                .HasMany(p => p.Emailler)
                .WithOne(e => e.Kisi)
                .HasForeignKey(f => f.KisiId);

            #endregion
            #region Cascade => Iliskili kayitlari da sil
            modelBuilder.Entity<Kisi>()
                  .HasMany(p => p.Adresler)
                  .WithOne(p => p.Kisi)
                  .HasForeignKey(p => p.KisiId);
            #endregion

            #region Delete Stratejisi

            #endregion

        }

    }
}
