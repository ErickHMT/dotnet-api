using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Domain.Models
{
    public class Employee
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public EDepartment Department { get; set; }
        public IList<Assignment> Assignments { get; set; } = new List<Assignment>();

    }
}
