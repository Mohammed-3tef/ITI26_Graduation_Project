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
            CreateMap<ProvinceVM, Province>().ReverseMap();
            CreateMap<GovernorateVM, Governorate>().ReverseMap();
            CreateMap<CityVM, City>().ReverseMap();

            // Register Mappings
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

            // User -> UserVM Mapping
            CreateMap<User, UserVM>()
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src =>
                    src.Gender == 'M' ? "Male" : (src.Gender == 'F' ? "Female" : null)))
                .ForMember(dest => dest.Governorate, opt => opt.MapFrom(src =>
                    src.City != null && src.City.Governorate != null
                        ? src.City.Governorate.Id.ToString()
                        : string.Empty))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src =>
                    src.City != null ? src.City.Id.ToString() : string.Empty))
                // Prevent mapping byte[] to IFormFile & map byte[] to ExistingImage
                .ForMember(dest => dest.ProfileImage, opt => opt.Ignore())
                .ForMember(dest => dest.ExistingImage, opt => opt.MapFrom(src => src.ProfileImage));

            // UserVM -> User Mapping
            CreateMap<UserVM, User>()
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src =>
                    !string.IsNullOrEmpty(src.Gender)
                        ? (src.Gender.StartsWith("M", StringComparison.OrdinalIgnoreCase) ? 'M' : 'F')
                        : (char?)null))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => ParseNullableLong(src.City)))
                .ForMember(dest => dest.City, opt => opt.Ignore())
                // Ignore updating byte[] image via AutoMapper (handled in UserService)
                .ForMember(dest => dest.ProfileImage, opt => opt.Ignore());
        }

        private static long? ParseNullableLong(string? value)
        {
            return long.TryParse(value, out var result) ? result : null;
        }
    }
}