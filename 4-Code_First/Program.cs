using _4_Code_First.Models;

namespace _4_Code_First
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlServerContext context = new SqlServerContext();

            //Customer customer = new Customer()
            //{
            //    City = "IStanbul",
            //    CompanyName = "XYZ Ltd",
            //    Country="TR"
            //};
            //context.Musteriler.Add(customer);

            //Product product = new Product()
            //{
            //    Name = "Test"


            //};
            //context.Urunler.Add(product);

            Category category = new Category()
            {
                CategoryName="Gida",
                Description="Gida",
                
                
            };
            int result=0;
            Product kumas = new Product() { Name = "Gazoz" };
            Product tisort = new Product() { Name = "Elma" };
            Product sal = new Product() { Name = "Ekmek" };
            category.Products = new List<Product>();
            category.Products.Add(kumas);
            category.Products.Add(tisort);
            category.Products.Add(sal);

            context.Categories.Add(category);
            var data = context.ChangeTracker.Entries();
            
            try
            {
                result =context.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
          
            Console.WriteLine("Hello, World:" + result);
        }
    }
}
