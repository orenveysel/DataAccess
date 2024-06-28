using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _12_GenelTekrar.Kutuphane
{
    public class Yazar
    {

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string TcNo { get; set; }
        public bool Cinsiyet { get; set; }

        public ICollection<Adres> Adresler { get; set; } = new List<Adres>();

        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
