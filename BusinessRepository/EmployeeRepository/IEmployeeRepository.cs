using BusinessRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntity.EmployeeRepository
{
    public interface IEmployeeRepository : IReporsitory<EmployeeModel>
    {
        EmployeeModel GetEmployeeById(int empId);

    }
}
