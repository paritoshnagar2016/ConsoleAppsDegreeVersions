using BusinessRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRepository.EmpRepository
{
    public interface IEmployeeRepository : IReporsitory<EmployeeModel>
    {
        EmployeeModel GetEmployeeById(int empId);

    }
}
