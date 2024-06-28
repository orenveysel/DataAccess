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
    public class BransConfig : BaseMap<Brans>
    {


        public override void Configure(EntityTypeBuilder<Brans> builder)
        {
            base.Configure(builder);// Burayi silmeyin. Burasi BaseMap'i calistirir.

            builder.Property(p => p.BransAdi).HasMaxLength(50);
            builder.HasIndex(p => p.BransAdi).IsUnique();
            builder.HasData(new Brans { Id = 1, BransAdi = "Matematik" },
                            new Brans { Id = 2, BransAdi = "Fizik" },
                            new Brans { Id = 3, BransAdi = "Edebiyat" });

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
