using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface ICityRepository : IGenericRepository<City>
    {
        Task<IEnumerable<City>> GetCitiesWithGovernoratesAsync();
        Task<City?> GetByIdAsync(long id);
        Task<City?> GetByEnglishNameAsync(string name);
        Task<City?> GetByArabicNameAsync(string name);
    }
}
