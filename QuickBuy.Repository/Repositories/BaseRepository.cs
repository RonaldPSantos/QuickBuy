using QuickBuy.Dominio.Contracts;
using QuickBuy.Repository.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly QuickBuyContext QuickBuyContext;
        public BaseRepository(QuickBuyContext quickBuyContext)
        {
            QuickBuyContext = quickBuyContext;
        }

        public void add(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Add(entity);
            QuickBuyContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return QuickBuyContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return QuickBuyContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            QuickBuyContext.Remove(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Update(entity);
            QuickBuyContext.SaveChanges();
        }
        public void Dispose()
        {
            QuickBuyContext.Dispose();
        }

       
    }
}
