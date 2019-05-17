using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Resources {
    public class AssignmentDTO {

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Prediction { get; set; }

        public int EmployeeId { get; set; }

    }
}
