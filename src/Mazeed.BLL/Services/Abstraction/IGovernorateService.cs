using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IGovernorateService
    {
        Task<ServiceResponse<IEnumerable<GovernorateVM>>> GetAllGovernoratesAsync(string culture = "en");
        Task<ServiceResponse<IEnumerable<CityVM>>> GetCitiesByGovernorateIdAsync(long governorateId, string culture = "en");
    }
}
