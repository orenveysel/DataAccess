using _7_EfCoreLabKutuphane.EntityConfig.Abstract;
using _7_EfCoreLabKutuphane.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EfCoreLabKutuphane.EntityConfig.Concrete
{
    public class OduncKitapConfig :BaseConfig<OduncKitap>
    {
        public override void Configure(EntityTypeBuilder<OduncKitap> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.VerilisTarihi).HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(p => p.Uye)
                .WithMany(p => p.Kitaplar)
                  .HasForeignKey(p => p.UyeId);

            builder.HasOne(p=>p.Kitap)
                .WithMany(p=>p.OduncKitaplar)
                .HasForeignKey(p=>p.KitapId);



        }
    }
}
