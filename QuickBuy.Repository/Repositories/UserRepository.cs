using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
