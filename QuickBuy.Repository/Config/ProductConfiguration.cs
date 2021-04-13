using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;

namespace QuickBuy.Repository.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.Description)
                .HasMaxLength(400)
                .IsRequired();

            builder
                .Property(p => p.Price)
                .IsRequired();


        }
    }
}
