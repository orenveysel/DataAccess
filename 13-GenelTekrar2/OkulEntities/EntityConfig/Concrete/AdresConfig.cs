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
    public class AdresConfig:BaseConfig<Adres>
    {
        public override void Configure(EntityTypeBuilder<Adres> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.Ulke).HasMaxLength(50);
            builder.Property(p => p.Sehir).HasMaxLength(50);
            builder.Property(p => p.Ilce).HasMaxLength(50);
            builder.Property(p => p.CaddeSokak).HasMaxLength(500);
            builder.Property(p => p.KapiNo).HasMaxLength(50);
            builder.Property(p => p.PostaKod).HasMaxLength(15);



        }
    }
}
