using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ItemSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "BrandId", "Code", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, 1L, "APL-IP15PM", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Titanium design, A17 Pro chip, 48MP camera", false, "iPhone 15 Pro Max", 1199.00m, null, null },
                    { 2L, 1L, "APL-MBP16", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "M3 Max chip, 36GB Unified Memory, 1TB SSD", false, "MacBook Pro 16\"", 3499.00m, null, null },
                    { 3L, 1L, "APL-IPD129", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Liquid Retina XDR display, M2 chip", false, "iPad Pro 12.9\"", 1099.00m, null, null },
                    { 4L, 1L, "APL-APP2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Active Noise Cancellation, USB-C Charging", false, "AirPods Pro (2nd Gen)", 249.00m, null, null },
                    { 5L, 1L, "APL-AWU2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Rugged titanium case, Dual-frequency GPS", false, "Apple Watch Ultra 2", 799.00m, null, null },
                    { 6L, 2L, "SAM-S24U", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Galaxy AI, 200MP Camera, S Pen included", false, "Galaxy S24 Ultra", 1299.00m, null, null },
                    { 7L, 2L, "SAM-ZFOLD5", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Unfold a massive 7.6\" main screen", false, "Galaxy Z Fold 5", 1799.00m, null, null },
                    { 8L, 2L, "SAM-GB4U", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Intel Core Ultra 9, RTX 4070, AMOLED Display", false, "Galaxy Book 4 Ultra", 2399.00m, null, null },
                    { 9L, 2L, "SAM-GW6C", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Rotating bezel, Advanced sleep tracking", false, "Galaxy Watch 6 Classic", 399.00m, null, null },
                    { 10L, 3L, "SNY-PS5S", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "1TB SSD Storage, DualSense Wireless Controller", false, "PlayStation 5 Slim", 499.00m, null, null },
                    { 11L, 3L, "SNY-XM5", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Industry-leading noise canceling wireless headphones", false, "WH-1000XM5 Headphones", 399.00m, null, null },
                    { 12L, 3L, "SNY-XR65", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Cognitive Processor XR, Perfect for PS5", false, "Bravia XR 65\" OLED 4K TV", 1999.00m, null, null },
                    { 13L, 3L, "SNY-A7IV", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "33MP Full-frame sensor, 4K 60p video", false, "Alpha 7 IV Mirrorless Camera", 2499.00m, null, null },
                    { 14L, 4L, "DEL-XPS15", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "OLED Touch Display, Intel Core i9, 32GB RAM", false, "XPS 15 Laptop", 2199.00m, null, null },
                    { 15L, 4L, "DEL-AWM18", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "RTX 4090, 18\" QHD+ 480Hz Display", false, "Alienware m18 Gaming Laptop", 3299.00m, null, null },
                    { 16L, 4L, "DEL-U2723QE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "IPS Black technology, USB-C Hub capability", false, "UltraSharp 27\" 4K Monitor", 579.00m, null, null },
                    { 17L, 4L, "DEL-INSP16", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Intel Core i7, 16GB RAM, 512GB SSD", false, "Inspiron 16 Laptop", 849.00m, null, null },
                    { 18L, 5L, "LNV-X1C11", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Ultra-lightweight business laptop, Intel Evo certified", false, "ThinkPad X1 Carbon Gen 11", 1649.00m, null, null },
                    { 19L, 5L, "LNV-LGP7I", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Intel i9 13900HX, RTX 4080, 240Hz Display", false, "Legion Pro 7i Gaming Laptop", 2499.00m, null, null },
                    { 20L, 5L, "LNV-YG9I", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "4K OLED Touchscreen, Bowers & Wilkins Soundbar", false, "Yoga 9i 2-in-1", 1399.00m, null, null },
                    { 21L, 5L, "LNV-TP12P", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "12.6\" AMOLED 120Hz display, Precision Pen 3", false, "Tab P12 Pro", 699.00m, null, null },
                    { 22L, 6L, "LG-REF26", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Door-in-Door with Craft Ice Maker", false, "InstaView Refrigerator 26 cu.ft", 2899.00m, null, null },
                    { 23L, 6L, "LG-C365", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "α9 AI Processor Gen6, Dolby Vision & Atmos", false, "C3 65\" OLED evo 4K TV", 1799.00m, null, null },
                    { 24L, 6L, "LG-WASH1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Front Load Washer and Electric Dryer with AI DD", false, "WashTower Laundry Hub", 1999.00m, null, null },
                    { 25L, 6L, "LG-34UG", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "OLED 240Hz 0.03ms, G-Sync Compatible", false, "UltraGear 34\" Curved Gaming Monitor", 999.00m, null, null },
                    { 26L, 7L, "SHP-REF4D", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Plasmacluster Ion Technology, J-Tech Inverter", false, "4-Door French Door Refrigerator", 1899.00m, null, null },
                    { 27L, 7L, "SHP-MW34L", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Stainless Steel, Touch Control, Auto Cook Menus", false, "Microwave Oven with Grill 34L", 220.00m, null, null },
                    { 28L, 7L, "SHP-AP50", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "HEPA Filter, Coverage up to 40 sqm", false, "Plasmacluster Air Purifier", 350.00m, null, null },
                    { 29L, 7L, "SHP-AQ55", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Android TV with Google Assistant built-in", false, "AQUOS 55\" 4K UHD Smart TV", 599.00m, null, null },
                    { 30L, 8L, "ZRA-JKT01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Lapel collar jacket with long sleeves and zip pockets", false, "Oversized Faux Leather Jacket", 89.90m, null, null },
                    { 31L, 8L, "ZRA-TR01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "High-waist trousers with front pleats and side pockets", false, "Pleated Wide Leg Trousers", 49.90m, null, null },
                    { 32L, 8L, "ZRA-SHT01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Relaxed fit linen shirt with button-up front", false, "100% Linen Shirt", 59.90m, null, null },
                    { 33L, 8L, "ZRA-DRS01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "V-neck dress with adjustable thin straps", false, "Satin Effect Midi Dress", 69.90m, null, null },
                    { 34L, 9L, "HM-HD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Soft sweatshirt fabric hoodie with kangaroo pocket", false, "Relaxed Fit Hoodie", 29.99m, null, null },
                    { 35L, 9L, "HM-JN01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "5-pocket jeans in washed denim with flexible stretch", false, "Slim Fit Stretch Jeans", 39.99m, null, null },
                    { 36L, 9L, "HM-TS01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Heavyweight cotton jersey T-shirt with ribbed neck", false, "Oversized Cotton T-Shirt", 17.99m, null, null },
                    { 37L, 9L, "HM-CD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Soft fine-knit cardigan with buttons down the front", false, "Fine-knit Cardigan", 24.99m, null, null },
                    { 38L, 10L, "NKE-AF1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Classic basketball shoe with durable leather overlays", false, "Air Force 1 '07", 115.00m, null, null },
                    { 39L, 10L, "NKE-TFWR", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Premium lightweight fleece jacket with full zip", false, "Tech Fleece Windrunner", 145.00m, null, null },
                    { 40L, 10L, "NKE-JOG01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Brushed-back fleece pants with elastic waistband", false, "Sportswear Club Fleece Joggers", 65.00m, null, null },
                    { 41L, 10L, "NKE-DNK", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "80s b-ball icon created for the court and adapted for the streets", false, "Dunk Low Retro", 115.00m, null, null },
                    { 42L, 11L, "ADI-UBL", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Epic energy response with Light BOOST cushioning", false, "Ultraboost Light Shoes", 190.00m, null, null },
                    { 43L, 11L, "ADI-SMB", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Leather upper with suede overlays and gum rubber sole", false, "Samba OG Shoes", 100.00m, null, null },
                    { 44L, 11L, "ADI-TRK", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Iconic 3-Stripes track jacket with stand-up collar", false, "Adicolor Classics Track Jacket", 80.00m, null, null },
                    { 45L, 11L, "ADI-TIRO", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Slim-fit training pants with AEROREADY moisture absorbing", false, "Tiro 23 League Pants", 55.00m, null, null },
                    { 46L, 12L, "PMA-SUD", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Iconic low-top suede sneakers with rubber outsole", false, "Suede Classic XXI Sneakers", 75.00m, null, null },
                    { 47L, 12L, "PMA-T7JKT", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Heritage sports style with signature side stripes", false, "T7 Track Jacket", 70.00m, null, null },
                    { 48L, 12L, "PMA-MB03", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "LaMelo Ball signature shoes with NITRO foam cushioning", false, "MB.03 Basketball Shoes", 125.00m, null, null },
                    { 49L, 12L, "PMA-HD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Fleece lined pullover hoodie with kangaroo pocket", false, "Essentials Logo Hoodie", 50.00m, null, null },
                    { 50L, 13L, "TH-POLO", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Pure cotton pique polo with signature embroidered flag", false, "Classic Polo Shirt", 89.50m, null, null },
                    { 51L, 13L, "TH-SNK", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Low top leather sneaker with subtle flag logo details", false, "Essential Leather Sneaker", 110.00m, null, null },
                    { 52L, 13L, "TH-JKT", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Packable puffer jacket with recycled down filling", false, "Lightweight Down Jacket", 199.00m, null, null },
                    { 53L, 13L, "TH-JN01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Classic straight fit denim jeans with dark wash", false, "Denton Straight Fit Jeans", 120.00m, null, null },
                    { 54L, 14L, "CK-BR01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Unlined cotton stretch bralette with iconic logo band", false, "Modern Cotton Bralette", 30.00m, null, null },
                    { 55L, 14L, "CK-TS01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "100% Organic cotton t-shirt with front chest logo", false, "Monogram Logo T-Shirt", 45.00m, null, null },
                    { 56L, 14L, "CK-JN90", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "High rise vintage inspired straight leg jeans", false, "90s Straight Denim Jeans", 98.00m, null, null },
                    { 57L, 14L, "CK-BX3P", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Classic boxer briefs with supportive fit and elastic waist", false, "3-Pack Cotton Stretch Boxer Briefs", 49.50m, null, null },
                    { 58L, 15L, "UA-TS20", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Quick-drying ultra-soft fabric with natural feel", false, "UA Tech 2.0 Short Sleeve", 25.00m, null, null },
                    { 59L, 15L, "UA-CUR11", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "UA Flow dual-density cushioning for high speed traction", false, "Curry 11 Basketball Shoes", 160.00m, null, null },
                    { 60L, 15L, "UA-BP50", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Water-resistant UA Storm technology with laptop sleeve", false, "Hustle 5.0 Backpack", 55.00m, null, null },
                    { 61L, 15L, "UA-HGLEG", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Super-light HeatGear fabric delivers superior coverage", false, "HeatGear Armour Compression Leggings", 35.00m, null, null },
                    { 62L, 16L, "RBK-C85", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Soft garment leather upper with classic tennis look", false, "Club C 85 Vintage Shoes", 90.00m, null, null },
                    { 63L, 16L, "RBK-NX4", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Lightweight breathability with Lift and Run Chassis", false, "Nano X4 Training Shoes", 140.00m, null, null },
                    { 64L, 16L, "RBK-TRKP", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Retro style track pants made with recycled materials", false, "Vector Track Pants", 60.00m, null, null },
                    { 65L, 16L, "RBK-HD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Everyday fleece hoodie with soft cotton blend", false, "Identity Logo Fleece Hoodie", 55.00m, null, null },
                    { 66L, 17L, "DEC-TNT2S", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Pop-up free-standing tent easy assembly", false, "Quechua 2-Second Camping Tent 3-Person", 120.00m, null, null },
                    { 67L, 17L, "DEC-DB20", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Cast iron plates with threaded spinlock bars", false, "Domyos Adjustable Dumbbell Set 20kg", 75.00m, null, null },
                    { 68L, 17L, "DEC-RCS", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Lightweight running shoes for beginners", false, "Kalenji Run Cushion Shoes", 35.00m, null, null },
                    { 69L, 17L, "DEC-GPSW", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Heart rate monitoring, pace and distance tracking", false, "Kiprun Running GPS Watch", 110.00m, null, null },
                    { 70L, 18L, "NB-574C", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "EVA foam cushioning with durable suede and mesh upper", false, "574 Core Sneakers", 90.00m, null, null },
                    { 71L, 18L, "NB-990V6", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "FuelCell foam delivers a propulsive feel with ENCAP midsole", false, "990v6 Made in USA", 200.00m, null, null },
                    { 72L, 18L, "NB-1080V13", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Max cushioning running shoe with breathable engineered mesh", false, "Fresh Foam X 1080v13", 165.00m, null, null },
                    { 73L, 18L, "NB-HD01", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Relaxed fit soft French terry pullover hoodie", false, "Athletics French Terry Hoodie", 75.00m, null, null },
                    { 74L, 19L, "COL-WT2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Omni-Tech waterproof breathable fully seam sealed jacket", false, "Watertight II Rain Jacket", 90.00m, null, null },
                    { 75L, 19L, "COL-FLC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Warm 250g MTR filament fleece sweater jacket", false, "Steens Mountain Full Zip Fleece", 45.00m, null, null },
                    { 76L, 19L, "COL-NTR", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Waterproof leather and suede hiking boots with Techlite midsole", false, "Newton Ridge Plus Hiking Boots", 100.00m, null, null },
                    { 77L, 19L, "COL-PNT", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Omni-Shade UPF 50 sun protection hiking pants", false, "Silver Ridge Utility Pants", 65.00m, null, null },
                    { 78L, 20L, "SKC-GW6", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Hands Free Slip-ins with Air-Cooled Goga Mat insole", false, "Go Walk 6 - Slip-Ins", 85.00m, null, null },
                    { 79L, 20L, "SKC-AF2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Podiatrist-certified arch support walking shoes", false, "Arch Fit 2.0 Sneakers", 95.00m, null, null },
                    { 80L, 20L, "SKC-UNO", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Classic air-cushioned style with Memory Foam insole", false, "UNO - Stand on Air", 80.00m, null, null },
                    { 81L, 20L, "SKC-DLT", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Chunky retro style sneakers with flexible traction outsole", false, "D'Lites 4.0 Pro", 75.00m, null, null },
                    { 82L, 21L, "ASC-GK30", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Advanced stability running shoes with PureGEL technology", false, "GEL-KAYANO 30", 160.00m, null, null },
                    { 83L, 21L, "ASC-GN26", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Maximum cushioning running shoes with FF BLAST PLUS ECO", false, "GEL-NIMBUS 26", 160.00m, null, null },
                    { 84L, 21L, "ASC-GT20", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Versatile stability trainer for various distances", false, "GT-2000 12", 140.00m, null, null },
                    { 85L, 21L, "ASC-GV9", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Rearfoot GEL technology for trail running and outdoor walking", false, "GEL-VENTURE 9 Hiking Shoes", 75.00m, null, null },
                    { 86L, 22L, "LOR-HA15", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Plumps skin and reduces wrinkles in 1 week", false, "Revitalift 1.5% Pure Hyaluronic Acid Serum", 32.99m, null, null },
                    { 87L, 22L, "LOR-INF24", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Lightweight breathable liquid foundation transfer-resistant", false, "Infallible 24H Fresh Wear Foundation", 16.99m, null, null },
                    { 88L, 22L, "LOR-ELV400", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Repairs 5 signs of damaged hair with Protein + Ceramides", false, "Elvive Total Repair 5 Shampoo 400ml", 8.50m, null, null },
                    { 89L, 22L, "LOR-LASH", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Voluptuous volume and intense length waterproof mascara", false, "Lash Paradise Mascara Black", 12.99m, null, null },
                    { 90L, 23L, "MAY-SKYH", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Limitless length and full volume washable mascara", false, "Lash Sensational Sky High Mascara", 12.99m, null, null },
                    { 91L, 23L, "MAY-FITM", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Oil-free foundation matches skin tone and texture", false, "Fit Me Matte + Poreless Foundation", 9.99m, null, null },
                    { 92L, 23L, "MAY-SINK", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Up to 16 hours saturated matte color liquid lipstick", false, "SuperStay Matte Ink Liquid Lipstick", 10.99m, null, null },
                    { 93L, 23L, "MAY-ARWC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Multi-use concealer erases dark circles and redness", false, "Instant Age Rewind Eraser Concealer", 10.99m, null, null },
                    { 94L, 24L, "CRV-HFC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "With hyaluronic acid, ceramides, and glycerin for normal to dry skin", false, "Hydrating Facial Cleanser 473ml", 18.00m, null, null },
                    { 95L, 24L, "CRV-MC454", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Rich non-greasy moisturizing cream with 3 essential ceramides", false, "Moisturizing Cream 454g", 19.50m, null, null },
                    { 96L, 24L, "CRV-AM30", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Daily oil-free face moisturizer with broad spectrum sunscreen", false, "AM Facial Moisturizing Lotion SPF 30", 19.00m, null, null },
                    { 97L, 24L, "CRV-RRS", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Reduces appearance of post-acne marks and pores", false, "Resurfacing Retinol Serum 30ml", 21.99m, null, null },
                    { 98L, 25L, "MAC-RW", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Iconic vivid blue-red matte finish lipstick", false, "Matte Lipstick - Ruby Woo", 23.00m, null, null },
                    { 99L, 25L, "MAC-SFF", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "24-hour wear buildable coverage matte finish foundation", false, "Studio Fix Fluid SPF 15 Foundation", 42.00m, null, null },
                    { 100L, 25L, "MAC-FIXP", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Hydrating face mist that sets and refreshes makeup", false, "Prep + Prime Fix+ Setting Spray 100ml", 31.00m, null, null },
                    { 101L, 25L, "MAC-MSF", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Slow-baked domed face powder with dimensional finish", false, "Mineralize Skinfinish Powder", 42.00m, null, null },
                    { 102L, 26L, "NIV-CRM150", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Original all-purpose moisturizer for face, body, and hands", false, "Nivea Creme Tin 150ml", 6.50m, null, null },
                    { 103L, 26L, "NIV-NGL350", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Organic avocado oil body lotion for 48h moisture", false, "Naturally Good Body Lotion 350ml", 9.00m, null, null },
                    { 104L, 26L, "NIV-BWRO", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "48h anti-perspirant protection without yellow stains", false, "Black & White Invisible Roll-On 50ml", 4.50m, null, null },
                    { 105L, 26L, "NIV-Q10DC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Firming face moisturizer with pure Q10 and Creatine", false, "Q10 Power Anti-Wrinkle Day Cream SPF 15", 14.50m, null, null },
                    { 106L, 27L, "ORD-NIA10", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "High-strength vitamin and mineral blemish formula", false, "Niacinamide 10% + Zinc 1%", 6.00m, null, null },
                    { 107L, 27L, "ORD-HA2B5", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Hydration support formula with ultra-pure vegan hyaluronic acid", false, "Hyaluronic Acid 2% + B5", 8.90m, null, null },
                    { 108L, 27L, "ORD-PEEL30", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "10-minute exfoliating facial peeling treatment", false, "AHA 30% + BHA 2% Peeling Solution", 9.50m, null, null },
                    { 109L, 27L, "ORD-CAF5", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Reduces appearance of eye contour pigmentation and puffiness", false, "Caffeine Solution 5% + EGCG", 8.00m, null, null },
                    { 110L, 28L, "VCH-M89", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Daily skin fortifying serum for plump and hydrated skin", false, "Minéral 89 Hyaluronic Acid Booster 50ml", 29.99m, null, null },
                    { 111L, 28L, "VCH-LAVITC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "15% Pure Vitamin C antioxidant serum for bright skin", false, "LiftActiv Vitamin C Serum 20ml", 35.00m, null, null },
                    { 112L, 28L, "VCH-NORM200", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Purifying gel cleanser enriched with Salicylic Acid for acne-prone skin", false, "Normaderm PhytoSolution Cleansing Gel", 20.00m, null, null },
                    { 113L, 28L, "VCH-UV50", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Seeder", null, null, "Anti-imperfections daily sun protection fluid with Niacinamide", false, "Capital Soleil UV-Clear Fluid SPF 50+", 24.50m, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 25, 20, 41, 56, 520, DateTimeKind.Utc).AddTicks(1988), "AQAAAAIAAYagAAAAEJzEWhRALkhZq9FMuRJzpJaK8ntRmjpjCyOzud3lsgxt20AL555NbFIyJXHFjwOIZg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 25, 20, 31, 26, 282, DateTimeKind.Utc).AddTicks(2134), "AQAAAAIAAYagAAAAEM/0GWnD1Kfn/ALJvBCsrsSFEFpk2H2JVxFXZfMeAX6IWVqMkn8wl7uHIGqGDOFUzw==" });
        }
    }
}
