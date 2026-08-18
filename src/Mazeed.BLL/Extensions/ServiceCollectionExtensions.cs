using Mazeed.BLL.Mappers;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.Services.Implementation;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using Mazeed.DAL.Repos.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mazeed.BLL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IGovernorateRepository, GovernorateRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IWishlistRepository, WishlistRepository>();
            services.AddScoped<IDiscountRuleRepository, DiscountRuleRepository>();

            services.AddScoped<IGovernorateService, GovernorateService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IWishlistService, WishlistService>();
            services.AddScoped<IDiscountService, DiscountService>();

            // Auto Mapper Configuration
            services.AddAutoMapper(map => map.AddProfile(new DomainProfile()));

            // Bind EmailSettings from appsettings.json
            services.AddTransient<IEmailService, EmailService>();
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            // Configure Google OAuth
            services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = configuration["Authentication:Google:ClientId"]!;
                options.ClientSecret = configuration["Authentication:Google:ClientSecret"]!;
            });

            return services;
        }
    }
}
