using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CodeFirstTelefonRehberi
{
    public class Dbcontext2 : DbContext
    {
        public DbSet<Kisi> Kisiler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Istka2024TelefonDefteri;Trusted_connection=true");
        }

    }
}
