using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedingOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Logo", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/f/fa/Apple_logo_black.svg", "Apple", null, null },
                    { 2L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/2/24/Samsung_Logo.svg", "Samsung", null, null },
                    { 3L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/c/ca/Sony_logo.svg", "Sony", null, null },
                    { 4L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/1/18/Dell_logo_2016.svg", "Dell", null, null },
                    { 5L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/b/bb/Lenovo_logo_2015.svg", "Lenovo", null, null },
                    { 6L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/b/bf/LG_logo_%282015%29.svg", "LG", null, null },
                    { 7L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/6/69/Sharp_logo.svg", "Sharp", null, null },
                    { 8L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/f/fd/Zara_Logo.svg", "Zara", null, null },
                    { 9L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/5/53/H%26M-Logo.svg", "H&M", null, null },
                    { 10L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/a/a6/Logo_NIKE.svg", "Nike", null, null },
                    { 11L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/2/20/Adidas_Logo.svg", "Adidas", null, null },
                    { 12L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/8/88/Puma_complete_logo.svg", "Puma", null, null },
                    { 13L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/2/25/Tommy_Hilfiger_logo.svg", "Tommy Hilfiger", null, null },
                    { 14L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/e/e2/Calvin_klein_logo.svg", "Calvin Klein", null, null },
                    { 15L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/4/44/Under_armour_logo.svg", "Under Armour", null, null },
                    { 16L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/5/53/Reebok_2019_logo.svg", "Reebok", null, null },
                    { 17L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/0/08/Decathlon_Logo.svg", "Decathlon", null, null },
                    { 18L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/e/ea/New_Balance_logo.svg", "New Balance", null, null },
                    { 19L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/c/c2/Columbia_Sportswear_Logo.svg", "Columbia", null, null },
                    { 20L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/4/4e/Skechers_logo.svg", "Skechers", null, null },
                    { 21L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/b/b1/Asics_Logo.svg", "Asics", null, null },
                    { 22L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/9/9d/L%27Or%C3%A9al_logo.svg", "L'Oréal Paris", null, null },
                    { 23L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/a/a3/Maybelline_Logo.svg", "Maybelline", null, null },
                    { 24L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/8/8e/CeraVe_logo.svg", "CeraVe", null, null },
                    { 25L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/0/00/MAC_Cosmetics_logo.svg", "MAC Cosmetics", null, null },
                    { 26L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/c/c5/Nivea_logo.svg", "Nivea", null, null },
                    { 27L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/8/84/The_Ordinary_logo.svg", "The Ordinary", null, null },
                    { 28L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, false, "https://upload.wikimedia.org/wikipedia/commons/0/0d/Vichy_Laboratoires_logo.svg", "Vichy", null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, "Laptops, Smartphones, Headphones, and Tech Accessories", false, "Electronics", null, null },
                    { 2L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, "Men, Women, and Kids Clothing, Shoes, and Accessories", false, "Fashion", null, null },
                    { 3L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, "Sportswear, Gym Equipment, Footwear, and Outdoor Gear", false, "Sports", null, null },
                    { 4L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, "Skincare, Makeup, Haircare, and Fragrances", false, "Beauty", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 26, 15, 27, 38, 319, DateTimeKind.Utc).AddTicks(7659), "AQAAAAIAAYagAAAAEL3mhT0I5vGMHAv5S9NyT3ql9xYnIfBn56gqH3M2XSV5fWNNMw1uuS5FePHOo/+cVg==" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "BrandId", "Code", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, 1L, "APL-IP15PM", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Titanium design, A17 Pro chip, 48MP camera", false, "iPhone 15 Pro Max", 65000.00m, null, null },
                    { 2L, 1L, "APL-MBP16", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "M3 Max chip, 36GB Unified Memory, 1TB SSD", false, "MacBook Pro 16\"", 175000.00m, null, null },
                    { 3L, 1L, "APL-IPD129", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Liquid Retina XDR display, M2 chip", false, "iPad Pro 12.9\"", 58000.00m, null, null },
                    { 4L, 1L, "APL-APP2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Active Noise Cancellation, USB-C Charging", false, "AirPods Pro (2nd Gen)", 12500.00m, null, null },
                    { 5L, 1L, "APL-AWU2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Rugged titanium case, Dual-frequency GPS", false, "Apple Watch Ultra 2", 42000.00m, null, null },
                    { 6L, 2L, "SAM-S24U", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Galaxy AI, 200MP Camera, S Pen included", false, "Galaxy S24 Ultra", 62000.00m, null, null },
                    { 7L, 2L, "SAM-ZFOLD5", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Unfold a massive 7.6\" main screen", false, "Galaxy Z Fold 5", 78000.00m, null, null },
                    { 8L, 2L, "SAM-GB4U", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Intel Core Ultra 9, RTX 4070, AMOLED Display", false, "Galaxy Book 4 Ultra", 120000.00m, null, null },
                    { 9L, 2L, "SAM-GW6C", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Rotating bezel, Advanced sleep tracking", false, "Galaxy Watch 6 Classic", 16500.00m, null, null },
                    { 10L, 3L, "SNY-PS5S", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "1TB SSD Storage, DualSense Wireless Controller", false, "PlayStation 5 Slim", 27500.00m, null, null },
                    { 11L, 3L, "SNY-XM5", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Industry-leading noise canceling wireless headphones", false, "WH-1000XM5 Headphones", 18500.00m, null, null },
                    { 12L, 3L, "SNY-XR65", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Cognitive Processor XR, Perfect for PS5", false, "Bravia XR 65\" OLED 4K TV", 95000.00m, null, null },
                    { 13L, 3L, "SNY-A7IV", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "33MP Full-frame sensor, 4K 60p video", false, "Alpha 7 IV Mirrorless Camera", 125000.00m, null, null },
                    { 14L, 4L, "DEL-XPS15", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "OLED Touch Display, Intel Core i9, 32GB RAM", false, "XPS 15 Laptop", 110000.00m, null, null },
                    { 15L, 4L, "DEL-AWM18", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "RTX 4090, 18\" QHD+ 480Hz Display", false, "Alienware m18 Gaming Laptop", 165000.00m, null, null },
                    { 16L, 4L, "DEL-U2723QE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "IPS Black technology, USB-C Hub capability", false, "UltraSharp 27\" 4K Monitor", 29000.00m, null, null },
                    { 17L, 4L, "DEL-INSP16", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Intel Core i7, 16GB RAM, 512GB SSD", false, "Inspiron 16 Laptop", 42500.00m, null, null },
                    { 18L, 5L, "LNV-X1C11", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Ultra-lightweight business laptop, Intel Evo certified", false, "ThinkPad X1 Carbon Gen 11", 82000.00m, null, null },
                    { 19L, 5L, "LNV-LGP7I", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Intel i9 13900HX, RTX 4080, 240Hz Display", false, "Legion Pro 7i Gaming Laptop", 125000.00m, null, null },
                    { 20L, 5L, "LNV-YG9I", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "4K OLED Touchscreen, Bowers & Wilkins Soundbar", false, "Yoga 9i 2-in-1", 70000.00m, null, null },
                    { 21L, 5L, "LNV-TP12P", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "12.6\" AMOLED 120Hz display, Precision Pen 3", false, "Tab P12 Pro", 35000.00m, null, null },
                    { 22L, 6L, "LG-REF26", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Door-in-Door with Craft Ice Maker", false, "InstaView Refrigerator 26 cu.ft", 125000.00m, null, null },
                    { 23L, 6L, "LG-C365", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "α9 AI Processor Gen6, Dolby Vision & Atmos", false, "C3 65\" OLED evo 4K TV", 85000.00m, null, null },
                    { 24L, 6L, "LG-WASH1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Front Load Washer and Electric Dryer with AI DD", false, "WashTower Laundry Hub", 145000.00m, null, null },
                    { 25L, 6L, "LG-34UG", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "OLED 240Hz 0.03ms, G-Sync Compatible", false, "UltraGear 34\" Curved Gaming Monitor", 65000.00m, null, null },
                    { 26L, 7L, "SHP-REF4D", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Plasmacluster Ion Technology, J-Tech Inverter", false, "4-Door French Door Refrigerator", 75000.00m, null, null },
                    { 27L, 7L, "SHP-MW34L", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Stainless Steel, Touch Control, Auto Cook Menus", false, "Microwave Oven with Grill 34L", 8500.00m, null, null },
                    { 28L, 7L, "SHP-AP50", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "HEPA Filter, Coverage up to 40 sqm", false, "Plasmacluster Air Purifier", 16000.00m, null, null },
                    { 29L, 7L, "SHP-AQ55", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Android TV with Google Assistant built-in", false, "AQUOS 55\" 4K UHD Smart TV", 28000.00m, null, null },
                    { 30L, 8L, "ZRA-JKT01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Lapel collar jacket with long sleeves and zip pockets", false, "Oversized Faux Leather Jacket", 4500.00m, null, null },
                    { 31L, 8L, "ZRA-TR01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "High-waist trousers with front pleats and side pockets", false, "Pleated Wide Leg Trousers", 2800.00m, null, null },
                    { 32L, 8L, "ZRA-SHT01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Relaxed fit linen shirt with button-up front", false, "100% Linen Shirt", 3200.00m, null, null },
                    { 33L, 8L, "ZRA-DRS01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "V-neck dress with adjustable thin straps", false, "Satin Effect Midi Dress", 3800.00m, null, null },
                    { 34L, 9L, "HM-HD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Soft sweatshirt fabric hoodie with kangaroo pocket", false, "Relaxed Fit Hoodie", 1600.00m, null, null },
                    { 35L, 9L, "HM-JN01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "5-pocket jeans in washed denim with flexible stretch", false, "Slim Fit Stretch Jeans", 1900.00m, null, null },
                    { 36L, 9L, "HM-TS01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Heavyweight cotton jersey T-shirt with ribbed neck", false, "Oversized Cotton T-Shirt", 900.00m, null, null },
                    { 37L, 9L, "HM-CD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Soft fine-knit cardigan with buttons down the front", false, "Fine-knit Cardigan", 1300.00m, null, null },
                    { 38L, 10L, "NKE-AF1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Classic basketball shoe with durable leather overlays", false, "Air Force 1 '07", 7500.00m, null, null },
                    { 39L, 10L, "NKE-TFWR", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Premium lightweight fleece jacket with full zip", false, "Tech Fleece Windrunner", 8500.00m, null, null },
                    { 40L, 10L, "NKE-JOG01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Brushed-back fleece pants with elastic waistband", false, "Sportswear Club Fleece Joggers", 4000.00m, null, null },
                    { 41L, 10L, "NKE-DNK", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "80s b-ball icon created for the court and adapted for the streets", false, "Dunk Low Retro", 7500.00m, null, null },
                    { 42L, 11L, "ADI-UBL", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Epic energy response with Light BOOST cushioning", false, "Ultraboost Light Shoes", 9000.00m, null, null },
                    { 43L, 11L, "ADI-SMB", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Leather upper with suede overlays and gum rubber sole", false, "Samba OG Shoes", 6500.00m, null, null },
                    { 44L, 11L, "ADI-TRK", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Iconic 3-Stripes track jacket with stand-up collar", false, "Adicolor Classics Track Jacket", 4000.00m, null, null },
                    { 45L, 11L, "ADI-TIRO", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Slim-fit training pants with AEROREADY moisture absorbing", false, "Tiro 23 League Pants", 2800.00m, null, null },
                    { 46L, 12L, "PMA-SUD", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Iconic low-top suede sneakers with rubber outsole", false, "Suede Classic XXI Sneakers", 4500.00m, null, null },
                    { 47L, 12L, "PMA-T7JKT", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Heritage sports style with signature side stripes", false, "T7 Track Jacket", 3800.00m, null, null },
                    { 48L, 12L, "PMA-MB03", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "LaMelo Ball signature shoes with NITRO foam cushioning", false, "MB.03 Basketball Shoes", 6500.00m, null, null },
                    { 49L, 12L, "PMA-HD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Fleece lined pullover hoodie with kangaroo pocket", false, "Essentials Logo Hoodie", 2800.00m, null, null },
                    { 50L, 13L, "TH-POLO", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Pure cotton pique polo with signature embroidered flag", false, "Classic Polo Shirt", 4500.00m, null, null },
                    { 51L, 13L, "TH-SNK", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Low top leather sneaker with subtle flag logo details", false, "Essential Leather Sneaker", 5500.00m, null, null },
                    { 52L, 13L, "TH-JKT", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Packable puffer jacket with recycled down filling", false, "Lightweight Down Jacket", 10000.00m, null, null },
                    { 53L, 13L, "TH-JN01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Classic straight fit denim jeans with dark wash", false, "Denton Straight Fit Jeans", 6000.00m, null, null },
                    { 54L, 14L, "CK-BR01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Unlined cotton stretch bralette with iconic logo band", false, "Modern Cotton Bralette", 1800.00m, null, null },
                    { 55L, 14L, "CK-TS01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "100% Organic cotton t-shirt with front chest logo", false, "Monogram Logo T-Shirt", 2500.00m, null, null },
                    { 56L, 14L, "CK-JN90", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "High rise vintage inspired straight leg jeans", false, "90s Straight Denim Jeans", 5000.00m, null, null },
                    { 57L, 14L, "CK-BX3P", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Classic boxer briefs with supportive fit and elastic waist", false, "3-Pack Cotton Stretch Boxer Briefs", 2800.00m, null, null },
                    { 58L, 15L, "UA-TS20", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Quick-drying ultra-soft fabric with natural feel", false, "UA Tech 2.0 Short Sleeve", 1500.00m, null, null },
                    { 59L, 15L, "UA-CUR11", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "UA Flow dual-density cushioning for high speed traction", false, "Curry 11 Basketball Shoes", 8000.00m, null, null },
                    { 60L, 15L, "UA-BP50", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Water-resistant UA Storm technology with laptop sleeve", false, "Hustle 5.0 Backpack", 3000.00m, null, null },
                    { 61L, 15L, "UA-HGLEG", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Super-light HeatGear fabric delivers superior coverage", false, "HeatGear Armour Compression Leggings", 2000.00m, null, null },
                    { 62L, 16L, "RBK-C85", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Soft garment leather upper with classic tennis look", false, "Club C 85 Vintage Shoes", 4500.00m, null, null },
                    { 63L, 16L, "RBK-NX4", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Lightweight breathability with Lift and Run Chassis", false, "Nano X4 Training Shoes", 7000.00m, null, null },
                    { 64L, 16L, "RBK-TRKP", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Retro style track pants made with recycled materials", false, "Vector Track Pants", 3000.00m, null, null },
                    { 65L, 16L, "RBK-HD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Everyday fleece hoodie with soft cotton blend", false, "Identity Logo Fleece Hoodie", 2800.00m, null, null },
                    { 66L, 17L, "DEC-TNT2S", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Pop-up free-standing tent easy assembly", false, "Quechua 2-Second Camping Tent 3-Person", 6500.00m, null, null },
                    { 67L, 17L, "DEC-DB20", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Cast iron plates with threaded spinlock bars", false, "Domyos Adjustable Dumbbell Set 20kg", 4500.00m, null, null },
                    { 68L, 17L, "DEC-RCS", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Lightweight running shoes for beginners", false, "Kalenji Run Cushion Shoes", 2200.00m, null, null },
                    { 69L, 17L, "DEC-GPSW", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Heart rate monitoring, pace and distance tracking", false, "Kiprun Running GPS Watch", 5500.00m, null, null },
                    { 70L, 18L, "NB-574C", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "EVA foam cushioning with durable suede and mesh upper", false, "574 Core Sneakers", 5500.00m, null, null },
                    { 71L, 18L, "NB-990V6", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "FuelCell foam delivers a propulsive feel with ENCAP midsole", false, "990v6 Made in USA", 11000.00m, null, null },
                    { 72L, 18L, "NB-1080V13", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Max cushioning running shoe with breathable engineered mesh", false, "Fresh Foam X 1080v13", 8500.00m, null, null },
                    { 73L, 18L, "NB-HD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Relaxed fit soft French terry pullover hoodie", false, "Athletics French Terry Hoodie", 3800.00m, null, null },
                    { 74L, 19L, "COL-WT2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Omni-Tech waterproof breathable fully seam sealed jacket", false, "Watertight II Rain Jacket", 5000.00m, null, null },
                    { 75L, 19L, "COL-FLC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Warm 250g MTR filament fleece sweater jacket", false, "Steens Mountain Full Zip Fleece", 2800.00m, null, null },
                    { 76L, 19L, "COL-NTR", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Waterproof leather and suede hiking boots with Techlite midsole", false, "Newton Ridge Plus Hiking Boots", 6500.00m, null, null },
                    { 77L, 19L, "COL-PNT", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Omni-Shade UPF 50 sun protection hiking pants", false, "Silver Ridge Utility Pants", 3500.00m, null, null },
                    { 78L, 20L, "SKC-GW6", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Hands Free Slip-ins with Air-Cooled Goga Mat insole", false, "Go Walk 6 - Slip-Ins", 5000.00m, null, null },
                    { 79L, 20L, "SKC-AF2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Podiatrist-certified arch support walking shoes", false, "Arch Fit 2.0 Sneakers", 5500.00m, null, null },
                    { 80L, 20L, "SKC-UNO", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Classic air-cushioned style with Memory Foam insole", false, "UNO - Stand on Air", 4800.00m, null, null },
                    { 81L, 20L, "SKC-DLT", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Chunky retro style sneakers with flexible traction outsole", false, "D'Lites 4.0 Pro", 4500.00m, null, null },
                    { 82L, 21L, "ASC-GK30", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Advanced stability running shoes with PureGEL technology", false, "GEL-KAYANO 30", 8500.00m, null, null },
                    { 83L, 21L, "ASC-GN26", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Maximum cushioning running shoes with FF BLAST PLUS ECO", false, "GEL-NIMBUS 26", 8500.00m, null, null },
                    { 84L, 21L, "ASC-GT20", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Versatile stability trainer for various distances", false, "GT-2000 12", 7500.00m, null, null },
                    { 85L, 21L, "ASC-GV9", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Rearfoot GEL technology for trail running and outdoor walking", false, "GEL-VENTURE 9 Hiking Shoes", 4500.00m, null, null },
                    { 86L, 22L, "LOR-HA15", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Plumps skin and reduces wrinkles in 1 week", false, "Revitalift 1.5% Pure Hyaluronic Acid Serum", 1400.00m, null, null },
                    { 87L, 22L, "LOR-INF24", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Lightweight breathable liquid foundation transfer-resistant", false, "Infallible 24H Fresh Wear Foundation", 950.00m, null, null },
                    { 88L, 22L, "LOR-ELV400", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Repairs 5 signs of damaged hair with Protein + Ceramides", false, "Elvive Total Repair 5 Shampoo 400ml", 450.00m, null, null },
                    { 89L, 22L, "LOR-LASH", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Voluptuous volume and intense length waterproof mascara", false, "Lash Paradise Mascara Black", 750.00m, null, null },
                    { 90L, 23L, "MAY-SKYH", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Limitless length and full volume washable mascara", false, "Lash Sensational Sky High Mascara", 700.00m, null, null },
                    { 91L, 23L, "MAY-FITM", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Oil-free foundation matches skin tone and texture", false, "Fit Me Matte + Poreless Foundation", 600.00m, null, null },
                    { 92L, 23L, "MAY-SINK", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Up to 16 hours saturated matte color liquid lipstick", false, "SuperStay Matte Ink Liquid Lipstick", 550.00m, null, null },
                    { 93L, 23L, "MAY-ARWC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Multi-use concealer erases dark circles and redness", false, "Instant Age Rewind Eraser Concealer", 600.00m, null, null },
                    { 94L, 24L, "CRV-HFC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "With hyaluronic acid, ceramides, and glycerin for normal to dry skin", false, "Hydrating Facial Cleanser 473ml", 1100.00m, null, null },
                    { 95L, 24L, "CRV-MC454", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Rich non-greasy moisturizing cream with 3 essential ceramides", false, "Moisturizing Cream 454g", 1200.00m, null, null },
                    { 96L, 24L, "CRV-AM30", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Daily oil-free face moisturizer with broad spectrum sunscreen", false, "AM Facial Moisturizing Lotion SPF 30", 1150.00m, null, null },
                    { 97L, 24L, "CRV-RRS", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Reduces appearance of post-acne marks and pores", false, "Resurfacing Retinol Serum 30ml", 1300.00m, null, null },
                    { 98L, 25L, "MAC-RW", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Iconic vivid blue-red matte finish lipstick", false, "Matte Lipstick - Ruby Woo", 1400.00m, null, null },
                    { 99L, 25L, "MAC-SFF", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "24-hour wear buildable coverage matte finish foundation", false, "Studio Fix Fluid SPF 15 Foundation", 2500.00m, null, null },
                    { 100L, 25L, "MAC-FIXP", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Hydrating face mist that sets and refreshes makeup", false, "Prep + Prime Fix+ Setting Spray 100ml", 1800.00m, null, null },
                    { 101L, 25L, "MAC-MSF", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Slow-baked domed face powder with dimensional finish", false, "Mineralize Skinfinish Powder", 2200.00m, null, null },
                    { 102L, 26L, "NIV-CRM150", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Original all-purpose moisturizer for face, body, and hands", false, "Nivea Creme Tin 150ml", 250.00m, null, null },
                    { 103L, 26L, "NIV-NGL350", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Organic avocado oil body lotion for 48h moisture", false, "Naturally Good Body Lotion 350ml", 350.00m, null, null },
                    { 104L, 26L, "NIV-BWRO", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "48h anti-perspirant protection without yellow stains", false, "Black & White Invisible Roll-On 50ml", 180.00m, null, null },
                    { 105L, 26L, "NIV-Q10DC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Firming face moisturizer with pure Q10 and Creatine", false, "Q10 Power Anti-Wrinkle Day Cream SPF 15", 550.00m, null, null },
                    { 106L, 27L, "ORD-NIA10", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "High-strength vitamin and mineral blemish formula", false, "Niacinamide 10% + Zinc 1%", 550.00m, null, null },
                    { 107L, 27L, "ORD-HA2B5", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Hydration support formula with ultra-pure vegan hyaluronic acid", false, "Hyaluronic Acid 2% + B5", 650.00m, null, null },
                    { 108L, 27L, "ORD-PEEL30", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "10-minute exfoliating facial peeling treatment", false, "AHA 30% + BHA 2% Peeling Solution", 700.00m, null, null },
                    { 109L, 27L, "ORD-CAF5", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Reduces appearance of eye contour pigmentation and puffiness", false, "Caffeine Solution 5% + EGCG", 600.00m, null, null },
                    { 110L, 28L, "VCH-M89", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Daily skin fortifying serum for plump and hydrated skin", false, "Minéral 89 Hyaluronic Acid Booster 50ml", 1800.00m, null, null },
                    { 111L, 28L, "VCH-LAVITC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "15% Pure Vitamin C antioxidant serum for bright skin", false, "LiftActiv Vitamin C Serum 20ml", 2200.00m, null, null },
                    { 112L, 28L, "VCH-NORM200", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Purifying gel cleanser enriched with Salicylic Acid for acne-prone skin", false, "Normaderm PhytoSolution Cleansing Gel", 1300.00m, null, null },
                    { 113L, 28L, "VCH-UV50", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Anti-imperfections daily sun protection fluid with Niacinamide", false, "Capital Soleil UV-Clear Fluid SPF 50+", 1600.00m, null, null }
                });

            migrationBuilder.InsertData(
                table: "ItemPhotos",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ItemId", "PhotoUrl", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 1L, "https://images.unsplash.com/photo-1695048133142-1a20484d2569?w=500&auto=format&fit=crop", null, null },
                    { 2L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 2L, "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=500&auto=format&fit=crop", null, null },
                    { 3L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 3L, "https://images.unsplash.com/photo-1544244015-0df4b3ffc6b0?w=500&auto=format&fit=crop", null, null },
                    { 4L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 4L, "https://images.unsplash.com/photo-1600294037681-c80b4cb5b434?w=500&auto=format&fit=crop", null, null },
                    { 5L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 5L, "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?w=500&auto=format&fit=crop", null, null },
                    { 6L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 6L, "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?w=500&auto=format&fit=crop", null, null },
                    { 7L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 7L, "https://images.unsplash.com/photo-1580910051074-3eb694886505?w=500&auto=format&fit=crop", null, null },
                    { 8L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 8L, "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=500&auto=format&fit=crop", null, null },
                    { 9L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 9L, "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=500&auto=format&fit=crop", null, null },
                    { 10L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 10L, "https://images.unsplash.com/photo-1606813907291-d86efa9b94db?w=500&auto=format&fit=crop", null, null },
                    { 11L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 11L, "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&auto=format&fit=crop", null, null },
                    { 12L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 12L, "https://images.unsplash.com/photo-1593784991095-a205069470b6?w=500&auto=format&fit=crop", null, null },
                    { 13L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 13L, "https://images.unsplash.com/photo-1516035069371-29a1b244cc32?w=500&auto=format&fit=crop", null, null },
                    { 14L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 14L, "https://images.unsplash.com/photo-1588872657578-7efd1f1555ed?w=500&auto=format&fit=crop", null, null },
                    { 15L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 15L, "https://images.unsplash.com/photo-1603302576837-37561b2e2302?w=500&auto=format&fit=crop", null, null },
                    { 16L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 16L, "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?w=500&auto=format&fit=crop", null, null },
                    { 17L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 17L, "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?w=500&auto=format&fit=crop", null, null },
                    { 18L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 18L, "https://images.unsplash.com/photo-1611186871348-b1ce696e52c9?w=500&auto=format&fit=crop", null, null },
                    { 19L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 19L, "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?w=500&auto=format&fit=crop", null, null },
                    { 20L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 20L, "https://images.unsplash.com/photo-1531297484001-80022131f5a1?w=500&auto=format&fit=crop", null, null },
                    { 21L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 21L, "https://images.unsplash.com/photo-1561154464-82e9adf32764?w=500&auto=format&fit=crop", null, null },
                    { 22L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 22L, "https://images.unsplash.com/photo-1584622650111-993a426fbf0a?w=500&auto=format&fit=crop", null, null },
                    { 23L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 23L, "https://images.unsplash.com/photo-1461151304267-38535e780c79?w=500&auto=format&fit=crop", null, null },
                    { 24L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 24L, "https://images.unsplash.com/photo-1626806787461-102c1bfaaea1?w=500&auto=format&fit=crop", null, null },
                    { 25L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 25L, "https://images.unsplash.com/photo-1547082299-de196ea013d6?w=500&auto=format&fit=crop", null, null },
                    { 26L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 26L, "https://images.unsplash.com/photo-1571175443880-49e1d25b2bc5?w=500&auto=format&fit=crop", null, null },
                    { 27L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 27L, "https://images.unsplash.com/photo-1574269909862-7e1d70bb8078?w=500&auto=format&fit=crop", null, null },
                    { 28L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 28L, "https://images.unsplash.com/photo-1585771724684-38269d6639fd?w=500&auto=format&fit=crop", null, null },
                    { 29L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 29L, "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?w=500&auto=format&fit=crop", null, null },
                    { 30L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 30L, "https://images.unsplash.com/photo-1551028719-00167b16eac5?w=500&auto=format&fit=crop", null, null },
                    { 31L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 31L, "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=500&auto=format&fit=crop", null, null },
                    { 32L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 32L, "https://images.unsplash.com/photo-1598033129183-c4f50c736f10?w=500&auto=format&fit=crop", null, null },
                    { 33L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 33L, "https://images.unsplash.com/photo-1595777457583-95e059d581b8?w=500&auto=format&fit=crop", null, null },
                    { 34L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 34L, "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", null, null },
                    { 35L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 35L, "https://images.unsplash.com/photo-1541099649105-f69ad21f3246?w=500&auto=format&fit=crop", null, null },
                    { 36L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 36L, "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?w=500&auto=format&fit=crop", null, null },
                    { 37L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 37L, "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=500&auto=format&fit=crop", null, null },
                    { 38L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 38L, "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=500&auto=format&fit=crop", null, null },
                    { 39L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 39L, "https://images.unsplash.com/photo-1544441893-675973e31985?w=500&auto=format&fit=crop", null, null },
                    { 40L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 40L, "https://images.unsplash.com/photo-1552902865-b72c031ac5ea?w=500&auto=format&fit=crop", null, null },
                    { 41L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 41L, "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=500&auto=format&fit=crop", null, null },
                    { 42L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 42L, "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", null, null },
                    { 43L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 43L, "https://images.unsplash.com/photo-1607522370275-f14206abe5d3?w=500&auto=format&fit=crop", null, null },
                    { 44L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 44L, "https://images.unsplash.com/photo-1578587018452-892bacefd3f2?w=500&auto=format&fit=crop", null, null },
                    { 45L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 45L, "https://images.unsplash.com/photo-1515886657613-9f3515b0c78f?w=500&auto=format&fit=crop", null, null },
                    { 46L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 46L, "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=500&auto=format&fit=crop", null, null },
                    { 47L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 47L, "https://images.unsplash.com/photo-1509631179647-0177331693ae?w=500&auto=format&fit=crop", null, null },
                    { 48L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 48L, "https://images.unsplash.com/photo-1579338559194-a162d19bf842?w=500&auto=format&fit=crop", null, null },
                    { 49L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 49L, "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", null, null },
                    { 50L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 50L, "https://images.unsplash.com/photo-1625910513413-5fc40e34c264?w=500&auto=format&fit=crop", null, null },
                    { 51L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 51L, "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=500&auto=format&fit=crop", null, null },
                    { 52L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 52L, "https://images.unsplash.com/photo-1548883354-7622d03aca27?w=500&auto=format&fit=crop", null, null },
                    { 53L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 53L, "https://images.unsplash.com/photo-1542272604-780c36856d61?w=500&auto=format&fit=crop", null, null },
                    { 54L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 54L, "https://images.unsplash.com/photo-1583743814966-8936f5b7be1a?w=500&auto=format&fit=crop", null, null },
                    { 55L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 55L, "https://images.unsplash.com/photo-1503342217505-b0a15ec3261c?w=500&auto=format&fit=crop", null, null },
                    { 56L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 56L, "https://images.unsplash.com/photo-1565084888279-aca607ecce0c?w=500&auto=format&fit=crop", null, null },
                    { 57L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 57L, "https://images.unsplash.com/photo-1583743814966-8936f5b7be1a?w=500&auto=format&fit=crop", null, null },
                    { 58L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 58L, "https://images.unsplash.com/photo-1581655353564-df123a1eb820?w=500&auto=format&fit=crop", null, null },
                    { 59L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 59L, "https://images.unsplash.com/photo-1511556532299-8f662fc26c06?w=500&auto=format&fit=crop", null, null },
                    { 60L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 60L, "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=500&auto=format&fit=crop", null, null },
                    { 61L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 61L, "https://images.unsplash.com/photo-1506629082925-23688b0729fe?w=500&auto=format&fit=crop", null, null },
                    { 62L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 62L, "https://images.unsplash.com/photo-1539185441755-769473a23570?w=500&auto=format&fit=crop", null, null },
                    { 63L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 63L, "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", null, null },
                    { 64L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 64L, "https://images.unsplash.com/photo-1515886657613-9f3515b0c78f?w=500&auto=format&fit=crop", null, null },
                    { 65L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 65L, "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", null, null },
                    { 66L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 66L, "https://images.unsplash.com/photo-1504280390367-361c6d9f38f4?w=500&auto=format&fit=crop", null, null },
                    { 67L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 67L, "https://images.unsplash.com/photo-1583454110551-21f2fa2afe61?w=500&auto=format&fit=crop", null, null },
                    { 68L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 68L, "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=500&auto=format&fit=crop", null, null },
                    { 69L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 69L, "https://images.unsplash.com/photo-1510017803434-a899398421b3?w=500&auto=format&fit=crop", null, null },
                    { 70L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 70L, "https://images.unsplash.com/photo-1539185441755-769473a23570?w=500&auto=format&fit=crop", null, null },
                    { 71L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 71L, "https://images.unsplash.com/photo-1551107696-a4b0c5a0d9a2?w=500&auto=format&fit=crop", null, null },
                    { 72L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 72L, "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", null, null },
                    { 73L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 73L, "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", null, null },
                    { 74L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 74L, "https://images.unsplash.com/photo-1544441893-675973e31985?w=500&auto=format&fit=crop", null, null },
                    { 75L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 75L, "https://images.unsplash.com/photo-1578587018452-892bacefd3f2?w=500&auto=format&fit=crop", null, null },
                    { 76L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 76L, "https://images.unsplash.com/photo-1520639888713-7851133b1ed0?w=500&auto=format&fit=crop", null, null },
                    { 77L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 77L, "https://images.unsplash.com/photo-1517841905240-472988babdf9?w=500&auto=format&fit=crop", null, null },
                    { 78L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 78L, "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=500&auto=format&fit=crop", null, null },
                    { 79L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 79L, "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=500&auto=format&fit=crop", null, null },
                    { 80L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 80L, "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=500&auto=format&fit=crop", null, null },
                    { 81L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 81L, "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=500&auto=format&fit=crop", null, null },
                    { 82L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 82L, "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", null, null },
                    { 83L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 83L, "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=500&auto=format&fit=crop", null, null },
                    { 84L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 84L, "https://images.unsplash.com/photo-1607522370275-f14206abe5d3?w=500&auto=format&fit=crop", null, null },
                    { 85L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 85L, "https://images.unsplash.com/photo-1520639888713-7851133b1ed0?w=500&auto=format&fit=crop", null, null },
                    { 86L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 86L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", null, null },
                    { 87L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 87L, "https://images.unsplash.com/photo-1522337360788-8b13dee7a37e?w=500&auto=format&fit=crop", null, null },
                    { 88L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 88L, "https://images.unsplash.com/photo-1535585209827-a15fcdbc4c2d?w=500&auto=format&fit=crop", null, null },
                    { 89L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 89L, "https://images.unsplash.com/photo-1631214524020-7e18db9a8f9d?w=500&auto=format&fit=crop", null, null },
                    { 90L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 90L, "https://images.unsplash.com/photo-1560700146-7c0137a8b3f2?w=500&auto=format&fit=crop", null, null },
                    { 91L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 91L, "https://images.unsplash.com/photo-1608248597349-f06b6b55dbdf?w=500&auto=format&fit=crop", null, null },
                    { 92L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 92L, "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&auto=format&fit=crop", null, null },
                    { 93L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 93L, "https://images.unsplash.com/photo-1616683693504-3ea7e9ad6fec?w=500&auto=format&fit=crop", null, null },
                    { 94L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 94L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", null, null },
                    { 95L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 95L, "https://images.unsplash.com/photo-1608248597259-be160f25e982?w=500&auto=format&fit=crop", null, null },
                    { 96L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 96L, "https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?w=500&auto=format&fit=crop", null, null },
                    { 97L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 97L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", null, null },
                    { 98L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 98L, "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&auto=format&fit=crop", null, null },
                    { 99L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 99L, "https://images.unsplash.com/photo-1522337360788-8b13dee7a37e?w=500&auto=format&fit=crop", null, null },
                    { 100L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 100L, "https://images.unsplash.com/photo-1616683693504-3ea7e9ad6fec?w=500&auto=format&fit=crop", null, null },
                    { 101L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 101L, "https://images.unsplash.com/photo-1590156206657-19d08e5a73e1?w=500&auto=format&fit=crop", null, null },
                    { 102L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 102L, "https://images.unsplash.com/photo-1608248597259-be160f25e982?w=500&auto=format&fit=crop", null, null },
                    { 103L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 103L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", null, null },
                    { 104L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 104L, "https://images.unsplash.com/photo-1619451334792-150fd785ee74?w=500&auto=format&fit=crop", null, null },
                    { 105L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 105L, "https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?w=500&auto=format&fit=crop", null, null },
                    { 106L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 106L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", null, null },
                    { 107L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 107L, "https://images.unsplash.com/photo-1608248597349-f06b6b55dbdf?w=500&auto=format&fit=crop", null, null },
                    { 108L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 108L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", null, null },
                    { 109L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 109L, "https://images.unsplash.com/photo-1616683693504-3ea7e9ad6fec?w=500&auto=format&fit=crop", null, null },
                    { 110L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 110L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", null, null },
                    { 111L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 111L, "https://images.unsplash.com/photo-1608248597349-f06b6b55dbdf?w=500&auto=format&fit=crop", null, null },
                    { 112L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 112L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", null, null },
                    { 113L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 113L, "https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?w=500&auto=format&fit=crop", null, null }
                });

            migrationBuilder.InsertData(
                table: "ItemVariants",
                columns: new[] { "Id", "Color", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ItemId", "LowStockThreshold", "PriceAdjustment", "SKU", "Size", "StockQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, "Black Titanium", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 1L, 5, 0.00m, "APL-IP15P-128-BLK", "128GB", 35, null, null },
                    { 2L, "Natural Titanium", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 1L, 5, 6000.00m, "APL-IP15P-256-NAT", "256GB", 3, null, null },
                    { 3L, "Blue Titanium", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 1L, 5, 14000.00m, "APL-IP15P-512-BLU", "512GB", 0, null, null },
                    { 4L, "Titanium Gray", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 2L, 5, 0.00m, "SAM-S24U-256-GRY", "256GB", 25, null, null },
                    { 5L, "Titanium Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 2L, 5, 5500.00m, "SAM-S24U-512-BLK", "512GB", 2, null, null },
                    { 6L, "Titanium Violet", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 2L, 5, 12000.00m, "SAM-S24U-1TB-VIO", "1TB", 0, null, null },
                    { 7L, "Space Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 3L, 3, 0.00m, "APL-MBP-14-512", "14-inch / 512GB", 30, null, null },
                    { 8L, "Space Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 3L, 3, 9000.00m, "APL-MBP-14-1TB", "14-inch / 1TB", 1, null, null },
                    { 9L, "Silver", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 3L, 3, 18000.00m, "APL-MBP-16-1TB", "16-inch / 1TB", 0, null, null },
                    { 10L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 4L, 4, 0.00m, "LG-OLED-55-BLK", "55 Inch", 40, null, null },
                    { 11L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 4L, 4, 11000.00m, "LG-OLED-65-BLK", "65 Inch", 2, null, null },
                    { 12L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 4L, 4, 25000.00m, "LG-OLED-77-BLK", "77 Inch", 0, null, null },
                    { 13L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 5L, 5, 0.00m, "SNY-XM5-BLK", "Standard", 50, null, null },
                    { 14L, "Silver", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 5L, 5, 0.00m, "SNY-XM5-SLV", "Standard", 4, null, null },
                    { 15L, "Midnight Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 5L, 5, 500.00m, "SNY-XM5-BLU", "Standard", 0, null, null },
                    { 16L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 6L, 10, 0.00m, "ZRA-TSH-WHT-M", "M", 60, null, null },
                    { 17L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 6L, 10, 0.00m, "ZRA-TSH-BLK-L", "L", 3, null, null },
                    { 18L, "Beige", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 6L, 10, 0.00m, "ZRA-TSH-BEI-XL", "XL", 0, null, null },
                    { 19L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 7L, 8, 0.00m, "LVS-501-BLU-32", "32/32", 45, null, null },
                    { 20L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 7L, 8, 0.00m, "LVS-501-BLK-34", "34/32", 2, null, null },
                    { 21L, "Light Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 7L, 8, 0.00m, "LVS-501-LBL-30", "30/32", 0, null, null },
                    { 22L, "Heather Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 8L, 5, 0.00m, "ADI-HDD-GRY-M", "M", 30, null, null },
                    { 23L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 8L, 5, 0.00m, "ADI-HDD-BLK-S", "S", 4, null, null },
                    { 24L, "Red", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 8L, 5, 100.00m, "ADI-HDD-RED-XL", "XL", 0, null, null },
                    { 25L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 9L, 5, 0.00m, "NKE-JKT-BLK-L", "L", 25, null, null },
                    { 26L, "Olive Green", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 9L, 5, 0.00m, "NKE-JKT-GRN-M", "M", 1, null, null },
                    { 27L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 9L, 5, 0.00m, "NKE-JKT-NVY-XL", "XL", 0, null, null },
                    { 28L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 10L, 10, 0.00m, "PMA-SRT-BLK-M", "M", 55, null, null },
                    { 29L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 10L, 10, 0.00m, "PMA-SRT-GRY-L", "L", 5, null, null },
                    { 30L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 10L, 10, 0.00m, "PMA-SRT-BLU-S", "S", 0, null, null },
                    { 31L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 11L, 6, 0.00m, "NKE-PEG-BLK-42", "42", 40, null, null },
                    { 32L, "Racer Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 11L, 6, 200.00m, "NKE-PEG-BLU-43", "43", 2, null, null },
                    { 33L, "Total Orange", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 11L, 6, 200.00m, "NKE-PEG-ORG-44", "44", 0, null, null },
                    { 34L, "Core White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 12L, 5, 0.00m, "ADI-UB-WHT-41", "41", 35, null, null },
                    { 35L, "Core Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 12L, 5, 0.00m, "ADI-UB-BLK-42", "42", 3, null, null },
                    { 36L, "Solar Red", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 12L, 5, 300.00m, "ADI-UB-RED-45", "45", 0, null, null },
                    { 37L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 13L, 8, 0.00m, "UA-HG-BLK-M", "M", 50, null, null },
                    { 38L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 13L, 8, 0.00m, "UA-HG-WHT-L", "L", 4, null, null },
                    { 39L, "Royal Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 13L, 8, 0.00m, "UA-HG-RYL-S", "S", 0, null, null },
                    { 40L, "Black / Red", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 14L, 3, 0.00m, "WLN-PS-97-G2", "Grip 2 (4 1/4)", 20, null, null },
                    { 41L, "Black / Red", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 14L, 3, 0.00m, "WLN-PS-97-G3", "Grip 3 (4 3/8)", 1, null, null },
                    { 42L, "Black / Red", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 14L, 3, 0.00m, "WLN-PS-97-G4", "Grip 4 (4 1/2)", 0, null, null },
                    { 43L, "Pastel Pink", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 15L, 10, 0.00m, "DEC-YM-PNK-8M", "8mm Thick", 70, null, null },
                    { 44L, "Purple", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 15L, 10, 0.00m, "DEC-YM-PPL-8M", "8mm Thick", 5, null, null },
                    { 45L, "Mint Green", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 15L, 10, 0.00m, "DEC-YM-GRN-8M", "8mm Thick", 0, null, null },
                    { 46L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 16L, 10, 0.00m, "LOR-REV-SER-30", "30ml", 80, null, null },
                    { 47L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 16L, 10, 300.00m, "LOR-REV-SER-50", "50ml", 4, null, null },
                    { 48L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 16L, 10, 750.00m, "LOR-REV-SER-100", "100ml", 0, null, null },
                    { 49L, "Translucent", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 17L, 15, 0.00m, "ORD-NIA-30ML", "30ml", 100, null, null },
                    { 50L, "Translucent", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 17L, 15, 250.00m, "ORD-NIA-60ML", "60ml", 5, null, null },
                    { 51L, "Translucent", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 17L, 15, 500.00m, "ORD-NIA-100ML", "100ml", 0, null, null },
                    { 52L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 18L, 8, 0.00m, "CRV-CLN-236ML", "236ml", 65, null, null },
                    { 53L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 18L, 8, 200.00m, "CRV-CLN-473ML", "473ml", 2, null, null },
                    { 54L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 18L, 8, 550.00m, "CRV-CLN-1000ML", "1 Litre", 0, null, null },
                    { 55L, "Very Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 19L, 10, 0.00m, "MAY-MSK-VBLK", "9.5ml", 90, null, null },
                    { 56L, "Waterproof Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 19L, 10, 50.00m, "MAY-MSK-WPR", "9.5ml", 3, null, null },
                    { 57L, "Brownish Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 19L, 10, 0.00m, "MAY-MSK-BRN", "9.5ml", 0, null, null },
                    { 58L, "Ruby Woo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 20L, 5, 0.00m, "MAC-LST-RUBY", "3g", 45, null, null },
                    { 59L, "Velvet Teddy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 20L, 5, 0.00m, "MAC-LST-VELV", "3g", 2, null, null },
                    { 60L, "Chili", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 20L, 5, 0.00m, "MAC-LST-CHLI", "3g", 0, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 19, 13, 15, 46, 412, DateTimeKind.Utc).AddTicks(8955), "AQAAAAIAAYagAAAAEOno/55mv49aRLi5RP1tjFmhivHaO6JZNw5ljXCiprn8wvm1TAIdDomadyzzg52wag==" });
        }
    }
}
