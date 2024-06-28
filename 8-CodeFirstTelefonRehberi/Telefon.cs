using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CodeFirstTelefonRehberi
{
    public class Telefon 
    {
        public int Id { get; set; }
        public string Extension { get; set; }
        public string TelefonNo { get; set; }

        public int? KisiId { get; set; }
        public Kisi? Kisi { get; set; }

    }
}
