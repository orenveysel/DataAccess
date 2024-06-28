using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Code_First.Models
{
    public class Siparis
    {
        public int Id { get; set; }

        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        public int ProductId { get; set; }
        public Product Urun { get; set; }

        public decimal Tutar { get; set; }

    }
}
