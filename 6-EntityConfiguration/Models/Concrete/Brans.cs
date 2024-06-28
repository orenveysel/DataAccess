using _6_EntityConfiguration.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_EntityConfiguration.Models.Concrete
{
    public class Brans:BaseEntity
    {
        public string BransAdi { get; set; }

        public ICollection<Ogretmen> Ogretmenler { get; set; }
    }
}
