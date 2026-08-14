using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Repos.Implementation
{
    public class GovernorateRepository : GenericRepository<Governorate>, IGovernorateRepository
    {
        private readonly AppDbContext _context;

        public GovernorateRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Governorate>> GetGovernoratesWithCitiesAsync()
        {
            return await _context.Set<Governorate>().AsNoTracking().ToListAsync();
        }
    }
}
