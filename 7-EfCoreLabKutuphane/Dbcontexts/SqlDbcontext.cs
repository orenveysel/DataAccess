using _7_EfCoreLabKutuphane.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _7_EfCoreLabKutuphane.Dbcontexts
{
    public class SqlDbcontext : DbContext
    {

        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Raf> Raflar { get; set; }

        public DbSet<Yazar> Yazarlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Database=Istka2024Kutuphane;User Id=postgres;Password=qweasd");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
