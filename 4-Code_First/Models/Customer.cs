using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _4_Code_First.Models
{
    // Entity 
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }

        //Proplarin ozelliklerini degistirmek icin 1. Yol 
        // 1. Data Annotation Kullanmak
        // 2. yol Context Nesnemizde OnModelCreating Metodunu override etmek
        // 3. Yol ise Fluent api Kullanarak baska bir sinifa vermektir
        // 

        //DataAnnotion ile property'lerin uzerine Attribute ile isaretlemektir
        [MaxLength(50)]
        public string? City { get; set; }

        [MaxLength(50)]
        [DefaultValue("TR")]
        public string? Country { get; set; }

    }
}
