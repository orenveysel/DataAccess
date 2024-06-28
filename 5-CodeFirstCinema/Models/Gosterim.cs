using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CodeFirstCinema.Models
{
    public class Gosterim
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int SenanId { get; set; }
        public Seans Seans { get; set; }

        public int SalonId { get; set; }

        public Salon Salon { get; set; }
    }
}
