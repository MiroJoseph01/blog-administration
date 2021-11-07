using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.EF.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly BlogContext _dbContext;

        public Repository()
        {
            _dbContext = new BlogContext();
        }

        public void Create(T entity)
        {
            var dataset = _dbContext.Set<T>();
            dataset.Add(entity);

            _dbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            var dataset = _dbContext.Set<T>();
            var entity = dataset.Find(id);
            if (!(entity is null))
            {
                dataset.Remove(entity);
            }

            _dbContext.SaveChanges();
        }

        public virtual T Get(long id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().AsNoTracking().ToList();
        }

        public void Update(long id, T entity)
        {
            var res = _dbContext.Set<T>().Find(id);
            _dbContext.Entry(res).CurrentValues.SetValues(entity);
            _dbContext.SaveChanges();
        }
    }
}
