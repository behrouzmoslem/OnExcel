using System.Data.Entity;
using System.Linq;

namespace onExcel.DataAccess.MSSql
{
    
    public abstract class BaseRepository<T>:IRepository<T> where T:class
    {
        protected OnExcelContext context;
        protected DbSet<T> set;

        protected BaseRepository(  OnExcelContext context)
        {
            set = context.Set<T>();
            this.context = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            return set;
        }

        public virtual void Add(T entity)
        {
            set.Add(entity);
        }

        public void Remove(T entity)
        {
            set.Remove(entity);
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}