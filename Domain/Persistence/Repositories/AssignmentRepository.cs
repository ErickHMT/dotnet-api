using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApi.Domain.Models;
using webApi.Domain.Persistence.Contexts;
using webApi.Domain.Repositories;

namespace webApi.Domain.Persistence.Repositories {
    public class AssignmentRepository : BaseRepository, IAssignmentRepository {



        public AssignmentRepository(AppDbContext appDbContext) : base(appDbContext) {

        }

        public async Task<IEnumerable<Assignment>> ListAsync() {
            return await _context.Assignments.ToListAsync();
        }

    }
}
