using Mazeed.DAL.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mazeed.DAL.Database
{
    public static class DbInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            RoleSeeder.Seed(modelBuilder);
            AdminSeeder.Seed(modelBuilder);

            // Seed geographical data
            ProvinceSeeder.Seed(modelBuilder);
            GovernorateSeeder.Seed(modelBuilder);
            CitySeeder.Seed(modelBuilder);
        }
    }
}