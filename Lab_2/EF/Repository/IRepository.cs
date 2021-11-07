using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.EF.Repository
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
