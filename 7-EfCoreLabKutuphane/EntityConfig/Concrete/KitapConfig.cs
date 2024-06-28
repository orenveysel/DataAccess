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
    public class KitapConfig : BaseConfig<Kitap>
    {
        public override void Configure(EntityTypeBuilder<Kitap> builder)
        {
            base.Configure(builder);
            #region Default Property configuration'lari
            builder.Property(p => p.KitapAdi).HasMaxLength(100);
            builder.Property(p => p.Aciklama).HasMaxLength(500); 
            #endregion

            #region Yazarla olan iliski Tanimi
            builder.HasOne(p => p.Yazar)
                         .WithMany(p => p.Kitaplar)
                             .HasForeignKey(p => p.YazarId);
            #endregion

            #region Raf ile iligli tanimlama

            builder.HasOne(p=>p.Raf)
                    .WithMany(p => p.Kitaplar)
                        .HasForeignKey(p => p.RafId);

            #endregion


        }
    }
}
