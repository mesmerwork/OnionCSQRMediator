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
    public class CustomerMap : Mapping<CustomerEntity>
    {
        public override void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CustomerName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(150);
            builder.Property(x => x.City).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.Customers)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
