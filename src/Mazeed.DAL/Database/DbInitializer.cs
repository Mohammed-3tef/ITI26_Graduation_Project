using Mazeed.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mazeed.DAL.Database
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            // Resolve services from Dependency Injection container
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser<int>>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();

            // 1. Ensure Database is created and migrations are applied
            await context.Database.MigrateAsync();

            // 2. Seed Roles and Admin User
            await SeedIdentityAsync(userManager, roleManager, context);

            // 3. Seed Catalog Data (Brands, Categories, Items, Variants)
            await SeedCatalogAsync(context);
        }

        private static async Task SeedIdentityAsync(
            UserManager<IdentityUser<int>> userManager,
            RoleManager<IdentityRole<int>> roleManager,
            AppDbContext context)
        {
            // Seed Roles
            string[] roles = { "Admin", "Shopper" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole<int> { Name = role });
                }
            }

            // Seed Initial Admin
            var adminEmail = "admin@mazeed.com";
            var existingAdmin = await userManager.FindByEmailAsync(adminEmail);

            if (existingAdmin == null)
            {
                var adminUser = new Admin
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    FirstName = "System",
                    LastName = "Admin",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(adminUser, "Admin@123456");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }

        private static async Task SeedCatalogAsync(AppDbContext context)
        {
            // Check if Categories already exist to prevent duplicate seeding
            if (await context.Categories.AnyAsync()) return;

            // --- A. Seed Categories ---
            var categoryFashion = new Category { Name = "Fashion", Description = "Apparel, clothing, and footwear" };
            var categoryElectronics = new Category { Name = "Electronics", Description = "Gadgets and devices" };

            await context.Categories.AddRangeAsync(categoryFashion, categoryElectronics);
            await context.SaveChangesAsync();

            // --- B. Seed Brands ---
            var brandNike = new Brand { Name = "Nike", Logo = "https://example.com/logos/nike.png" };
            var brandAdidas = new Brand { Name = "Adidas", Logo = "https://example.com/logos/adidas.png" };

            await context.Brands.AddRangeAsync(brandNike, brandAdidas);
            await context.SaveChangesAsync();

            // --- C. Seed Items & ItemVariants ---
            var itemTshirt = new Item
            {
                Name = "Nike Air Casual T-Shirt",
                Code = "TSHIRT-NK-01",
                Description = "100% Cotton breathable casual t-shirt",
                Price = 450.00m,
                BrandId = brandNike.Id,
                Photos = new List<ItemPhoto>
                {
                    new ItemPhoto { PhotoUrl = "https://example.com/photos/nike-tshirt-1.jpg" }
                },
                Variants = new List<ItemVariant>
                {
                    new ItemVariant { SKU = "NK-TS-BLK-M", Color = "Black", Size = "M", StockQuantity = 25, PriceAdjustment = 0 },
                    new ItemVariant { SKU = "NK-TS-BLK-L", Color = "Black", Size = "L", StockQuantity = 15, PriceAdjustment = 0 },
                    new ItemVariant { SKU = "NK-TS-RED-M", Color = "Red", Size = "M", StockQuantity = 10, PriceAdjustment = 20.00m }
                }
            };

            var itemShoes = new Item
            {
                Name = "Adidas Ultraboost Running Shoes",
                Code = "SHOE-AD-01",
                Description = "High performance running sneakers",
                Price = 2200.00m,
                BrandId = brandAdidas.Id,
                Photos = new List<ItemPhoto>
                {
                    new ItemPhoto { PhotoUrl = "https://example.com/photos/adidas-shoes-1.jpg" }
                },
                Variants = new List<ItemVariant>
                {
                    new ItemVariant { SKU = "AD-UB-WHT-42", Color = "White", Size = "42", StockQuantity = 8, PriceAdjustment = 0 },
                    new ItemVariant { SKU = "AD-UB-WHT-43", Color = "White", Size = "43", StockQuantity = 5, PriceAdjustment = 0 }
                }
            };

            await context.Items.AddRangeAsync(itemTshirt, itemShoes);
            await context.SaveChangesAsync();

            // --- D. Seed ItemCategories (Join Table) ---
            var itemCategories = new List<ItemCategory>
            {
                new ItemCategory { ItemId = itemTshirt.Id, CategoryId = categoryFashion.Id },
                new ItemCategory { ItemId = itemShoes.Id, CategoryId = categoryFashion.Id }
            };

            await context.ItemCategories.AddRangeAsync(itemCategories);
            await context.SaveChangesAsync();
        }
    }
}