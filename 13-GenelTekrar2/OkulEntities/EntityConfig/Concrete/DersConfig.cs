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
    public class DersConfig:BaseConfig<Ders>
    {
        public override void Configure(EntityTypeBuilder<Ders> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.DersAdi).HasMaxLength(50);
            // Ayni isimden ikinci bir kayit olmasin 
            builder.HasIndex(p => p.DersAdi).IsUnique();

            builder.HasData(new Ders { Id = Guid.NewGuid().ToString(), DersAdi = "Matematik" },
                new Ders { Id = Guid.NewGuid().ToString(), DersAdi = "Fizik" },
                new Ders { Id = Guid.NewGuid().ToString(), DersAdi = "Kimya" },
                new Ders { Id = Guid.NewGuid().ToString(), DersAdi = "Edebiyat" }

            );
        }
    }
}
