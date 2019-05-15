using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApi.Domain.Models;

namespace webApi.Domain.Repositories
{
    public interface IAssignmentRepository
    {
        Task<IEnumerable<Assignment>> ListAsync();
    }
}
