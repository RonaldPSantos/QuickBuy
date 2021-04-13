using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
