using QuickBuy.Dominio.Contracts;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository()
        {

        }

        public void add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetAll()
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
