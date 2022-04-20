using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionTemplateEx.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Contexts.EntityMapping
{
    public class OfficeMap : Mapping<OfficeEntity>
    {
        public override void Configure(EntityTypeBuilder<OfficeEntity> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.City).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(150);
            builder.Property(x => x.State).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.Country)
                .WithMany(x => x.Offices)
                .HasForeignKey(x => x.CountryId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
