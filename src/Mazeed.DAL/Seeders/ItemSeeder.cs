using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Seeders
{
    public static class ItemSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var items = new List<Item>();
            long itemId = 1;

             // 1. Apple (BrandId = 1)
            items.AddRange(new[]
                        {
                new Item { Id = itemId++, Name = "iPhone 15 Pro Max", Code = "APL-IP15PM", Description = "Titanium design, A17 Pro chip, 48MP camera", Price = 65000.00m, BrandId = 1, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "MacBook Pro 16\"", Code = "APL-MBP16", Description = "M3 Max chip, 36GB Unified Memory, 1TB SSD", Price = 175000.00m, BrandId = 1, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "iPad Pro 12.9\"", Code = "APL-IPD129", Description = "Liquid Retina XDR display, M2 chip", Price = 58000.00m, BrandId = 1, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "AirPods Pro (2nd Gen)", Code = "APL-APP2", Description = "Active Noise Cancellation, USB-C Charging", Price = 12500.00m, BrandId = 1, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Apple Watch Ultra 2", Code = "APL-AWU2", Description = "Rugged titanium case, Dual-frequency GPS", Price = 42000.00m, BrandId = 1, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
            });

            // 2. Samsung (BrandId = 2)
             items.AddRange(new[]
                        {
                new Item { Id = itemId++, Name = "Galaxy S24 Ultra", Code = "SAM-S24U", Description = "Galaxy AI, 200MP Camera, S Pen included", Price = 62000.00m, BrandId = 2, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Galaxy Z Fold 5", Code = "SAM-ZFOLD5", Description = "Unfold a massive 7.6\" main screen", Price = 78000.00m, BrandId = 2, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Galaxy Book 4 Ultra", Code = "SAM-GB4U", Description = "Intel Core Ultra 9, RTX 4070, AMOLED Display", Price = 120000.00m, BrandId = 2, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Galaxy Watch 6 Classic", Code = "SAM-GW6C", Description = "Rotating bezel, Advanced sleep tracking", Price = 16500.00m, BrandId = 2, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
            });

            // 3. Sony (BrandId = 3)
            items.AddRange(new[]
                        {
                new Item { Id = itemId++, Name = "PlayStation 5 Slim", Code = "SNY-PS5S", Description = "1TB SSD Storage, DualSense Wireless Controller", Price = 27500.00m, BrandId = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "WH-1000XM5 Headphones", Code = "SNY-XM5", Description = "Industry-leading noise canceling wireless headphones", Price = 18500.00m, BrandId = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Bravia XR 65\" OLED 4K TV", Code = "SNY-XR65", Description = "Cognitive Processor XR, Perfect for PS5", Price = 95000.00m, BrandId = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Alpha 7 IV Mirrorless Camera", Code = "SNY-A7IV", Description = "33MP Full-frame sensor, 4K 60p video", Price = 125000.00m, BrandId = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
            });

            // 4. Dell (BrandId = 4)
             items.AddRange(new[]
                        {
                new Item { Id = itemId++, Name = "XPS 15 Laptop", Code = "DEL-XPS15", Description = "OLED Touch Display, Intel Core i9, 32GB RAM", Price = 110000.00m, BrandId = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Alienware m18 Gaming Laptop", Code = "DEL-AWM18", Description = "RTX 4090, 18\" QHD+ 480Hz Display", Price = 165000.00m, BrandId = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "UltraSharp 27\" 4K Monitor", Code = "DEL-U2723QE", Description = "IPS Black technology, USB-C Hub capability", Price = 29000.00m, BrandId = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Inspiron 16 Laptop", Code = "DEL-INSP16", Description = "Intel Core i7, 16GB RAM, 512GB SSD", Price = 42500.00m, BrandId = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
            });

            // 5. Lenovo (BrandId = 5)
            items.AddRange(new[]
                        {
                new Item { Id = itemId++, Name = "ThinkPad X1 Carbon Gen 11", Code = "LNV-X1C11", Description = "Ultra-lightweight business laptop, Intel Evo certified", Price = 82000.00m, BrandId = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Legion Pro 7i Gaming Laptop", Code = "LNV-LGP7I", Description = "Intel i9 13900HX, RTX 4080, 240Hz Display", Price = 125000.00m, BrandId = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Yoga 9i 2-in-1", Code = "LNV-YG9I", Description = "4K OLED Touchscreen, Bowers & Wilkins Soundbar", Price = 70000.00m, BrandId = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
                new Item { Id = itemId++, Name = "Tab P12 Pro", Code = "LNV-TP12P", Description = "12.6\" AMOLED 120Hz display, Precision Pen 3", Price = 35000.00m, BrandId = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
            });
           
            // 6. LG (BrandId = 6)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "InstaView Refrigerator 26 cu.ft", Code = "LG-REF26", Description = "Door-in-Door with Craft Ice Maker", Price = 125000.00m, BrandId = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "C3 65\" OLED evo 4K TV", Code = "LG-C365", Description = "α9 AI Processor Gen6, Dolby Vision & Atmos", Price = 85000.00m, BrandId = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "WashTower Laundry Hub", Code = "LG-WASH1", Description = "Front Load Washer and Electric Dryer with AI DD", Price = 145000.00m, BrandId = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "UltraGear 34\" Curved Gaming Monitor", Code = "LG-34UG", Description = "OLED 240Hz 0.03ms, G-Sync Compatible", Price = 65000.00m, BrandId = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 7. Sharp (BrandId = 7)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "4-Door French Door Refrigerator", Code = "SHP-REF4D", Description = "Plasmacluster Ion Technology, J-Tech Inverter", Price = 75000.00m, BrandId = 7, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Microwave Oven with Grill 34L", Code = "SHP-MW34L", Description = "Stainless Steel, Touch Control, Auto Cook Menus", Price = 8500.00m, BrandId = 7, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Plasmacluster Air Purifier", Code = "SHP-AP50", Description = "HEPA Filter, Coverage up to 40 sqm", Price = 16000.00m, BrandId = 7, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "AQUOS 55\" 4K UHD Smart TV", Code = "SHP-AQ55", Description = "Android TV with Google Assistant built-in", Price = 28000.00m, BrandId = 7, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 8. Zara (BrandId = 8)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Oversized Faux Leather Jacket", Code = "ZRA-JKT01", Description = "Lapel collar jacket with long sleeves and zip pockets", Price = 4500.00m, BrandId = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Pleated Wide Leg Trousers", Code = "ZRA-TR01", Description = "High-waist trousers with front pleats and side pockets", Price = 2800.00m, BrandId = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "100% Linen Shirt", Code = "ZRA-SHT01", Description = "Relaxed fit linen shirt with button-up front", Price = 3200.00m, BrandId = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Satin Effect Midi Dress", Code = "ZRA-DRS01", Description = "V-neck dress with adjustable thin straps", Price = 3800.00m, BrandId = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 9. H&M (BrandId = 9)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Relaxed Fit Hoodie", Code = "HM-HD01", Description = "Soft sweatshirt fabric hoodie with kangaroo pocket", Price = 1600.00m, BrandId = 9, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Slim Fit Stretch Jeans", Code = "HM-JN01", Description = "5-pocket jeans in washed denim with flexible stretch", Price = 1900.00m, BrandId = 9, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Oversized Cotton T-Shirt", Code = "HM-TS01", Description = "Heavyweight cotton jersey T-shirt with ribbed neck", Price = 900.00m, BrandId = 9, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Fine-knit Cardigan", Code = "HM-CD01", Description = "Soft fine-knit cardigan with buttons down the front", Price = 1300.00m, BrandId = 9, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 10. Nike (BrandId = 10)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Air Force 1 '07", Code = "NKE-AF1", Description = "Classic basketball shoe with durable leather overlays", Price = 7500.00m, BrandId = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Tech Fleece Windrunner", Code = "NKE-TFWR", Description = "Premium lightweight fleece jacket with full zip", Price = 8500.00m, BrandId = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Sportswear Club Fleece Joggers", Code = "NKE-JOG01", Description = "Brushed-back fleece pants with elastic waistband", Price = 4000.00m, BrandId = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Dunk Low Retro", Code = "NKE-DNK", Description = "80s b-ball icon created for the court and adapted for the streets", Price = 7500.00m, BrandId = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 11. Adidas (BrandId = 11)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Ultraboost Light Shoes", Code = "ADI-UBL", Description = "Epic energy response with Light BOOST cushioning", Price = 9000.00m, BrandId = 11, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Samba OG Shoes", Code = "ADI-SMB", Description = "Leather upper with suede overlays and gum rubber sole", Price = 6500.00m, BrandId = 11, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Adicolor Classics Track Jacket", Code = "ADI-TRK", Description = "Iconic 3-Stripes track jacket with stand-up collar", Price = 4000.00m, BrandId = 11, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Tiro 23 League Pants", Code = "ADI-TIRO", Description = "Slim-fit training pants with AEROREADY moisture absorbing", Price = 2800.00m, BrandId = 11, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 12. Puma (BrandId = 12)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Suede Classic XXI Sneakers", Code = "PMA-SUD", Description = "Iconic low-top suede sneakers with rubber outsole", Price = 4500.00m, BrandId = 12, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "T7 Track Jacket", Code = "PMA-T7JKT", Description = "Heritage sports style with signature side stripes", Price = 3800.00m, BrandId = 12, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "MB.03 Basketball Shoes", Code = "PMA-MB03", Description = "LaMelo Ball signature shoes with NITRO foam cushioning", Price = 6500.00m, BrandId = 12, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Essentials Logo Hoodie", Code = "PMA-HD01", Description = "Fleece lined pullover hoodie with kangaroo pocket", Price = 2800.00m, BrandId = 12, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 13. Tommy Hilfiger (BrandId = 13)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Classic Polo Shirt", Code = "TH-POLO", Description = "Pure cotton pique polo with signature embroidered flag", Price = 4500.00m, BrandId = 13, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Essential Leather Sneaker", Code = "TH-SNK", Description = "Low top leather sneaker with subtle flag logo details", Price = 5500.00m, BrandId = 13, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Lightweight Down Jacket", Code = "TH-JKT", Description = "Packable puffer jacket with recycled down filling", Price = 10000.00m, BrandId = 13, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Denton Straight Fit Jeans", Code = "TH-JN01", Description = "Classic straight fit denim jeans with dark wash", Price = 6000.00m, BrandId = 13, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 14. Calvin Klein (BrandId = 14)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Modern Cotton Bralette", Code = "CK-BR01", Description = "Unlined cotton stretch bralette with iconic logo band", Price = 1800.00m, BrandId = 14, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Monogram Logo T-Shirt", Code = "CK-TS01", Description = "100% Organic cotton t-shirt with front chest logo", Price = 2500.00m, BrandId = 14, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "90s Straight Denim Jeans", Code = "CK-JN90", Description = "High rise vintage inspired straight leg jeans", Price = 5000.00m, BrandId = 14, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "3-Pack Cotton Stretch Boxer Briefs", Code = "CK-BX3P", Description = "Classic boxer briefs with supportive fit and elastic waist", Price = 2800.00m, BrandId = 14, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 15. Under Armour (BrandId = 15)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "UA Tech 2.0 Short Sleeve", Code = "UA-TS20", Description = "Quick-drying ultra-soft fabric with natural feel", Price = 1500.00m, BrandId = 15, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Curry 11 Basketball Shoes", Code = "UA-CUR11", Description = "UA Flow dual-density cushioning for high speed traction", Price = 8000.00m, BrandId = 15, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Hustle 5.0 Backpack", Code = "UA-BP50", Description = "Water-resistant UA Storm technology with laptop sleeve", Price = 3000.00m, BrandId = 15, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "HeatGear Armour Compression Leggings", Code = "UA-HGLEG", Description = "Super-light HeatGear fabric delivers superior coverage", Price = 2000.00m, BrandId = 15, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 16. Reebok (BrandId = 16)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Club C 85 Vintage Shoes", Code = "RBK-C85", Description = "Soft garment leather upper with classic tennis look", Price = 4500.00m, BrandId = 16, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Nano X4 Training Shoes", Code = "RBK-NX4", Description = "Lightweight breathability with Lift and Run Chassis", Price = 7000.00m, BrandId = 16, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Vector Track Pants", Code = "RBK-TRKP", Description = "Retro style track pants made with recycled materials", Price = 3000.00m, BrandId = 16, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Identity Logo Fleece Hoodie", Code = "RBK-HD01", Description = "Everyday fleece hoodie with soft cotton blend", Price = 2800.00m, BrandId = 16, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 17. Decathlon (BrandId = 17)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Quechua 2-Second Camping Tent 3-Person", Code = "DEC-TNT2S", Description = "Pop-up free-standing tent easy assembly", Price = 6500.00m, BrandId = 17, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Domyos Adjustable Dumbbell Set 20kg", Code = "DEC-DB20", Description = "Cast iron plates with threaded spinlock bars", Price = 4500.00m, BrandId = 17, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Kalenji Run Cushion Shoes", Code = "DEC-RCS", Description = "Lightweight running shoes for beginners", Price = 2200.00m, BrandId = 17, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Kiprun Running GPS Watch", Code = "DEC-GPSW", Description = "Heart rate monitoring, pace and distance tracking", Price = 5500.00m, BrandId = 17, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 18. New Balance (BrandId = 18)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "574 Core Sneakers", Code = "NB-574C", Description = "EVA foam cushioning with durable suede and mesh upper", Price = 5500.00m, BrandId = 18, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "990v6 Made in USA", Code = "NB-990V6", Description = "FuelCell foam delivers a propulsive feel with ENCAP midsole", Price = 11000.00m, BrandId = 18, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Fresh Foam X 1080v13", Code = "NB-1080V13", Description = "Max cushioning running shoe with breathable engineered mesh", Price = 8500.00m, BrandId = 18, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Athletics French Terry Hoodie", Code = "NB-HD01", Description = "Relaxed fit soft French terry pullover hoodie", Price = 3800.00m, BrandId = 18, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 19. Columbia (BrandId = 19)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Watertight II Rain Jacket", Code = "COL-WT2", Description = "Omni-Tech waterproof breathable fully seam sealed jacket", Price = 5000.00m, BrandId = 19, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Steens Mountain Full Zip Fleece", Code = "COL-FLC", Description = "Warm 250g MTR filament fleece sweater jacket", Price = 2800.00m, BrandId = 19, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Newton Ridge Plus Hiking Boots", Code = "COL-NTR", Description = "Waterproof leather and suede hiking boots with Techlite midsole", Price = 6500.00m, BrandId = 19, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Silver Ridge Utility Pants", Code = "COL-PNT", Description = "Omni-Shade UPF 50 sun protection hiking pants", Price = 3500.00m, BrandId = 19, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 20. Skechers (BrandId = 20)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Go Walk 6 - Slip-Ins", Code = "SKC-GW6", Description = "Hands Free Slip-ins with Air-Cooled Goga Mat insole", Price = 5000.00m, BrandId = 20, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Arch Fit 2.0 Sneakers", Code = "SKC-AF2", Description = "Podiatrist-certified arch support walking shoes", Price = 5500.00m, BrandId = 20, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "UNO - Stand on Air", Code = "SKC-UNO", Description = "Classic air-cushioned style with Memory Foam insole", Price = 4800.00m, BrandId = 20, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "D'Lites 4.0 Pro", Code = "SKC-DLT", Description = "Chunky retro style sneakers with flexible traction outsole", Price = 4500.00m, BrandId = 20, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 21. Asics (BrandId = 21)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "GEL-KAYANO 30", Code = "ASC-GK30", Description = "Advanced stability running shoes with PureGEL technology", Price = 8500.00m, BrandId = 21, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "GEL-NIMBUS 26", Code = "ASC-GN26", Description = "Maximum cushioning running shoes with FF BLAST PLUS ECO", Price = 8500.00m, BrandId = 21, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "GT-2000 12", Code = "ASC-GT20", Description = "Versatile stability trainer for various distances", Price = 7500.00m, BrandId = 21, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "GEL-VENTURE 9 Hiking Shoes", Code = "ASC-GV9", Description = "Rearfoot GEL technology for trail running and outdoor walking", Price = 4500.00m, BrandId = 21, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 22. L'Oréal Paris (BrandId = 22)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Revitalift 1.5% Pure Hyaluronic Acid Serum", Code = "LOR-HA15", Description = "Plumps skin and reduces wrinkles in 1 week", Price = 1400.00m, BrandId = 22, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Infallible 24H Fresh Wear Foundation", Code = "LOR-INF24", Description = "Lightweight breathable liquid foundation transfer-resistant", Price = 950.00m, BrandId = 22, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Elvive Total Repair 5 Shampoo 400ml", Code = "LOR-ELV400", Description = "Repairs 5 signs of damaged hair with Protein + Ceramides", Price = 450.00m, BrandId = 22, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Lash Paradise Mascara Black", Code = "LOR-LASH", Description = "Voluptuous volume and intense length waterproof mascara", Price = 750.00m, BrandId = 22, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 23. Maybelline (BrandId = 23)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Lash Sensational Sky High Mascara", Code = "MAY-SKYH", Description = "Limitless length and full volume washable mascara", Price = 700.00m, BrandId = 23, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Fit Me Matte + Poreless Foundation", Code = "MAY-FITM", Description = "Oil-free foundation matches skin tone and texture", Price = 600.00m, BrandId = 23, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "SuperStay Matte Ink Liquid Lipstick", Code = "MAY-SINK", Description = "Up to 16 hours saturated matte color liquid lipstick", Price = 550.00m, BrandId = 23, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Instant Age Rewind Eraser Concealer", Code = "MAY-ARWC", Description = "Multi-use concealer erases dark circles and redness", Price = 600.00m, BrandId = 23, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 24. CeraVe (BrandId = 24)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Hydrating Facial Cleanser 473ml", Code = "CRV-HFC", Description = "With hyaluronic acid, ceramides, and glycerin for normal to dry skin", Price = 1100.00m, BrandId = 24, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Moisturizing Cream 454g", Code = "CRV-MC454", Description = "Rich non-greasy moisturizing cream with 3 essential ceramides", Price = 1200.00m, BrandId = 24, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "AM Facial Moisturizing Lotion SPF 30", Code = "CRV-AM30", Description = "Daily oil-free face moisturizer with broad spectrum sunscreen", Price = 1150.00m, BrandId = 24, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Resurfacing Retinol Serum 30ml", Code = "CRV-RRS", Description = "Reduces appearance of post-acne marks and pores", Price = 1300.00m, BrandId = 24, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 25. MAC Cosmetics (BrandId = 25)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Matte Lipstick - Ruby Woo", Code = "MAC-RW", Description = "Iconic vivid blue-red matte finish lipstick", Price = 1400.00m, BrandId = 25, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Studio Fix Fluid SPF 15 Foundation", Code = "MAC-SFF", Description = "24-hour wear buildable coverage matte finish foundation", Price = 2500.00m, BrandId = 25, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Prep + Prime Fix+ Setting Spray 100ml", Code = "MAC-FIXP", Description = "Hydrating face mist that sets and refreshes makeup", Price = 1800.00m, BrandId = 25, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Mineralize Skinfinish Powder", Code = "MAC-MSF", Description = "Slow-baked domed face powder with dimensional finish", Price = 2200.00m, BrandId = 25, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 26. Nivea (BrandId = 26)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Nivea Creme Tin 150ml", Code = "NIV-CRM150", Description = "Original all-purpose moisturizer for face, body, and hands", Price = 250.00m, BrandId = 26, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Naturally Good Body Lotion 350ml", Code = "NIV-NGL350", Description = "Organic avocado oil body lotion for 48h moisture", Price = 350.00m, BrandId = 26, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Black & White Invisible Roll-On 50ml", Code = "NIV-BWRO", Description = "48h anti-perspirant protection without yellow stains", Price = 180.00m, BrandId = 26, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Q10 Power Anti-Wrinkle Day Cream SPF 15", Code = "NIV-Q10DC", Description = "Firming face moisturizer with pure Q10 and Creatine", Price = 550.00m, BrandId = 26, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 27. The Ordinary (BrandId = 27)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Niacinamide 10% + Zinc 1%", Code = "ORD-NIA10", Description = "High-strength vitamin and mineral blemish formula", Price = 550.00m, BrandId = 27, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Hyaluronic Acid 2% + B5", Code = "ORD-HA2B5", Description = "Hydration support formula with ultra-pure vegan hyaluronic acid", Price = 650.00m, BrandId = 27, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "AHA 30% + BHA 2% Peeling Solution", Code = "ORD-PEEL30", Description = "10-minute exfoliating facial peeling treatment", Price = 700.00m, BrandId = 27, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Caffeine Solution 5% + EGCG", Code = "ORD-CAF5", Description = "Reduces appearance of eye contour pigmentation and puffiness", Price = 600.00m, BrandId = 27, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            // 28. Vichy (BrandId = 28)
            items.AddRange(new[]
            {
    new Item { Id = itemId++, Name = "Minéral 89 Hyaluronic Acid Booster 50ml", Code = "VCH-M89", Description = "Daily skin fortifying serum for plump and hydrated skin", Price = 1800.00m, BrandId = 28, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "LiftActiv Vitamin C Serum 20ml", Code = "VCH-LAVITC", Description = "15% Pure Vitamin C antioxidant serum for bright skin", Price = 2200.00m, BrandId = 28, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Normaderm PhytoSolution Cleansing Gel", Code = "VCH-NORM200", Description = "Purifying gel cleanser enriched with Salicylic Acid for acne-prone skin", Price = 1300.00m, BrandId = 28, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false },
    new Item { Id = itemId++, Name = "Capital Soleil UV-Clear Fluid SPF 50+", Code = "VCH-UV50", Description = "Anti-imperfections daily sun protection fluid with Niacinamide", Price = 1600.00m, BrandId = 28, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "System Seeder", IsDeleted = false }
});

            modelBuilder.Entity<Item>().HasData(items);
        }
    }
}