using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Repos.Implementation
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        public ItemRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Item>> GetAllWithDetailsAsync()
        {
            return await _dbSet
                .Include(i => i.ItemCategories).ThenInclude(x=>x.Category)
                .Include(i => i.Brand)
                .Include(i => i.Photos)
                .ToListAsync();
        }

        public async Task<Item?> GetByIdWithDetailsAsync(long id)
        {
            return await _dbSet
                .Include(i => i.ItemCategories).ThenInclude(x => x.Category)
                .Include(i => i.Brand)
                .FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}