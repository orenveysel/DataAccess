using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CodeFirstCinema.Models
{
    public  class Yonetmen
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public bool? Cinsiyet { get; set; }

        public ICollection<Film> Filmler { get; set; }
    }
}
