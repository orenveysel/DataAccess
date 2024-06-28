using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CodeFirstCinema.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string FilmAdi { get; set; }
        public string Aciklama { get; set; }

        public int KategoriId { get; set; }

        public Kategori Kategori { get; set; }

        public int YonetmenId { get; set; }

        public Yonetmen Yonetmen { get; set; }
    }
}
