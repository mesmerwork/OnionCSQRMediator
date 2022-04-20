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
    public class EmployeeMap : Mapping<EmployeeEntity>
    {
        public override void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.JobTitle).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(150);

            builder.HasOne(x => x.Office)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.OfficeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
