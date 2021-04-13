using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.ObjectValue;
using QuickBuy.Repository.Config;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }

        public DbSet<PaymentMethod> PaymentMethod { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de mapeamento
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ItemOrderConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());

            modelBuilder.Entity<PaymentMethod>().HasData(new PaymentMethod() { Id = 1, Description = "Não definido", Name = "Não definido" });
            modelBuilder.Entity<PaymentMethod>().HasData(new PaymentMethod() { Id = 2, Description = "Boleto", Name = "Pagamento Boleto" });
            modelBuilder.Entity<PaymentMethod>().HasData(new PaymentMethod() { Id = 3, Description = "Cartão", Name = "Pagamento Cartão" });
            modelBuilder.Entity<PaymentMethod>().HasData(new PaymentMethod() { Id = 4, Description = "Depósito", Name = "Pagamento Depósito" });

            base.OnModelCreating(modelBuilder);
        }
    }

}
