using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.ObjectValue;

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
    }

}
