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
    public class PaymentMap : Mapping<PaymentEntity>
    {
        public override void Configure(EntityTypeBuilder<PaymentEntity> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Amount).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PaymentDate).IsRequired();         

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
