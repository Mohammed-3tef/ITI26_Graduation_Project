using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Seeders
{
    public static class RoleSeeder
    {
        private static readonly List<(string Name, string Stamp)> Roles = new()
        {
            ("Admin", "c7b013f2-9cb0-472d-be16-4ee9f022e380"),
            ("Shopper", "a2f812d1-8be0-412e-ae12-3ee9f011e270")
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            long roleId = 1;

            foreach (var (roleName, stamp) in Roles)
            {
                modelBuilder.Entity<IdentityRole<long>>().HasData(new IdentityRole<long>
                {
                    Id = roleId++,
                    Name = roleName,
                    NormalizedName = roleName.ToUpper(),
                    ConcurrencyStamp = stamp
                });
            }
        }
    }
}
