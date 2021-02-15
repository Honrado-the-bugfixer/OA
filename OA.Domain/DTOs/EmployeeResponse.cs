using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domain.DTOs
{
    public class EmployeeResponse
    {
        public int SupervisorId { get; set; }
        public AdminResponse Supervisor { get; set; }
        public string Salary { get; set; }
    }
}
