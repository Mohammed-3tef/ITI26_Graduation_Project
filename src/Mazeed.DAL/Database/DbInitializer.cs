using Mazeed.DAL.Data;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mazeed.DAL.Database
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(ModelBuilder modelBuilder)
        {
            RoleSeeder.Seed(modelBuilder);
            AdminSeeder.Seed(modelBuilder);

            // Seed geographical data
            ProvinceSeeder.Seed(modelBuilder);
            GovernorateSeeder.Seed(modelBuilder);
            CitySeeder.Seed(modelBuilder);
            CategorySeeder.Seed(modelBuilder);
            BrandSeeder.Seed(modelBuilder);
            ItemSeeder.Seed(modelBuilder);
            ItemVariantsAndPhotoSeeder.Seed(modelBuilder);
        }
    }
}