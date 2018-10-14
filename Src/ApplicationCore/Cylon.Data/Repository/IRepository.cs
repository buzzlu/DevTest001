using System.Collections.Generic;

namespace Cylon.Core.Repository
{
    public interface IRepository<T> where T : Cylon.Data.BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
