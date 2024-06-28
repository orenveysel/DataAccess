using _1_DbFirst.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace _1_DbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
           NorthwindContext context = new NorthwindContext();
            #region Context Kullanimi 
            #region Musteri Listesi
            #region Metod Yontemi
            //var musteriler = context.Customers.ToList();
            //foreach (var item in musteriler)
            //{
            //    Console.WriteLine($"{item.CustomerId}\t{item.CompanyName}\t{item.City}\t{item.Country}");
            //}  
            #endregion
            #region Query Syntax

            //var result = from musteriler in context.Customers
            //             select musteriler;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CustomerId}\t{item.CompanyName}\t{item.City}\t{item.Country}");
            //}
            #endregion
            #region Ingilteredeki musterilerimin listesi 
            #region Metod Syntax
            //var musteriler = context.Customers.Where(p => p.Country == "UK").ToList();
            //foreach (var item in musteriler)
            //{
            //    Console.WriteLine($"{item.CustomerId}\t{item.CompanyName}\t{item.City}\t{item.Country}");
            //} 

            #region Query 
            //var result = from musteriler in context.Customers
            //             where musteriler.Country=="UK"
            //             orderby musteriler.Country
            //             select musteriler ;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CustomerId}\t{item.CompanyName}\t{item.City}\t{item.Country}");
            //}

            #endregion
            #endregion
            #endregion
            #region Iliskili kayitlarin Getirilmesi
            #region Metod
            // 1-n iliskili tsblolarda Metod yontemi ile kullanimi
            //var result = context.Categories.Include(p => p.Products).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CategoryId}\t{item.CategoryName}\t{item.Description}\t");
            //    foreach (var product in item.Products)
            //    {
            //    Console.WriteLine($"{product.ProductId}\t{product.ProductName}\t{product.UnitPrice}\t{product.CategoryId}"); 
            #endregion
            #region Query
            //var result = from category in context.Categories
            //             join product in context.Products on category.CategoryId equals product.CategoryId
            //             select category;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CategoryId}\t{item.CategoryName}\t{item.Description}\t");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"{product.ProductId}\t{product.ProductName}\t{product.UnitPrice}\t{product.CategoryId}");
            //    }
            //}
            #endregion
            #region Musteriler , siparisleri ve siparis detaylari
            #region Metod

            //var result = context.Customers
            //                    .Include(p => p.Orders)
            //                    .ThenInclude(z => z.OrderDetails)
            //                    .ThenInclude(x => x.Product)
            //                    .ToList();

            //foreach (var customer in result)
            //{
            //    Console.WriteLine("****************************");
            //    Console.WriteLine($"{customer.CustomerId}\t{customer.CompanyName}");

            //    foreach (var order in customer.Orders)
            //    {
            //        Console.WriteLine($"{order.OrderId}\t{order.OrderDate}\t{order.ShipCountry}");

            //        foreach (var item in order.OrderDetails)
            //        {
            //            Console.WriteLine($"{item.OrderId}\t{item.Product.ProductName}\t{item.UnitPrice}\t{item.Quantity}\t Toplam Satir Tutari:{item.Quantity * item.UnitPrice}");
            //        }

            //    }
            //}

            #endregion
            #region Query 

            //var result2 = (from customer in context.Customers
            //              join orders in context.Orders on customer.CustomerId equals orders.CustomerId
            //              join detail in context.OrderDetails on orders.OrderId equals detail.OrderId
            //              join product in context.Products on detail.ProductId equals product.ProductId
            //              select new { customer, orders, detail, product }).ToList();


            //foreach (var customer in result2)
            //{
            //    Console.WriteLine("****************************");
            //    Console.WriteLine($"{customer.customer.CustomerId}\t{customer.customer.CompanyName}");

            //    foreach (var order in customer.customer.Orders)
            //    {
            //        Console.WriteLine($"{order.OrderId}\t{order.OrderDate}\t{order.ShipCountry}");

            //        foreach (var item in order.OrderDetails)
            //        {
            //            Console.WriteLine($"{item.OrderId}\t{item.Product.ProductName}\t{item.UnitPrice}\t{item.Quantity}\t Toplam Satir Tutari:{item.Quantity * item.UnitPrice}");
            //        }

            //    }
            //}

            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #region Crud Islemleri
            #region Yeni Kayit Ekleme
            //Category category = new Category();
            //category.CategoryName = "Test2";
            //category.Description = "Deneme ";

            //context.Categories.Add(category);
            //context.SaveChanges();
            #endregion
            #region Update işlemi
            //var category = context.Categories.Find(11);
            //category.CategoryName = "Erkek Giyim";
            //category.Description = "Erkek Giyim";
            //context.SaveChanges();
            #endregion
            #region Delete

            //var category = context.Categories.Find(11);
            //context.Categories.Remove(category);
            //context.SaveChanges();
            #endregion
            #endregion
            #region Change Tracking kavrami

            //Category category = new Category
            //{
            //    CategoryName="Gida",
            //    Description="Gida"
            //};

            //var bayanGiyim = context.Categories.Find(10);
            //bayanGiyim.CategoryName = "Cocuk Giyim";
            //bayanGiyim.Description = "Cocuk Giyim";

            //var testil = context.Categories.Find(9);

            //context.Categories.Add(category);
            //context.Categories.Remove(testil);
            ////var currentState = context.Entry(blog).State;
            //var categoryState =  context.Entry(category).State;
            //var testilState = context.Entry(testil).State;
            //var bayanGiyimState = context.Entry(bayanGiyim);

            //context.SaveChanges();
            #endregion
            #region AsNoTracking Metodu
            //Context üzerinden gelen tüm datalar Change Tracker mekanizması tarafından takip edilmektedir.

            //Change Tracker, takip ettiği nesnelerin sayısıyla doğru orantılı olacak şekilde bir maliyete sahiptir. O yüzden üzerinde işlem yapılmayacak verilerin takip edilmesi bizlere lüzumsuz yere bir maliyet ortaya çıkaracaktır.
            //AsNoTracking metodu, context üzerinden sorgu neticesinde gelecek olan verilerin Change Tracker tarafından takip edilmesini engeller.

            //AsNoTracking metodu ile Change Tracker'ın ihtiyaç olmayan verilerdeki maliyetini törpülemiş oluruz.


            // AsNoTracking fonksiyonu ile yapılan sorgulamalarda, verileri elde edebilir, bu verileri istenilen noktalarda kullanabilir lakin veriler üzerinde herhangi bir değişiklik/ update işlemi yapamayız.
            var result = context.Categories.AsNoTracking().ToList();


            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
