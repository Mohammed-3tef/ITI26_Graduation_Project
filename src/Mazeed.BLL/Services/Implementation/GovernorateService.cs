using AutoMapper;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class GovernorateService : IGovernorateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GovernorateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GovernorateVM>> GetAllGovernoratesAsync(string culture = "en")
        {
            var governorates = await _unitOfWork.Repository<Governorate>().GetAllAsync();

            return _mapper.Map<IEnumerable<GovernorateVM>>(governorates);
        }

        public async Task<IEnumerable<CityVM>> GetCitiesByGovernorateIdAsync(long governorateId, string culture = "en")
        {
            var cities = await _unitOfWork.Repository<City>()
                .FindAsync(c => c.GovernorateId == governorateId);

            return _mapper.Map<IEnumerable<CityVM>>(cities);
        }
    }
}
