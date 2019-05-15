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
        public EDepartment UnitOfMeasurement { get; set; }
        public IList<Task> Tasks { get; set; } = new List<Task>();

    }
}
