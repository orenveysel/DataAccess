using _6_EntityConfiguration.EntityConfigs.Abstract;
using _6_EntityConfiguration.Models.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_EntityConfiguration.EntityConfigs.Concrete
{
    public class OgrenciConfig:BaseMap<Ogrenci>
    {
        public override void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.AdSoyad).HasMaxLength(50);
            builder.Property(p => p.Cinsiyet).IsRequired();

            builder.HasOne(p=>p.Sinif).WithMany(p=>p.Ogrenciler).HasForeignKey(p=>p.SinifId);

            builder.HasData(new Ogrenci { Id = 1, AdSoyad = "Ali yilmaz", Cinsiyet = true ,SinifId=1},
                new Ogrenci { Id = 2, AdSoyad = "Veli durmaz", Cinsiyet = true, SinifId = 1 },
                new Ogrenci { Id = 3, AdSoyad = "Ayse kaya", Cinsiyet = false, SinifId = 1 });

        }
    }
}
