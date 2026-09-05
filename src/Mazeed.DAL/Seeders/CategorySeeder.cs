using System;
using Microsoft.EntityFrameworkCore;
using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Seeders
{
    public static class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1, // HasData بيحتاج explicit ID
                    Name = "Electronics",
                    Description = "Laptops, Smartphones, Headphones, and Tech Accessories",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "SystemSeeder",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 2,
                    Name = "Fashion",
                    Description = "Men, Women, and Kids Clothing, Shoes, and Accessories",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "SystemSeeder",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 3,
                    Name = "Sports",
                    Description = "Sportswear, Gym Equipment, Footwear, and Outdoor Gear",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "SystemSeeder",
                    IsDeleted = false
                },
                new Category
                {
                    Id = 4,
                    Name = "Beauty",
                    Description = "Skincare, Makeup, Haircare, and Fragrances",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "SystemSeeder",
                    IsDeleted = false
                }
            );
        }
    }
}