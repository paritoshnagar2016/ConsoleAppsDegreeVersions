
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BusinessRepository
{
    public abstract class RepositoryBase<T> : IReporsitory<T> where T:class
    {
        AppDbContext _dbContext = null;
        protected DbSet<T> _dbSet = null;
        public RepositoryBase(AppDbContext dbContext)
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
            return _dbSet.ToList<T>();
        }    
        
    }
}
