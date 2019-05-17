using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using webApi.Domain.Models;
using webApi.Resources;

namespace webApi.Mapping {
    public class ModelToDTOProfile : Profile {

        public ModelToDTOProfile() {

            CreateMap<Employee, EmployeeDTO>();
            CreateMap<Assignment, AssignmentDTO>();
        }

    }
}
