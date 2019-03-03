using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntity
{
    public abstract class RepositoryBase<T> : IReporsitory<T> where T:class
    {
        DbContext _dbContext = null;
        protected DbSet<T> _dbSet = null;
        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public void Add(T obj)
        {
            _dbSet.Add(obj);
        }

        public void Delete(T obj)
        {
            _dbSet.Remove(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToListAsync().Result;
        }    
        
    }
}
