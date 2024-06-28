using _7_EfCoreLabKutuphane.EntityConfig.Abstract;
using _7_EfCoreLabKutuphane.Models.Abstract;
using _7_EfCoreLabKutuphane.Models.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EfCoreLabKutuphane.EntityConfig.Concrete
{
    public class YazarConfig :BaseConfig<Yazar>
    {
        public override void Configure(EntityTypeBuilder<Yazar> builder)
        {
            base.Configure(builder); // Burasi silmeyin. base.Config BaseEntity icerisindeki configurasyonlari yapar.

            builder.Property(p => p.Adi).HasMaxLength(100).IsRequired();
            builder.Property(p => p.SoyAdi).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100);
            builder.Property(p => p.Gsm).HasMaxLength(20);



        }
    }
}
