using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Seeders
{
    public static class RoleSeeder
    {
        private static readonly List<string> Roles = new() { "Admin", "User" };

        public static void Seed(ModelBuilder modelBuilder)
        {
            var roleId = 1;
            foreach (var role in Roles)
            {
                modelBuilder.Entity<IdentityRole<long>>().HasData(new IdentityRole<long>
                {
                    Id = roleId++,
                    Name = role,
                    NormalizedName = role.ToUpper()
                });
            }
        }
    }
}
