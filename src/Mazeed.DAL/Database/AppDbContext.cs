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

      

        //Region Join Tables & Feature DbSets

        public DbSet<ItemCategory> ItemCategories { get; set; } = null!;
        public DbSet<ItemReview> ItemReviews { get; set; } = null!;
        public DbSet<ShopperCart> ShopperCarts { get; set; } = null!;
        public DbSet<ShopperFavorite> ShopperFavorites { get; set; } = null!;
        public DbSet<ShopperNotification> ShopperNotifications { get; set; } = null!;
        public DbSet<AdminNotification> AdminNotifications { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Essential to ensure ASP.NET Core Identity schema configuration is properly loaded
            base.OnModelCreating(modelBuilder);

            #region Composite Keys Configuration (Pure Join Tables)

            // 1. ItemCategory (M:N join table between Item and Category)
            modelBuilder.Entity<ItemCategory>()
                .HasKey(ic => new { ic.ItemId, ic.CategoryId });

            // 2. ShopperCart (M:N join table between Shopper and ItemVariant)
            modelBuilder.Entity<ShopperCart>()
                .HasKey(sc => new { sc.ShopperId, sc.ItemVariantId });

            // 3. ShopperFavorite (M:N join table between Shopper and Item)
            modelBuilder.Entity<ShopperFavorite>()
                .HasKey(sf => new { sf.ShopperId, sf.ItemId });

            // 4. ShopperNotification (M:N join table between Shopper and Notification)
            modelBuilder.Entity<ShopperNotification>()
                .HasKey(sn => new { sn.ShopperId, sn.NotificationId });

            // 5. AdminNotification (M:N join table between Admin and Notification)
            modelBuilder.Entity<AdminNotification>()
                .HasKey(an => new { an.AdminId, an.NotificationId });


            // Prevents multiple cascade paths in SQL Server and protects historic order records
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Shopper)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.ShopperId)
                .OnDelete(DeleteBehavior.Restrict);

            // Deleting an Order automatically cleans up its child OrderDetails
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Restricts deletion of Items/Shoppers if associated product reviews exist
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

            // Restricts deletion of Discount Rules that have been applied to past Orders
            modelBuilder.Entity<Order>()
                .HasOne(o => o.DiscountRule)
                .WithMany(d => d.Orders)
                .HasForeignKey(o => o.DiscountRuleId)
                .OnDelete(DeleteBehavior.Restrict);

            // Restricts deletion of ItemVariants linked to historical OrderDetails
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.ItemVariant)
                .WithMany(iv => iv.OrderDetails)
                .HasForeignKey(od => od.ItemVariantId)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion
        }
    }
    }