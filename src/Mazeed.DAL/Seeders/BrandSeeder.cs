using System;
using Microsoft.EntityFrameworkCore;
using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Seeders
{
    public static class BrandSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                // 📱 Electronics & Home Appliances Brands (IDs: 1 - 7)
                new Brand
                {
                    Id = 1,
                    Name = "Apple",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/f/fa/Apple_logo_black.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 2,
                    Name = "Samsung",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/2/24/Samsung_Logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 3,
                    Name = "Sony",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/c/ca/Sony_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 4,
                    Name = "Dell",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/1/18/Dell_logo_2016.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 5,
                    Name = "Lenovo",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/b/bb/Lenovo_logo_2015.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 6,
                    Name = "LG",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/b/bf/LG_logo_%282015%29.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 7,
                    Name = "Sharp",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/6/69/Sharp_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },

                // 👗 Fashion Brands (IDs: 8 - 14)
                new Brand
                {
                    Id = 8,
                    Name = "Zara",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/f/fd/Zara_Logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 9,
                    Name = "H&M",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/5/53/H%26M-Logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 10,
                    Name = "Nike",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/a/a6/Logo_NIKE.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 11,
                    Name = "Adidas",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/2/20/Adidas_Logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 12,
                    Name = "Puma",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/8/88/Puma_complete_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 13,
                    Name = "Tommy Hilfiger",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/2/25/Tommy_Hilfiger_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 14,
                    Name = "Calvin Klein",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/e/e2/Calvin_klein_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },

                // ⚽ Sports Brands (IDs: 15 - 21)
                new Brand
                {
                    Id = 15,
                    Name = "Under Armour",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/4/44/Under_armour_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 16,
                    Name = "Reebok",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/5/53/Reebok_2019_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 17,
                    Name = "Decathlon",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/0/08/Decathlon_Logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 18,
                    Name = "New Balance",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/e/ea/New_Balance_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 19,
                    Name = "Columbia",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/c/c2/Columbia_Sportswear_Logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 20,
                    Name = "Skechers",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/4/4e/Skechers_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 21,
                    Name = "Asics",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/b/b1/Asics_Logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },

                // 💄 Beauty Brands (IDs: 22 - 28)
                new Brand
                {
                    Id = 22,
                    Name = "L'Oréal Paris",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/9/9d/L%27Or%C3%A9al_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 23,
                    Name = "Maybelline",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/a/a3/Maybelline_Logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 24,
                    Name = "CeraVe",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/8/8e/CeraVe_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 25,
                    Name = "MAC Cosmetics",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/0/00/MAC_Cosmetics_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 26,
                    Name = "Nivea",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/c/c5/Nivea_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 27,
                    Name = "The Ordinary",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/8/84/The_Ordinary_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 28,
                    Name = "Vichy",
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Vichy_Laboratoires_logo.svg",
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "System Seeder",
                    IsDeleted = false
                }
            );
        }
    }
}