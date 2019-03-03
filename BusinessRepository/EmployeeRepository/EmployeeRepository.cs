using BusinessEntity;
using BusinessEntity.EmployeeRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRepository.EmployeeRepository
{
    public class EmployeeRepository
        : RepositoryBase<EmployeeModel>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public EmployeeModel GetEmployeeById(int empId)
        {
            return _dbSet.Find(empId);
        }
    }
}
