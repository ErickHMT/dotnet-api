using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApi.Domain.Persistence.Contexts;

namespace webApi.Domain.Persistence.Repositories {
    public abstract class BaseRepository {

        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context) {
            _context = context;
        }

    }
}
