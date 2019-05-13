using System.Collections.Generic;
using System.Threading.Tasks;
using webApi.Models;

namespace webApi.Services
{
    public interface IAssignmentService
    {
        Task<IEnumerable<Assignment>> ListAsync();
    }
}
