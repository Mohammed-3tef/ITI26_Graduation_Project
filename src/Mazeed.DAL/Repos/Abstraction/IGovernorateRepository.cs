using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface IGovernorateRepository : IGenericRepository<Governorate>
    {
        Task<IEnumerable<Governorate>> GetGovernoratesWithCitiesAsync();
    }
}
