using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA.Domain.Entities
{
   public  class Employee : BaseEntity
    {
        [ForeignKey("Admin")]
        public int SupervisorId { get; set; }
        public Admin Supervisor { get; set; }
        public string Salary { get; set; }
    }
}
