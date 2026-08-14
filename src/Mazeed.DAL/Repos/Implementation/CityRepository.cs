using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Repos.Implementation
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private readonly AppDbContext _context;

        public CityRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetCitiesWithGovernoratesAsync()
        {
            return await _context.Set<City>()
                .Include(c => c.Governorate)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
