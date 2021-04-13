using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjectValue;
using System;

namespace QuickBuy.Repository.Config
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.Description)
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
