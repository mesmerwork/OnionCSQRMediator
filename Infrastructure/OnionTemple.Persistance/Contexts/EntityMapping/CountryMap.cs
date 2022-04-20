using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionTemplateEx.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance.Contexts.EntityMapping
{
    public class CountryMap:Mapping<CountryEntity>
    {
        public override void Configure(EntityTypeBuilder<CountryEntity> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Region).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Capital).IsRequired().HasMaxLength(50);
                      

        }
    }
}
