using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface IItemVariantRepository : IGenericRepository<ItemVariant>
    {
        Task<IEnumerable<ItemVariant>> GetAllWithDetailsAsync();
        Task<ItemVariant?> GetByIdWithDetailsAsync(long id);
    }
}