using _13_GenelTekrar2.OkulEntities.Concrete;
using _13_GenelTekrar2.OkulEntities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_GenelTekrar2.OkulEntities.EntityConfig.Concrete
{
    public class OgrenciConfig:BaseConfig<Ogrenci>
    {
        public override void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Adsoyad).HasMaxLength(50);
            builder.Property(p => p.TcNo).HasMaxLength(11);
            builder.Property(p => p.Gsm).HasMaxLength(15);
            builder.Property(p => p.Email).HasMaxLength(50);
            
            // Ayni Tc 'den ikinci bir kayit olmasin
            builder.HasIndex(p=>p.TcNo).IsUnique();


        }
    }
}
