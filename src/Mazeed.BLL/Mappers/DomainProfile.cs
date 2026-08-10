using AutoMapper;
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
            CreateMap<RegisterVM, User>().ReverseMap();
            CreateMap<LoginVM, User>().ReverseMap();
            CreateMap<UserVM, User>().ReverseMap()
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender == 'M' ? "Male" : "Female"));
        }
    }
}
