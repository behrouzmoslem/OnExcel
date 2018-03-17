using System.Linq;

namespace onExcel.DataAccess
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}