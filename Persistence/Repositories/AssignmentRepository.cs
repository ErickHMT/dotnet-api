using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApi.Domain.Models;
using webApi.Persistence.Contexts;
using webApi.Domain.Repositories;

namespace webApi.Persistence.Repositories {
    public class AssignmentRepository : BaseRepository, IAssignmentRepository {

        public AssignmentRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public async Task<IEnumerable<Assignment>> ListAsync() {
            return await _context.Assignments.ToListAsync();
        }

    }
}
