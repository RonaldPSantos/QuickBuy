using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Repository.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.Password)
                .HasMaxLength(400)
                .IsRequired();

            builder
                .HasMany(u => u.Orders)
                .WithOne(p => p.User);

        }
    }
}
