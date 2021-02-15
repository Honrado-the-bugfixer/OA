using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domain.DTOs
{
    public class AdminResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public ICollection<EmployeeResponse> Employees { get; set; }
    }
}
