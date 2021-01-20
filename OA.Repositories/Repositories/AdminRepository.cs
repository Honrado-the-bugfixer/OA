using Microsoft.EntityFrameworkCore;
using OA.Domain.Entities;
using OA.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA.Repositories.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly DbContext _db;

        public EmployeeRepository(DbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<Employee> GetEmployeesWithSupervisor()
        {
            return _db.Set<Employee>().Include(e => e.Supervisor).ToList();
        }

        public Employee GetEmployeeWithSupervisor(int id)
        {
            return _db.Set<Employee>().Include(e => e.Supervisor).FirstOrDefault(e => e.Id == id);
        }
    }
}
