using AutoMapper;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.User;
using Mazeed.DAL.Entities;

namespace Mazeed.BLL.Mappers
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            // Add your mapping configurations here
            // Example:
            CreateMap<ProvinceVM, Province>().ReverseMap();
            CreateMap<GovernorateVM, Governorate>().ReverseMap();
            CreateMap<CityVM, City>().ReverseMap();

            CreateMap<RegisterVM, User>()
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src =>
                    !string.IsNullOrEmpty(src.Gender)
                        ? (src.Gender.StartsWith("M", StringComparison.OrdinalIgnoreCase) ? 'M' : 'F')
                        : (char?)null
                ));

            CreateMap<User, RegisterVM>()
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src =>
                    src.Gender == 'M' ? "Male" : (src.Gender == 'F' ? "Female" : null)
                ));

            CreateMap<LoginVM, User>().ReverseMap();

            CreateMap<UserVM, User>().ReverseMap()
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender == 'M' ? "Male" : "Female"));
        }
    }
}
