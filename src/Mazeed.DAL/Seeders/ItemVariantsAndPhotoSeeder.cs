
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mazeed.DAL.Entities;

namespace Mazeed.DAL.Data
{
    public static class ItemVariantsAndPhotoSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region 1. Seed ItemVariants

            var variants = new List<ItemVariant>
            {
                // =========================================================
                // CATEGORY 1: ELECTRONICS (Items 1 to 5)
                // =========================================================

                // Item 1: iPhone 15 Pro
                new ItemVariant { Id = 1, ItemId = 1, SKU = "APL-IP15P-128-BLK", Color = "Black Titanium", Size = "128GB", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 2, ItemId = 1, SKU = "APL-IP15P-256-NAT", Color = "Natural Titanium", Size = "256GB", PriceAdjustment = 6000.00m, StockQuantity = 3, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 3, ItemId = 1, SKU = "APL-IP15P-512-BLU", Color = "Blue Titanium", Size = "512GB", PriceAdjustment = 14000.00m, StockQuantity = 0, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 2: Samsung Galaxy S24 Ultra
                new ItemVariant { Id = 4, ItemId = 2, SKU = "SAM-S24U-256-GRY", Color = "Titanium Gray", Size = "256GB", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 5, ItemId = 2, SKU = "SAM-S24U-512-BLK", Color = "Titanium Black", Size = "512GB", PriceAdjustment = 5500.00m, StockQuantity = 2, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 6, ItemId = 2, SKU = "SAM-S24U-1TB-VIO", Color = "Titanium Violet", Size = "1TB", PriceAdjustment = 12000.00m, StockQuantity = 0, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },

                // Item 3: MacBook Pro M3
                new ItemVariant { Id = 7, ItemId = 3, SKU = "APL-MBP-14-512", Color = "Space Black", Size = "14-inch / 512GB", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 3 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 8, ItemId = 3, SKU = "APL-MBP-14-1TB", Color = "Space Black", Size = "14-inch / 1TB", PriceAdjustment = 9000.00m, StockQuantity = 1, LowStockThreshold = 3 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 9, ItemId = 3, SKU = "APL-MBP-16-1TB", Color = "Silver", Size = "16-inch / 1TB", PriceAdjustment = 18000.00m, StockQuantity = 0, LowStockThreshold = 3 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 4: LG OLED C3 55 TV
                new ItemVariant { Id = 10, ItemId = 4, SKU = "LG-OLED-55-BLK", Color = "Black", Size = "55 Inch", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 4,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 11, ItemId = 4, SKU = "LG-OLED-65-BLK", Color = "Black", Size = "65 Inch", PriceAdjustment = 11000.00m, StockQuantity = 2, LowStockThreshold = 4 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 12, ItemId = 4, SKU = "LG-OLED-77-BLK", Color = "Black", Size = "77 Inch", PriceAdjustment = 25000.00m, StockQuantity = 0, LowStockThreshold = 4 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 5: Sony WH-1000XM5 Headphones
                new ItemVariant { Id = 13, ItemId = 5, SKU = "SNY-XM5-BLK", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 50, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 14, ItemId = 5, SKU = "SNY-XM5-SLV", Color = "Silver", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 4, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 15, ItemId = 5, SKU = "SNY-XM5-BLU", Color = "Midnight Blue", Size = "Standard", PriceAdjustment = 500.00m, StockQuantity = 0, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },


                // =========================================================
                // CATEGORY 2: FASHION (Items 6 to 10)
                // =========================================================

                // Item 6: Zara Oversized Cotton T-Shirt
                new ItemVariant { Id = 16, ItemId = 6, SKU = "ZRA-TSH-WHT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 60, LowStockThreshold = 10,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 17, ItemId = 6, SKU = "ZRA-TSH-BLK-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 3, LowStockThreshold = 10,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 18, ItemId = 6, SKU = "ZRA-TSH-BEI-XL", Color = "Beige", Size = "XL", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 10 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 7: Levi's 501 Original Jeans
                new ItemVariant { Id = 19, ItemId = 7, SKU = "LVS-501-BLU-32", Color = "Dark Blue", Size = "32/32", PriceAdjustment = 0.00m, StockQuantity = 45, LowStockThreshold = 8,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 20, ItemId = 7, SKU = "LVS-501-BLK-34", Color = "Black", Size = "34/32", PriceAdjustment = 0.00m, StockQuantity = 2, LowStockThreshold = 8,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 21, ItemId = 7, SKU = "LVS-501-LBL-30", Color = "Light Blue", Size = "30/32", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 8 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 8: Adidas Originals Hoodie
                new ItemVariant { Id = 22, ItemId = 8, SKU = "ADI-HDD-GRY-M", Color = "Heather Grey", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 23, ItemId = 8, SKU = "ADI-HDD-BLK-S", Color = "Black", Size = "S", PriceAdjustment = 0.00m, StockQuantity = 4, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 24, ItemId = 8, SKU = "ADI-HDD-RED-XL", Color = "Red", Size = "XL", PriceAdjustment = 100.00m, StockQuantity = 0, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 9: Nike Sportswear Jacket
                new ItemVariant { Id = 25, ItemId = 9, SKU = "NKE-JKT-BLK-L", Color = "Black / White", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 26, ItemId = 9, SKU = "NKE-JKT-GRN-M", Color = "Olive Green", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 1, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 27, ItemId = 9, SKU = "NKE-JKT-NVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 10: Puma Casual Shorts
                new ItemVariant { Id = 28, ItemId = 10, SKU = "PMA-SRT-BLK-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 55, LowStockThreshold = 10 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 29, ItemId = 10, SKU = "PMA-SRT-GRY-L", Color = "Grey", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 5, LowStockThreshold = 10 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 30, ItemId = 10, SKU = "PMA-SRT-BLU-S", Color = "Blue", Size = "S", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 10 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},


                // =========================================================
                // CATEGORY 3: SPORTS (Items 11 to 15)
                // =========================================================

                // Item 11: Nike Air Zoom Pegasus Running Shoes
                new ItemVariant { Id = 31, ItemId = 11, SKU = "NKE-PEG-BLK-42", Color = "Black / White", Size = "42", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 6 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 32, ItemId = 11, SKU = "NKE-PEG-BLU-43", Color = "Racer Blue", Size = "43", PriceAdjustment = 200.00m, StockQuantity = 2, LowStockThreshold = 6,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 33, ItemId = 11, SKU = "NKE-PEG-ORG-44", Color = "Total Orange", Size = "44", PriceAdjustment = 200.00m, StockQuantity = 0, LowStockThreshold = 6 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 12: Adidas Ultraboost Light
                new ItemVariant { Id = 34, ItemId = 12, SKU = "ADI-UB-WHT-41", Color = "Core White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 35, ItemId = 12, SKU = "ADI-UB-BLK-42", Color = "Core Black", Size = "42", PriceAdjustment = 0.00m, StockQuantity = 3, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 36, ItemId = 12, SKU = "ADI-UB-RED-45", Color = "Solar Red", Size = "45", PriceAdjustment = 300.00m, StockQuantity = 0, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 13: Under Armour HeatGear Compression Top
                new ItemVariant { Id = 37, ItemId = 13, SKU = "UA-HG-BLK-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 50, LowStockThreshold = 8 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 38, ItemId = 13, SKU = "UA-HG-WHT-L", Color = "White", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 4, LowStockThreshold = 8 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 39, ItemId = 13, SKU = "UA-HG-RYL-S", Color = "Royal Blue", Size = "S", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 8 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 14: Wilson Pro Staff Tennis Racket
                new ItemVariant { Id = 40, ItemId = 14, SKU = "WLN-PS-97-G2", Color = "Black / Red", Size = "Grip 2 (4 1/4)", PriceAdjustment = 0.00m, StockQuantity = 20, LowStockThreshold = 3,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 41, ItemId = 14, SKU = "WLN-PS-97-G3", Color = "Black / Red", Size = "Grip 3 (4 3/8)", PriceAdjustment = 0.00m, StockQuantity = 1, LowStockThreshold = 3 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 42, ItemId = 14, SKU = "WLN-PS-97-G4", Color = "Black / Red", Size = "Grip 4 (4 1/2)", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 3,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },

                // Item 15: Decathlon Yoga Mat 8mm
                new ItemVariant { Id = 43, ItemId = 15, SKU = "DEC-YM-PNK-8M", Color = "Pastel Pink", Size = "8mm Thick", PriceAdjustment = 0.00m, StockQuantity = 70, LowStockThreshold = 10,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 44, ItemId = 15, SKU = "DEC-YM-PPL-8M", Color = "Purple", Size = "8mm Thick", PriceAdjustment = 0.00m, StockQuantity = 5, LowStockThreshold = 10,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 45, ItemId = 15, SKU = "DEC-YM-GRN-8M", Color = "Mint Green", Size = "8mm Thick", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 10 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},


                // =========================================================
                // CATEGORY 4: BEAUTY (Items 16 to 20)
                // =========================================================

                // Item 16: L'Oréal Revitalift Hyaluronic Acid Serum
                new ItemVariant { Id = 46, ItemId = 16, SKU = "LOR-REV-SER-30", Color = "Clear", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 80, LowStockThreshold = 10 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 47, ItemId = 16, SKU = "LOR-REV-SER-50", Color = "Clear", Size = "50ml", PriceAdjustment = 300.00m, StockQuantity = 4, LowStockThreshold = 10 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 48, ItemId = 16, SKU = "LOR-REV-SER-100", Color = "Clear", Size = "100ml", PriceAdjustment = 750.00m, StockQuantity = 0, LowStockThreshold = 10 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 17: The Ordinary Niacinamide 10% + Zinc 1%
                new ItemVariant { Id = 49, ItemId = 17, SKU = "ORD-NIA-30ML", Color = "Translucent", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 100, LowStockThreshold = 15 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 50, ItemId = 17, SKU = "ORD-NIA-60ML", Color = "Translucent", Size = "60ml", PriceAdjustment = 250.00m, StockQuantity = 5, LowStockThreshold = 15,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 51, ItemId = 17, SKU = "ORD-NIA-100ML", Color = "Translucent", Size = "100ml", PriceAdjustment = 500.00m, StockQuantity = 0, LowStockThreshold = 15 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},

                // Item 18: CeraVe Hydrating Facial Cleanser
                new ItemVariant { Id = 52, ItemId = 18, SKU = "CRV-CLN-236ML", Color = "White", Size = "236ml", PriceAdjustment = 0.00m, StockQuantity = 65, LowStockThreshold = 8,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 53, ItemId = 18, SKU = "CRV-CLN-473ML", Color = "White", Size = "473ml", PriceAdjustment = 200.00m, StockQuantity = 2, LowStockThreshold = 8 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 54, ItemId = 18, SKU = "CRV-CLN-1000ML", Color = "White", Size = "1 Litre", PriceAdjustment = 550.00m, StockQuantity = 0, LowStockThreshold = 8,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },

                // Item 19: Maybelline Lash Sensational Mascara
                new ItemVariant { Id = 55, ItemId = 19, SKU = "MAY-MSK-VBLK", Color = "Very Black", Size = "9.5ml", PriceAdjustment = 0.00m, StockQuantity = 90, LowStockThreshold = 10,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 56, ItemId = 19, SKU = "MAY-MSK-WPR", Color = "Waterproof Black", Size = "9.5ml", PriceAdjustment = 50.00m, StockQuantity = 3, LowStockThreshold = 10,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 57, ItemId = 19, SKU = "MAY-MSK-BRN", Color = "Brownish Black", Size = "9.5ml", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 10,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },

                // Item 20: MAC Matte Lipstick
                new ItemVariant { Id = 58, ItemId = 20, SKU = "MAC-LST-RUBY", Color = "Ruby Woo", Size = "3g", PriceAdjustment = 0.00m, StockQuantity = 45, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 59, ItemId = 20, SKU = "MAC-LST-VELV", Color = "Velvet Teddy", Size = "3g", PriceAdjustment = 0.00m, StockQuantity = 2, LowStockThreshold = 5 ,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder"},
                new ItemVariant { Id = 60, ItemId = 20, SKU = "MAC-LST-CHLI", Color = "Chili", Size = "3g", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" }
            };

            modelBuilder.Entity<ItemVariant>().HasData(variants);

            #endregion

            #region 2. Seed ItemPhotos

            var photos = new List<ItemPhoto>
            {
                new ItemPhoto { Id = 1, ItemId = 1, PhotoUrl = "https://images.unsplash.com/photo-1695048133142-1a20484d2569?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 2, ItemId = 2, PhotoUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 3, ItemId = 3, PhotoUrl = "https://images.unsplash.com/photo-1544244015-0df4b3ffc6b0?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 4, ItemId = 4, PhotoUrl = "https://images.unsplash.com/photo-1600294037681-c80b4cb5b434?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 5, ItemId = 5, PhotoUrl = "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 6, ItemId = 6, PhotoUrl = "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 7, ItemId = 7, PhotoUrl = "https://images.unsplash.com/photo-1580910051074-3eb694886505?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 8, ItemId = 8, PhotoUrl = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 9, ItemId = 9, PhotoUrl = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 10, ItemId = 10, PhotoUrl = "https://images.unsplash.com/photo-1606813907291-d86efa9b94db?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 11, ItemId = 11, PhotoUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 12, ItemId = 12, PhotoUrl = "https://images.unsplash.com/photo-1593784991095-a205069470b6?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 13, ItemId = 13, PhotoUrl = "https://images.unsplash.com/photo-1516035069371-29a1b244cc32?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 14, ItemId = 14, PhotoUrl = "https://images.unsplash.com/photo-1588872657578-7efd1f1555ed?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 15, ItemId = 15, PhotoUrl = "https://images.unsplash.com/photo-1603302576837-37561b2e2302?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 16, ItemId = 16, PhotoUrl = "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 17, ItemId = 17, PhotoUrl = "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 18, ItemId = 18, PhotoUrl = "https://images.unsplash.com/photo-1611186871348-b1ce696e52c9?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 19, ItemId = 19, PhotoUrl = "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 20, ItemId = 20, PhotoUrl = "https://images.unsplash.com/photo-1531297484001-80022131f5a1?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 21, ItemId = 21, PhotoUrl = "https://images.unsplash.com/photo-1561154464-82e9adf32764?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 22, ItemId = 22, PhotoUrl = "https://images.unsplash.com/photo-1584622650111-993a426fbf0a?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 23, ItemId = 23, PhotoUrl = "https://images.unsplash.com/photo-1461151304267-38535e780c79?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 24, ItemId = 24, PhotoUrl = "https://images.unsplash.com/photo-1626806787461-102c1bfaaea1?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 25, ItemId = 25, PhotoUrl = "https://images.unsplash.com/photo-1547082299-de196ea013d6?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 26, ItemId = 26, PhotoUrl = "https://images.unsplash.com/photo-1571175443880-49e1d25b2bc5?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 27, ItemId = 27, PhotoUrl = "https://images.unsplash.com/photo-1574269909862-7e1d70bb8078?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 28, ItemId = 28, PhotoUrl = "https://images.unsplash.com/photo-1585771724684-38269d6639fd?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 29, ItemId = 29, PhotoUrl = "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

            new ItemPhoto { Id = 30, ItemId = 30, PhotoUrl = "https://images.unsplash.com/photo-1551028719-00167b16eac5?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 31, ItemId = 31, PhotoUrl = "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 32, ItemId = 32, PhotoUrl = "https://images.unsplash.com/photo-1598033129183-c4f50c736f10?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 33, ItemId = 33, PhotoUrl = "https://images.unsplash.com/photo-1595777457583-95e059d581b8?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 34, ItemId = 34, PhotoUrl = "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 35, ItemId = 35, PhotoUrl = "https://images.unsplash.com/photo-1541099649105-f69ad21f3246?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 36, ItemId = 36, PhotoUrl = "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 37, ItemId = 37, PhotoUrl = "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 38, ItemId = 38, PhotoUrl = "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 39, ItemId = 39, PhotoUrl = "https://images.unsplash.com/photo-1544441893-675973e31985?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 40, ItemId = 40, PhotoUrl = "https://images.unsplash.com/photo-1552902865-b72c031ac5ea?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 41, ItemId = 41, PhotoUrl = "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 42, ItemId = 42, PhotoUrl = "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 43, ItemId = 43, PhotoUrl = "https://images.unsplash.com/photo-1607522370275-f14206abe5d3?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 44, ItemId = 44, PhotoUrl = "https://images.unsplash.com/photo-1578587018452-892bacefd3f2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 45, ItemId = 45, PhotoUrl = "https://images.unsplash.com/photo-1515886657613-9f3515b0c78f?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 46, ItemId = 46, PhotoUrl = "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 47, ItemId = 47, PhotoUrl = "https://images.unsplash.com/photo-1509631179647-0177331693ae?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 48, ItemId = 48, PhotoUrl = "https://images.unsplash.com/photo-1579338559194-a162d19bf842?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 49, ItemId = 49, PhotoUrl = "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 50, ItemId = 50, PhotoUrl = "https://images.unsplash.com/photo-1625910513413-5fc40e34c264?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 51, ItemId = 51, PhotoUrl = "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 52, ItemId = 52, PhotoUrl = "https://images.unsplash.com/photo-1548883354-7622d03aca27?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 53, ItemId = 53, PhotoUrl = "https://images.unsplash.com/photo-1542272604-780c36856d61?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 54, ItemId = 54, PhotoUrl = "https://images.unsplash.com/photo-1583743814966-8936f5b7be1a?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 55, ItemId = 55, PhotoUrl = "https://images.unsplash.com/photo-1503342217505-b0a15ec3261c?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 56, ItemId = 56, PhotoUrl = "https://images.unsplash.com/photo-1565084888279-aca607ecce0c?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 57, ItemId = 57, PhotoUrl = "https://images.unsplash.com/photo-1583743814966-8936f5b7be1a?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 58, ItemId = 58, PhotoUrl = "https://images.unsplash.com/photo-1581655353564-df123a1eb820?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 59, ItemId = 59, PhotoUrl = "https://images.unsplash.com/photo-1511556532299-8f662fc26c06?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 60, ItemId = 60, PhotoUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 61, ItemId = 61, PhotoUrl = "https://images.unsplash.com/photo-1506629082925-23688b0729fe?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 62, ItemId = 62, PhotoUrl = "https://images.unsplash.com/photo-1539185441755-769473a23570?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 63, ItemId = 63, PhotoUrl = "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 64, ItemId = 64, PhotoUrl = "https://images.unsplash.com/photo-1515886657613-9f3515b0c78f?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 65, ItemId = 65, PhotoUrl = "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 66, ItemId = 66, PhotoUrl = "https://images.unsplash.com/photo-1504280390367-361c6d9f38f4?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 67, ItemId = 67, PhotoUrl = "https://images.unsplash.com/photo-1583454110551-21f2fa2afe61?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 68, ItemId = 68, PhotoUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 69, ItemId = 69, PhotoUrl = "https://images.unsplash.com/photo-1510017803434-a899398421b3?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 70, ItemId = 70, PhotoUrl = "https://images.unsplash.com/photo-1539185441755-769473a23570?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 71, ItemId = 71, PhotoUrl = "https://images.unsplash.com/photo-1551107696-a4b0c5a0d9a2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 72, ItemId = 72, PhotoUrl = "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 73, ItemId = 73, PhotoUrl = "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 74, ItemId = 74, PhotoUrl = "https://images.unsplash.com/photo-1544441893-675973e31985?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 75, ItemId = 75, PhotoUrl = "https://images.unsplash.com/photo-1578587018452-892bacefd3f2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 76, ItemId = 76, PhotoUrl = "https://images.unsplash.com/photo-1520639888713-7851133b1ed0?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 77, ItemId = 77, PhotoUrl = "https://images.unsplash.com/photo-1517841905240-472988babdf9?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 78, ItemId = 78, PhotoUrl = "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 79, ItemId = 79, PhotoUrl = "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 80, ItemId = 80, PhotoUrl = "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 81, ItemId = 81, PhotoUrl = "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 82, ItemId = 82, PhotoUrl = "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 83, ItemId = 83, PhotoUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 84, ItemId = 84, PhotoUrl = "https://images.unsplash.com/photo-1607522370275-f14206abe5d3?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 85, ItemId = 85, PhotoUrl = "https://images.unsplash.com/photo-1520639888713-7851133b1ed0?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

            new ItemPhoto { Id = 86, ItemId = 86, PhotoUrl = "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 87, ItemId = 87, PhotoUrl = "https://images.unsplash.com/photo-1522337360788-8b13dee7a37e?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 88, ItemId = 88, PhotoUrl = "https://images.unsplash.com/photo-1535585209827-a15fcdbc4c2d?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 89, ItemId = 89, PhotoUrl = "https://images.unsplash.com/photo-1631214524020-7e18db9a8f9d?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 90, ItemId = 90, PhotoUrl = "https://images.unsplash.com/photo-1560700146-7c0137a8b3f2?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 91, ItemId = 91, PhotoUrl = "https://images.unsplash.com/photo-1608248597349-f06b6b55dbdf?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 92, ItemId = 92, PhotoUrl = "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 93, ItemId = 93, PhotoUrl = "https://images.unsplash.com/photo-1616683693504-3ea7e9ad6fec?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 94, ItemId = 94, PhotoUrl = "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 95, ItemId = 95, PhotoUrl = "https://images.unsplash.com/photo-1608248597259-be160f25e982?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 96, ItemId = 96, PhotoUrl = "https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 97, ItemId = 97, PhotoUrl = "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 98, ItemId = 98, PhotoUrl = "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 99, ItemId = 99, PhotoUrl = "https://images.unsplash.com/photo-1522337360788-8b13dee7a37e?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 100, ItemId = 100, PhotoUrl = "https://images.unsplash.com/photo-1616683693504-3ea7e9ad6fec?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 101, ItemId = 101, PhotoUrl = "https://images.unsplash.com/photo-1590156206657-19d08e5a73e1?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 102, ItemId = 102, PhotoUrl = "https://images.unsplash.com/photo-1608248597259-be160f25e982?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 103, ItemId = 103, PhotoUrl = "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 104, ItemId = 104, PhotoUrl = "https://images.unsplash.com/photo-1619451334792-150fd785ee74?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 105, ItemId = 105, PhotoUrl = "https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 106, ItemId = 106, PhotoUrl = "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 107, ItemId = 107, PhotoUrl = "https://images.unsplash.com/photo-1608248597349-f06b6b55dbdf?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 108, ItemId = 108, PhotoUrl = "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 109, ItemId = 109, PhotoUrl = "https://images.unsplash.com/photo-1616683693504-3ea7e9ad6fec?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 110, ItemId = 110, PhotoUrl = "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 111, ItemId = 111, PhotoUrl = "https://images.unsplash.com/photo-1608248597349-f06b6b55dbdf?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 112, ItemId = 112, PhotoUrl = "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
            new ItemPhoto { Id = 113, ItemId = 113, PhotoUrl = "https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?w=500&auto=format&fit=crop", CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" }
                        };

            modelBuilder.Entity<ItemPhoto>().HasData(photos);

            #endregion
        }
    }
}
