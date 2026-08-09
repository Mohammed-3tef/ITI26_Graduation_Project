using Mazeed.BLL.Mappers;

namespace Mazeed.PL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            //services.AddScoped<IEmployeeService, EmployeeService>();

            // Auto Mapper Configuration
            services.AddAutoMapper(map => map.AddProfile(new DomainProfile()));

            return services;
        }
    }
}
