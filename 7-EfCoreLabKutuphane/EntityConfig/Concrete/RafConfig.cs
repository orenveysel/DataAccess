using _7_EfCoreLabKutuphane.EntityConfig.Abstract;
using _7_EfCoreLabKutuphane.Models.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EfCoreLabKutuphane.EntityConfig.Concrete
{
    public class RafConfig :BaseConfig<Raf>
    {
        public override void Configure(EntityTypeBuilder<Raf> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.RafKodu).HasMaxLength(100).IsRequired();
            builder.Property(p => p.RafAdi).HasMaxLength(100);

            builder.HasIndex(p => p.RafKodu).IsUnique();



        }
    }
}
