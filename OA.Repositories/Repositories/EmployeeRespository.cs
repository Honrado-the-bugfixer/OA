using Microsoft.EntityFrameworkCore;
using OA.Domain.Entities;
using OA.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA.Repositories.Repositories
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        private readonly DbContext _db;

        public AdminRepository(DbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<Admin> GetAdminWithEmployees()
        {
            return _db.Set<Admin>().Include(e => e.Employees).ToList();
        }

        public Admin GetAdminWithEmployees(int id)
        {
            return _db.Set<Admin>().Include(e => e.Employees).FirstOrDefault(e => e.Id == id);
        }
    }
}
