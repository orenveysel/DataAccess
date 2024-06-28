using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CodeFirstCinema.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }

        public DateTime KayitTarihi { get; set; }

        public ICollection<Film> Filmler { get; set; }
    }
}
