using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domain.Entities
{
   public class BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
