using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        Task<IEnumerable<Item>> GetAllWithDetailsAsync();
        Task<Item?> GetByIdWithDetailsAsync(long id);
    }
}