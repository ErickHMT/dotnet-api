using System.Collections.Generic;
using System.Threading.Tasks;
using webApi.Domain.Models;

namespace webApi.Domain.Services
{
    public interface IAssignmentService
    {
        Task<IEnumerable<Assignment>> ListAsync();
    }
}
