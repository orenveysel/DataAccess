using _6_EntityConfiguration.EntityConfigs.Abstract;
using _6_EntityConfiguration.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_EntityConfiguration.EntityConfigs.Concrete
{
    public class  SinifConfig : BaseMap<Sinif>
    {


        public override void Configure(EntityTypeBuilder<Sinif> builder)
        {
            base.Configure(builder);// Burayi silmeyin. Burasi BaseMap'i calistirir.

            builder.Property(p => p.SinifAdi).HasMaxLength(50);
            builder.HasIndex(p => p.SinifAdi).IsUnique();
            builder.HasData(new Sinif { Id = 1, SinifAdi = "11 A", Kapasite = 40 },
                            new Sinif { Id = 2, SinifAdi = "11 B", Kapasite = 50 });
                            

        }

        //public void Configure(EntityTypeBuilder<Brans> builder)
        //{
        //    builder.Property(p => p.BransAdi).HasMaxLength(50);
        //    builder.HasIndex(p => p.BransAdi).IsUnique();
        //    builder.HasData(new Brans { Id = 1, BransAdi = "Matematik" },
        //                    new Brans { Id = 2, BransAdi = "Fizik" },
        //                    new Brans { Id = 3, BransAdi = "Edebiyat" });


        //}
    }
}
