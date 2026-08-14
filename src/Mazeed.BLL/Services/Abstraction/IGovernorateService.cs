using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IGovernorateService
    {
        Task<IEnumerable<GovernorateVM>> GetAllGovernoratesAsync(string culture = "en");
        Task<IEnumerable<CityVM>> GetCitiesByGovernorateIdAsync(long governorateId, string culture = "en");
    }
}
