using Mazeed.DAL.Entities;
using Mazeed.DAL.Seeders;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Database
{
    
    public class AppDbContext : IdentityDbContext<User, IdentityRole<long>, long>
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        #region Tables
        public DbSet<Province> Provinces { get; set; } = null!;
        public DbSet<Governorate> Governorates { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<ItemPhoto> ItemPhotos { get; set; } = null!;
        public DbSet<ItemVariant> ItemVariants { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<Shipment> Shipments { get; set; } = null!;
        public DbSet<DiscountRule> DiscountRules { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;

        public DbSet<ItemCategory> ItemCategories { get; set; } = null!;
        public DbSet<ItemReview> ItemReviews { get; set; } = null!;
        public DbSet<ShopperCart> ShopperCarts { get; set; } = null!;
        public DbSet<ShopperFavorite> ShopperFavorites { get; set; } = null!;
        public DbSet<UserNotification> UserNotifications { get; set; } = null!;
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure Identity configurations are applied
            base.OnModelCreating(modelBuilder);

            #region Identity Custom Table Names (With long Key)
            modelBuilder.Entity<User>(e => e.ToTable("Users"));
            modelBuilder.Entity<IdentityRole<long>>(e => e.ToTable("Roles"));
            modelBuilder.Entity<IdentityUserRole<long>>(e => e.ToTable("UserRoles"));
            modelBuilder.Entity<IdentityUserClaim<long>>(e => e.ToTable("UserClaims"));
            modelBuilder.Entity<IdentityRoleClaim<long>>(e => e.ToTable("RoleClaims"));
            modelBuilder.Entity<IdentityUserLogin<long>>(e => e.ToTable("UserLogins"));
            modelBuilder.Entity<IdentityUserToken<long>>(e => e.ToTable("UserTokens"));
            #endregion

            #region Composite Primary Key
            modelBuilder.Entity<ItemCategory>()
                .HasKey(ic => new { ic.ItemId, ic.CategoryId });

            modelBuilder.Entity<ShopperCart>()
                .HasKey(sc => new { sc.UserId, sc.ItemVariantId });

            modelBuilder.Entity<ShopperFavorite>()
                .HasKey(sf => new { sf.UserId, sf.ItemId });

            modelBuilder.Entity<UserNotification>()
                .HasKey(un => new { un.UserId, un.NotificationId });
            #endregion

            #region Relations & Foreign Keys
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Shopper)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ItemReview>()
                .HasOne(ir => ir.Item)
                .WithMany(i => i.Reviews)
                .HasForeignKey(ir => ir.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ItemReview>()
                .HasOne(ir => ir.Shopper)
                .WithMany(u => u.Reviews)
                .HasForeignKey(ir => ir.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.DiscountRule)
                .WithMany(d => d.Orders)
                .HasForeignKey(o => o.DiscountRuleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.ItemVariant)
                .WithMany(iv => iv.OrderDetails)
                .HasForeignKey(od => od.ItemVariantId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OrderId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Shipment)
                .WithOne(s => s.Order)
                .HasForeignKey<Shipment>(s => s.OrderId);
            #endregion

            // Seed initial data
            DbInitializer.Seed(modelBuilder);
        }
    }
}