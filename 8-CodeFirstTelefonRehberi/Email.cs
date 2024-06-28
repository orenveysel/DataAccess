using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CodeFirstTelefonRehberi
{
    public class Email
    {
        public int Id { get; set; }
        public string EmailAdres { get; set; }

        public int KisiId { get; set; }
        public Kisi Kisi { get; set; }

    }
}
