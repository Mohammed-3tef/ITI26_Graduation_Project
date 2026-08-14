using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class GovernorateService : IGovernorateService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GovernorateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<GovernorateVM>> GetAllGovernoratesAsync(string culture = "en")
        {
            var governorates = await _unitOfWork.Repository<Governorate>().GetAllAsync();

            return governorates.Select(g => new GovernorateVM
            {
                Id = g.Id,
                ArabicName = g.ArabicName,
                EnglishName = g.EnglishName
            });
        }

        public async Task<IEnumerable<CityVM>> GetCitiesByGovernorateIdAsync(long governorateId, string culture = "en")
        {
            // استخدام الـ FindAsync المتاحة في IGenericRepository مع شرط التصفية
            var cities = await _unitOfWork.Repository<City>()
                .FindAsync(c => c.GovernorateId == governorateId);

            return cities.Select(c => new CityVM
            {
                Id = c.Id,
                ArabicName = c.ArabicName,
                EnglishName = c.EnglishName
            });
        }
    }
}
