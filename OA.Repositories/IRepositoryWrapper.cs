using OA.Domain.Entities;
using OA.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repositories
{
    public interface IRepositoryWrapper
    {
        public AdminRepository Admins { get; }
        public EmployeeRepository Employees { get; }
        long SaveChanges();
    }
}
