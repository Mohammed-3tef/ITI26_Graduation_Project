using Mazeed.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Database
{
    public class AppDbContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        #region Domain DbSets
        public DbSet<Shopper> Shoppers { get; set; } = null!;
        public DbSet<Admin> Admins { get; set; } = null!;
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
        #endregion

        #region Join Tables & Feature DbSets
        public DbSet<ItemCategory> ItemCategories { get; set; } = null!;
        public DbSet<ItemReview> ItemReviews { get; set; } = null!;
        public DbSet<ShopperCart> ShopperCarts { get; set; } = null!;
        public DbSet<ShopperFavorite> ShopperFavorites { get; set; } = null!;
        public DbSet<ShopperNotification> ShopperNotifications { get; set; } = null!;
        public DbSet<AdminNotification> AdminNotifications { get; set; } = null!;
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Essential for Identity schema configuration
            base.OnModelCreating(modelBuilder);

            #region Identity Custom Table Names (From Develop)
            modelBuilder.Entity<IdentityUser<int>>(e => e.ToTable("Users"));
            modelBuilder.Entity<IdentityRole<int>>(e => e.ToTable("Roles"));
            modelBuilder.Entity<IdentityUserRole<int>>(e => e.ToTable("UserRoles"));
            modelBuilder.Entity<IdentityUserClaim<int>>(e => e.ToTable("UserClaims"));
            modelBuilder.Entity<IdentityRoleClaim<int>>(e => e.ToTable("RoleClaims"));
            modelBuilder.Entity<IdentityUserLogin<int>>(e => e.ToTable("UserLogins"));
            modelBuilder.Entity<IdentityUserToken<int>>(e => e.ToTable("UserTokens"));
            #endregion

            #region Composite Keys Configuration (Pure Join Tables)
            modelBuilder.Entity<ItemCategory>()
                .HasKey(ic => new { ic.ItemId, ic.CategoryId });

            modelBuilder.Entity<ShopperCart>()
                .HasKey(sc => new { sc.ShopperId, sc.ItemVariantId });

            modelBuilder.Entity<ShopperFavorite>()
                .HasKey(sf => new { sf.ShopperId, sf.ItemId });

            modelBuilder.Entity<ShopperNotification>()
                .HasKey(sn => new { sn.ShopperId, sn.NotificationId });

            modelBuilder.Entity<AdminNotification>()
                .HasKey(an => new { an.AdminId, an.NotificationId });
            #endregion

            #region Relationships & Delete Behaviors
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Shopper)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.ShopperId)
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
                .WithMany(s => s.Reviews)
                .HasForeignKey(ir => ir.ShopperId)
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
            #endregion
        }
    }
}