using System.Collections.Generic;

namespace Lab_2.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(long id);

        IEnumerable<T> GetAll();

        void Create(T entity);

        void Update(long id, T entity);

        void Delete(long id);
    }
}
