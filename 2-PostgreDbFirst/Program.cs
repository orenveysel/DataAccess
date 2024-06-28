using _2_PostgreDbFirst.Model;
using Microsoft.EntityFrameworkCore;

namespace _2_PostgreDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext db = new NorthwindContext();

            #region Postgresql Database 

            #region Musterilerin siparis adetleri nedir 

            #region Metod 

            //var result = db.Customers.Include(p=>p.Orders).ToList();

            //Console.WriteLine("****************");

            //foreach (var musteri in result)
            //{
            //    Console.WriteLine(musteri.CustomerId+"\t"+ musteri.CompanyName+"\t"+" siparis Sayisi:"+musteri.Orders.Count);
            //}
            #endregion
            #endregion


            #region CRUD Islemleri

            #region Kayit Ekleme
           


            #endregion

            #endregion
            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
