using Mazeed.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Database
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<long>, long>
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new DbInitializer(builder).Seed();

            // Optional: Custom table name overrides
            builder.Entity<User>(e => e.ToTable("Users"));
            builder.Entity<IdentityRole<long>>(e => e.ToTable("Roles"));
            builder.Entity<IdentityUserRole<long>>(e => e.ToTable("UserRoles"));
            builder.Entity<IdentityUserClaim<long>>(e => e.ToTable("UserClaims"));
            builder.Entity<IdentityRoleClaim<long>>(e => e.ToTable("RoleClaims"));
            builder.Entity<IdentityUserLogin<long>>(e => e.ToTable("UserLogins"));
            builder.Entity<IdentityUserToken<long>>(e => e.ToTable("UserTokens"));
        }
    }
}
