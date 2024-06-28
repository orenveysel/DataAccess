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
    public class OgretmenConfig: BaseMap<Ogretmen>
    {
        public override void Configure(EntityTypeBuilder<Ogretmen> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.AdSoyad).HasMaxLength(50);
          
            // brasn ile bire cok iliski tanimlamasi 
            builder.HasOne(p=>p.Brans).WithMany(p=>p.Ogretmenler).HasForeignKey(p=>p.BransId);

            builder.HasData(new Ogretmen { Id = 1, AdSoyad = "Fatma Guner", Cinsiyet = true,BransId=1 },
                new Ogretmen { Id = 2, AdSoyad = "Hanife Kaçmaz", Cinsiyet = false, BransId = 2 },
                new Ogretmen { Id = 3, AdSoyad = "Hasan Durmaz", Cinsiyet = true , BransId = 3 });

        }
    }
}
