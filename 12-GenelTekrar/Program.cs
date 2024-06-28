using _12_GenelTekrar.Model2;
using Microsoft.EntityFrameworkCore;
namespace _12_GenelTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NorthwindContext context = new NorthwindContext();
            #region Northwind Sorgulari

            #region  Musteri Listesi(Customers Tablosu)

            //var musteriler = context.Customers.ToList(); // Metod Syntax

            // Query Syntax 
            //var musteriler2 = from m2 in context.Customers
            //                  select m2;

            //foreach (var m in musteriler)
            //{
            //    Console.WriteLine($"{m.CustomerId}\t{m.CompanyName}\t{m.City}\t{m.Country}");
            //}

            #endregion

            #region Londra da ki musterilen listesi

            //var musteriler = context.Customers.Where(p => p.City == "London").ToList();
            //var musteriler3 = from m3 in context.Customers
            //                  where m3.City == "London"
            //                  select m3;
            //foreach (var m in musteriler)
            //{
            //    Console.WriteLine($"{m.CustomerId}\t{m.CompanyName}\t{m.City}\t{m.Country}");
            //}
            #endregion

            #region Iliskili Kayitlarin Sorgulanmasi
            /*select p.ProductName,c.CategoryName,p.UnitPrice 
                from Categories c
                inner join Products p 
                on c.CategoryID=p.CategoryID
             * 
             */
            #region Metod Syntax
            //var result = context.Categories.Include(p => p.Products).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CategoryName}");
            //    foreach (var p in item.Products)
            //    {
            //        Console.WriteLine($"{p.ProductName}\t{p.UnitPrice}");

            //    }
            //}
            #region Query Syntax

            //var result2 = from c in context.Categories
            //              join p in context.Products on c.CategoryId equals   p.CategoryId
            //              select new { p.ProductName,c.CategoryName,p.UnitPrice };
            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{item.ProductName}\t{item.CategoryName}\t{item.UnitPrice}");

            //}

            #endregion
            #endregion
            #endregion
            #endregion


            #region Entity Crud işlemleri

            #region Insert 
            //Shipper mng = new Shipper
            //{
            //    CompanyName = "Mng Kargo",
            //    Phone = "444 0 666"
            //};

            //context.Shippers.Add(mng);
            //context.SaveChanges();
            //Console.WriteLine(mng.ShipperId);

            #endregion
            #region Update işlemi 
            //mng kargonun telefonunu degistirelim

            //var mng = context.Shippers.Find(4);
            //mng.Phone = "555 0 666";
            //context.SaveChanges();
            #endregion
            #region Delete

            //var mng = context.Shippers.Where(p => p.CompanyName.Contains("Mng")).FirstOrDefault();

            //if (mng != null)
            //{
            //    context.Shippers.Remove(mng);
            //    context.SaveChanges();
            //}
            #endregion
            #endregion

            Console.WriteLine("Hello, World!");
           
        }
    }
}
