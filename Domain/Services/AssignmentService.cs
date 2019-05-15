using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApi.Domain.Models;
using webApi.Domain.Repositories;

namespace webApi.Domain.Services
{
    public class AssignmentService : IAssignmentService
    {
        IAssignmentRepository _assignmentRepository;

        public AssignmentService(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public async Task<IEnumerable<Assignment>> ListAsync()
        {
            return await _assignmentRepository.ListAsync();
        }
    }
}
