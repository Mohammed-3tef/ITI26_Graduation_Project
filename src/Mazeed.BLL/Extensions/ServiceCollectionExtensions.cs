using Mazeed.BLL.Mappers;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace Mazeed.BLL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();

            // Auto Mapper Configuration
            services.AddAutoMapper(map => map.AddProfile(new DomainProfile()));

            return services;
        }
    }
}
