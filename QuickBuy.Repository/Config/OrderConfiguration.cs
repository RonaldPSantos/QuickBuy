using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Repository.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder
                .Property(o => o.Adress)
                .IsRequired();

            builder
                .Property(o => o.Number);

            builder
                .Property(p => p.City)
                .HasMaxLength(100);

            builder
                .Property(p => p.State)
                .HasMaxLength(100);

            builder
                .Property(p => p.PostalCode)
                .HasMaxLength(10);

            builder
                .Property(o => o.DateOrder)
                .IsRequired();

            builder
                .Property(o => o.DeliveryForecast)
                .IsRequired();

            builder.HasOne(o => o.User);

        }
    }
}
