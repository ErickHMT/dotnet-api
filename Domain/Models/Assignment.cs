using System;

namespace webApi.Domain.Models
{

    public class Assignment{
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Prediction { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
