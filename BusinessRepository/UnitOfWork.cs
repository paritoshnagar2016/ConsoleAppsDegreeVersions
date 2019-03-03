
using BusinessRepository.EmpRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        AppDbContext _dbContext = null;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEmployeeRepository employeeRepository
        {
            get => new EmployeeRepository(_dbContext);
        }

        public int SaveDbChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
