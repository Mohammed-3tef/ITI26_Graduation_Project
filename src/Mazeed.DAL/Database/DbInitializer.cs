using Mazeed.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mazeed.DAL.Database
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            // 1. تطبيق الـ Migrations تلقائياً (واللي هتنزل معاها الـ Roles والـ Admin)
            await context.Database.MigrateAsync();

            // 2. زرع الكتالوج (المنتجات والتصنيفات)
            await SeedCatalogAsync(context);
        }

        private static async Task SeedCatalogAsync(AppDbContext context)
        {
            if (await context.Categories.AnyAsync()) return;

            // --- A. Categories ---
            var categoryFashion = new Category { Name = "Fashion", Description = "Apparel and clothing" };
            var categoryElectronics = new Category { Name = "Electronics", Description = "Gadgets and devices" };

            await context.Categories.AddRangeAsync(categoryFashion, categoryElectronics);
            await context.SaveChangesAsync();

            // --- B. Brands ---
            var brandNike = new Brand { Name = "Nike", Logo = "https://example.com/logos/nike.png" };
            var brandAdidas = new Brand { Name = "Adidas", Logo = "https://example.com/logos/adidas.png" };

            await context.Brands.AddRangeAsync(brandNike, brandAdidas);
            await context.SaveChangesAsync();

            // --- C. Items ---
            var itemTshirt = new Item
            {
                Name = "Nike Air Casual T-Shirt",
                Code = "TSHIRT-NK-01",
                Description = "100% Cotton casual t-shirt",
                Price = 450.00m,
                BrandId = (int)brandNike.Id
            };

            await context.Items.AddAsync(itemTshirt);
            await context.SaveChangesAsync();
        }
    }
}