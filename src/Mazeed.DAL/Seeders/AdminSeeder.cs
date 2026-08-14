using Mazeed.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Seeders
{
    public static class AdminSeeder
    {
        public const string USERNAME = "system_admin";
        public const string ADMIN_EMAIL = "admin@mazeed.com";
        public const string PASSWORD = "Admin@123";
        public const string PHONENUMBER = "01234567890";

        public static void Seed(ModelBuilder modelBuilder)
        {
            // 1. Admin User Creation
            var adminUser = new User
            {
                Id = 1,
                FirstName = "System",
                LastName = "Admin",
                UserName = USERNAME,
                NormalizedUserName = USERNAME.ToUpper(),
                Email = ADMIN_EMAIL,
                NormalizedEmail = ADMIN_EMAIL.ToUpper(),
                EmailConfirmed = true,
                PhoneNumber = PHONENUMBER,
                PhoneNumberConfirmed = true,
                SecurityStamp = "d8d3f1a0-5b12-4211-92ab-123456789abc",
                ConcurrencyStamp = "e9e4f2b1-6c23-5322-a3bc-987654321def",
                CreatedBy = "SystemSeeder",
                CreatedAt = DateTime.UtcNow
                // IsDeleted = false 
            };

            // 2. Password Hashing
            var passwordHasher = new PasswordHasher<User>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, PASSWORD);

            // 3. Adding the Admin User to the ModelBuilder
            modelBuilder.Entity<User>().HasData(adminUser);

            // 4. Role Creation
            modelBuilder.Entity<IdentityUserRole<long>>().HasData(
                new IdentityUserRole<long> { UserId = 1, RoleId = 1 }
            );
        }
    }
}