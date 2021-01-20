using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repositories.Interfaces
{
   public interface IAdminRepository : IRepository<Admin>
    {
        IEnumerable<Admin> GetAdminWithEmployees();
        Admin GetAdminWithEmployees(int id);
    }
}
