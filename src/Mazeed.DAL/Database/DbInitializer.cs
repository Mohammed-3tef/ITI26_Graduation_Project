using Mazeed.DAL.Data;
using Mazeed.DAL.Seeders;
using Microsoft.EntityFrameworkCore;

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
            CategorySeeder.Seed(modelBuilder);
            BrandSeeder.Seed(modelBuilder);
            ItemSeeder.Seed(modelBuilder);
            ItemVariantsAndPhotoSeeder.Seed(modelBuilder);
        }
    }
}