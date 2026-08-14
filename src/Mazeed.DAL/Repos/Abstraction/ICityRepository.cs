using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface ICityRepository : IGenericRepository<City>
    {
        Task<IEnumerable<City>> GetCitiesWithGovernoratesAsync();
    }
}
