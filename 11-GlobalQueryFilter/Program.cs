using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace _11_GlobalQueryFilter
{

    #region Global Query Filters Nedir?
    //Bir entity'e özel uygulama seviyesinde genel/ön kabullü şartlar oluşturmamızı ve böylece verileri global bir şekilde filtrelememeizi sağlayan bir özelliktir.
    //Böylece belirtilen entity üzerinden yapılan tm sorgulamalarda ekstradan bir şart ifadesine gerek kalmaksızın filtreleri otomatik uygulayarak hızlıca sorgulama yapmamızı sağlamaktadır.

    //Genellikle uygulama bazında aktif(IsActive) gibi verilerle çalışıldığı durumlarda,
    //MultiTenancy uygulamalarda TenantId tanımlarken vs. kullanılabilri.
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

            AppDbcontext dbcontext = new AppDbcontext();
            //var personeller = dbcontext.Persons 
            //    .Where(p=>p.IsDeleted==false).ToList();

            var result = dbcontext.Persons.ToList();

            #region Global Query Filter Ignore etmek isteyebiliriz

            var liste = dbcontext.Persons.IgnoreQueryFilters().ToList();
            #endregion

            #region Navigation Property Uzerinden Global Query filter Kullanimi
            //var p1 = dbcontext.Persons
            //    .AsNoTracking()
            //    .Include(p=>p.Orders)
            //    .Where(p=>p.Orders.Count > 0)
            //    .ToList();
            var p2 = dbcontext.Persons.AsNoTracking().Include(p=>p.Orders)
                .ToList();
           
            #endregion

            Console.WriteLine("Hello, World!");
        }
    }


    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public  int Price { get; set; }
        public string Description { get; set; }

    }

    public class AppDbcontext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Order> Orders { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Istka2024GlobalFilter;Trusted_Connection=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Burada en son verdigimiz glabal filter gecerli olacaktir
            modelBuilder.Entity<Person>().HasQueryFilter(p => p.Orders.Count > 0);
            //modelBuilder.Entity<Person>().HasQueryFilter(p=>p.IsDeleted == false);
        }
    }
}
