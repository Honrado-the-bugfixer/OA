using Microsoft.EntityFrameworkCore;
using OA.Domain.Data;
using OA.Domain.Entities;
using OA.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OA.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ApplicationContext _context;


        private AdminRepository _admins;
        private EmployeeRepository _employees;

        public RepositoryWrapper(ApplicationContext context)
        {
            _context = context;
        }
        public AdminRepository Admins
        {
            get
            {
                if (_admins == null)
                {
                    _admins = new AdminRepository(_context);
                }
                return _admins;
            }
        }
        public EmployeeRepository Employees
        {
            get
            {
                if (_employees == null)
                {
                    _employees = new EmployeeRepository(_context);
                }
                return _employees;
            }
        }


        public long SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
