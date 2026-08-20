using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Repos.Implementation
{
    public class ItemVariantRepository : GenericRepository<ItemVariant>, IItemVariantRepository
    {
        public ItemVariantRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ItemVariant>> GetAllWithDetailsAsync()
        {
            return await _dbSet
                .Include(iv => iv.Item)
                .ToListAsync();
        }

        public async Task<ItemVariant?> GetByIdWithDetailsAsync(long id)
        {
            return await _dbSet
                .Include(iv => iv.Item)
                .FirstOrDefaultAsync(iv => iv.Id == id);
        }
    }
}