using System.ComponentModel.DataAnnotations.Schema;

namespace _4_Code_First.Models
{
    // Entity 
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        //Burasi ise database'e yansir
        //[ForeignKey(nameof(Category))] => Data Annotation ile yapilmasi
        public int CategoryId { get; set; }


        //Navigation Property 
        public Category Category { get; set; } // Database'e yansimaz. Cunku Database'de Category adinda bir veri tipi yoktur

        public ICollection<Siparis> Siparisler { get; set; }
        public DateTime CreateDate { get; set; } 

    }
}
