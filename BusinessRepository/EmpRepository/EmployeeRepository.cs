using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Linq;

namespace BusinessRepository.EmpRepository
{
    public class EmployeeRepository
        : RepositoryBase<EmployeeModel>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
        public EmployeeModel GetEmployeeById(int empId)
        {
            return _dbSet.Where(x => x.EmpId == empId).FirstOrDefault();
        }
    }
}
