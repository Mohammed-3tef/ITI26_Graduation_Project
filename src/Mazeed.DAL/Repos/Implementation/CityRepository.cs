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

        public async Task<City?> GetByArabicNameAsync(string name)
        {
            return await _context.Set<City>()
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.ArabicName == name);
        }

        public Task<City?> GetByEnglishNameAsync(string name)
        {
            return _context.Set<City>()
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.EnglishName == name);
        }

        public async Task<City?> GetByIdAsync(long id)
        {
            return await _context.Set<City>().AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
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
