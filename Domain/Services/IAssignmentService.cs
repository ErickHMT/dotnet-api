using System.Collections.Generic;
using System.Threading.Tasks;
using webApi.Domain.Models;
using webApi.Domain.Services.Communication;

namespace webApi.Domain.Services
{
    public interface IAssignmentService
    {

        Task<IEnumerable<Assignment>> ListAsync();
        Task<SaveResponse<Assignment>> SaveAsync(Assignment assignment);
    }
}
