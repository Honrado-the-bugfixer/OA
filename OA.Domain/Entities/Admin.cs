using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domain.Entities
{
   public class Admin : BaseEntity
    {
        public ICollection<Employee> Employees { get; set; }
    }
}
