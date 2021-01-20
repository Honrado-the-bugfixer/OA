using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repositories.Interfaces
{
   public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesWithSupervisor();
        Employee GetEmployeeWithSupervisor(int id);
    }
}
