using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Repository.Config
{
    public class ItemOrderConfiguration : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.ProducId)
                .IsRequired();

            builder
                .Property(i => i.Amout)
                .IsRequired();

        }
    }
}
