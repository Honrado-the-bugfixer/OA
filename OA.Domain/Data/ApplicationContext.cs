using Microsoft.EntityFrameworkCore;
using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domain.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }

}
