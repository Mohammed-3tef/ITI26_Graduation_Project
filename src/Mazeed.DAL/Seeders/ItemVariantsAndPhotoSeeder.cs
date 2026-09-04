
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
                new ItemVariant { Id = 60, ItemId = 20, SKU = "MAC-LST-CHLI", Color = "Chili", Size = "3g", PriceAdjustment = 0.00m, StockQuantity = 0, LowStockThreshold = 5,CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),CreatedBy = "SystemSeeder" },
                // Continuation of ItemVariants after Item 20.
// Paste these entries inside the existing `var variants = new List<ItemVariant> { ... };`

                // Item 21: Tab P12 Pro
                new ItemVariant { Id = 61, ItemId = 21, SKU = "LNV-TP12P-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 62, ItemId = 21, SKU = "LNV-TP12P-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 63, ItemId = 21, SKU = "LNV-TP12P-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 22: InstaView Refrigerator 26 cu.ft
                new ItemVariant { Id = 64, ItemId = 22, SKU = "LG-REF26-SILV-500L", Color = "Silver", Size = "500L", PriceAdjustment = 0.00m, StockQuantity = 18, LowStockThreshold = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 65, ItemId = 22, SKU = "LG-REF26-BLAC-600L", Color = "Black", Size = "600L", PriceAdjustment = 7000.00m, StockQuantity = 5, LowStockThreshold = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 66, ItemId = 22, SKU = "LG-REF26-STAI-700L", Color = "Stainless Steel", Size = "700L", PriceAdjustment = 14000.00m, StockQuantity = 1, LowStockThreshold = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 23: C3 65\" OLED evo 4K TV
                new ItemVariant { Id = 67, ItemId = 23, SKU = "LG-C365-BLAC-55INCH", Color = "Black", Size = "55 Inch", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 68, ItemId = 23, SKU = "LG-C365-BLAC-65INCH", Color = "Black", Size = "65 Inch", PriceAdjustment = 9000.00m, StockQuantity = 6, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 69, ItemId = 23, SKU = "LG-C365-BLAC-75INCH", Color = "Black", Size = "75 Inch", PriceAdjustment = 18000.00m, StockQuantity = 1, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 24: WashTower Laundry Hub
                new ItemVariant { Id = 70, ItemId = 24, SKU = "LG-WASH1-WHIT-8KG", Color = "White", Size = "8kg", PriceAdjustment = 0.00m, StockQuantity = 15, LowStockThreshold = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 71, ItemId = 24, SKU = "LG-WASH1-SILV-10KG", Color = "Silver", Size = "10kg", PriceAdjustment = 5000.00m, StockQuantity = 5, LowStockThreshold = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 72, ItemId = 24, SKU = "LG-WASH1-GRAP-12KG", Color = "Graphite", Size = "12kg", PriceAdjustment = 10000.00m, StockQuantity = 1, LowStockThreshold = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 25: UltraGear 34\" Curved Gaming Monitor
                new ItemVariant { Id = 73, ItemId = 25, SKU = "LG-34UG-BLAC-27INCH", Color = "Black", Size = "27 Inch", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 74, ItemId = 25, SKU = "LG-34UG-BLAC-32INCH", Color = "Black", Size = "32 Inch", PriceAdjustment = 4500.00m, StockQuantity = 8, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 75, ItemId = 25, SKU = "LG-34UG-BLAC-34INCH", Color = "Black", Size = "34 Inch", PriceAdjustment = 9000.00m, StockQuantity = 2, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 26: 4-Door French Door Refrigerator
                new ItemVariant { Id = 76, ItemId = 26, SKU = "SHP-REF4D-SILV-500L", Color = "Silver", Size = "500L", PriceAdjustment = 0.00m, StockQuantity = 18, LowStockThreshold = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 77, ItemId = 26, SKU = "SHP-REF4D-BLAC-600L", Color = "Black", Size = "600L", PriceAdjustment = 7000.00m, StockQuantity = 5, LowStockThreshold = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 78, ItemId = 26, SKU = "SHP-REF4D-STAI-700L", Color = "Stainless Steel", Size = "700L", PriceAdjustment = 14000.00m, StockQuantity = 1, LowStockThreshold = 3, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 27: Microwave Oven with Grill 34L
                new ItemVariant { Id = 79, ItemId = 27, SKU = "SHP-MW34L-SILV-25L", Color = "Silver", Size = "25L", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 80, ItemId = 27, SKU = "SHP-MW34L-BLAC-34L", Color = "Black", Size = "34L", PriceAdjustment = 800.00m, StockQuantity = 7, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 81, ItemId = 27, SKU = "SHP-MW34L-STAI-42L", Color = "Stainless Steel", Size = "42L", PriceAdjustment = 1800.00m, StockQuantity = 2, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 28: Plasmacluster Air Purifier
                new ItemVariant { Id = 82, ItemId = 28, SKU = "SHP-AP50-WHIT-SMALL", Color = "White", Size = "Small", PriceAdjustment = 0.00m, StockQuantity = 20, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 83, ItemId = 28, SKU = "SHP-AP50-WHIT-MEDIUM", Color = "White", Size = "Medium", PriceAdjustment = 1500.00m, StockQuantity = 6, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 84, ItemId = 28, SKU = "SHP-AP50-BLAC-LARGE", Color = "Black", Size = "Large", PriceAdjustment = 3000.00m, StockQuantity = 1, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 29: AQUOS 55\" 4K UHD Smart TV
                new ItemVariant { Id = 85, ItemId = 29, SKU = "SHP-AQ55-BLAC-55INCH", Color = "Black", Size = "55 Inch", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 86, ItemId = 29, SKU = "SHP-AQ55-BLAC-65INCH", Color = "Black", Size = "65 Inch", PriceAdjustment = 9000.00m, StockQuantity = 6, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 87, ItemId = 29, SKU = "SHP-AQ55-BLAC-75INCH", Color = "Black", Size = "75 Inch", PriceAdjustment = 18000.00m, StockQuantity = 1, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 30: Oversized Faux Leather Jacket
                new ItemVariant { Id = 88, ItemId = 30, SKU = "ZRA-JKT01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 89, ItemId = 30, SKU = "ZRA-JKT01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 90, ItemId = 30, SKU = "ZRA-JKT01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 31: Pleated Wide Leg Trousers
                new ItemVariant { Id = 91, ItemId = 31, SKU = "ZRA-TR01-BLAC-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 92, ItemId = 31, SKU = "ZRA-TR01-DARK-L", Color = "Dark Blue", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 93, ItemId = 31, SKU = "ZRA-TR01-GREY-XL", Color = "Grey", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 32: 100% Linen Shirt
                new ItemVariant { Id = 94, ItemId = 32, SKU = "ZRA-SHT01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 95, ItemId = 32, SKU = "ZRA-SHT01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 96, ItemId = 32, SKU = "ZRA-SHT01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 33: Satin Effect Midi Dress
                new ItemVariant { Id = 97, ItemId = 33, SKU = "ZRA-DRS01-BLAC-S", Color = "Black", Size = "S", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 98, ItemId = 33, SKU = "ZRA-DRS01-BURG-M", Color = "Burgundy", Size = "M", PriceAdjustment = 300.00m, StockQuantity = 6, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 99, ItemId = 33, SKU = "ZRA-DRS01-EMER-L", Color = "Emerald", Size = "L", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 34: Relaxed Fit Hoodie
                new ItemVariant { Id = 100, ItemId = 34, SKU = "HM-HD01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 101, ItemId = 34, SKU = "HM-HD01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 102, ItemId = 34, SKU = "HM-HD01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 35: Slim Fit Stretch Jeans
                new ItemVariant { Id = 103, ItemId = 35, SKU = "HM-JN01-BLAC-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 104, ItemId = 35, SKU = "HM-JN01-DARK-L", Color = "Dark Blue", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 105, ItemId = 35, SKU = "HM-JN01-GREY-XL", Color = "Grey", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 36: Oversized Cotton T-Shirt
                new ItemVariant { Id = 106, ItemId = 36, SKU = "HM-TS01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 107, ItemId = 36, SKU = "HM-TS01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 108, ItemId = 36, SKU = "HM-TS01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 37: Fine-knit Cardigan
                new ItemVariant { Id = 109, ItemId = 37, SKU = "HM-CD01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 110, ItemId = 37, SKU = "HM-CD01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 111, ItemId = 37, SKU = "HM-CD01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 38: Air Force 1 '07
                new ItemVariant { Id = 112, ItemId = 38, SKU = "NKE-AF1-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 113, ItemId = 38, SKU = "NKE-AF1-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 114, ItemId = 38, SKU = "NKE-AF1-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 39: Tech Fleece Windrunner
                new ItemVariant { Id = 115, ItemId = 39, SKU = "NKE-TFWR-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 116, ItemId = 39, SKU = "NKE-TFWR-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 117, ItemId = 39, SKU = "NKE-TFWR-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 40: Sportswear Club Fleece Joggers
                new ItemVariant { Id = 118, ItemId = 40, SKU = "NKE-JOG01-BLAC-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 119, ItemId = 40, SKU = "NKE-JOG01-DARK-L", Color = "Dark Blue", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 120, ItemId = 40, SKU = "NKE-JOG01-GREY-XL", Color = "Grey", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 41: Dunk Low Retro
                new ItemVariant { Id = 121, ItemId = 41, SKU = "NKE-DNK-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 122, ItemId = 41, SKU = "NKE-DNK-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 123, ItemId = 41, SKU = "NKE-DNK-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 42: Ultraboost Light Shoes
                new ItemVariant { Id = 124, ItemId = 42, SKU = "ADI-UBL-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 125, ItemId = 42, SKU = "ADI-UBL-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 126, ItemId = 42, SKU = "ADI-UBL-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 43: Samba OG Shoes
                new ItemVariant { Id = 127, ItemId = 43, SKU = "ADI-SMB-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 128, ItemId = 43, SKU = "ADI-SMB-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 129, ItemId = 43, SKU = "ADI-SMB-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 44: Adicolor Classics Track Jacket
                new ItemVariant { Id = 130, ItemId = 44, SKU = "ADI-TRK-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 131, ItemId = 44, SKU = "ADI-TRK-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 132, ItemId = 44, SKU = "ADI-TRK-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 45: Tiro 23 League Pants
                new ItemVariant { Id = 133, ItemId = 45, SKU = "ADI-TIRO-BLAC-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 134, ItemId = 45, SKU = "ADI-TIRO-DARK-L", Color = "Dark Blue", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 135, ItemId = 45, SKU = "ADI-TIRO-GREY-XL", Color = "Grey", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 46: Suede Classic XXI Sneakers
                new ItemVariant { Id = 136, ItemId = 46, SKU = "PMA-SUD-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 137, ItemId = 46, SKU = "PMA-SUD-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 138, ItemId = 46, SKU = "PMA-SUD-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 47: T7 Track Jacket
                new ItemVariant { Id = 139, ItemId = 47, SKU = "PMA-T7JKT-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 140, ItemId = 47, SKU = "PMA-T7JKT-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 141, ItemId = 47, SKU = "PMA-T7JKT-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 48: MB.03 Basketball Shoes
                new ItemVariant { Id = 142, ItemId = 48, SKU = "PMA-MB03-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 143, ItemId = 48, SKU = "PMA-MB03-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 144, ItemId = 48, SKU = "PMA-MB03-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 49: Essentials Logo Hoodie
                new ItemVariant { Id = 145, ItemId = 49, SKU = "PMA-HD01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 146, ItemId = 49, SKU = "PMA-HD01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 147, ItemId = 49, SKU = "PMA-HD01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 50: Classic Polo Shirt
                new ItemVariant { Id = 148, ItemId = 50, SKU = "TH-POLO-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 149, ItemId = 50, SKU = "TH-POLO-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 150, ItemId = 50, SKU = "TH-POLO-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 51: Essential Leather Sneaker
                new ItemVariant { Id = 151, ItemId = 51, SKU = "TH-SNK-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 152, ItemId = 51, SKU = "TH-SNK-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 153, ItemId = 51, SKU = "TH-SNK-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 52: Lightweight Down Jacket
                new ItemVariant { Id = 154, ItemId = 52, SKU = "TH-JKT-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 155, ItemId = 52, SKU = "TH-JKT-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 156, ItemId = 52, SKU = "TH-JKT-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 53: Denton Straight Fit Jeans
                new ItemVariant { Id = 157, ItemId = 53, SKU = "TH-JN01-BLAC-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 158, ItemId = 53, SKU = "TH-JN01-DARK-L", Color = "Dark Blue", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 159, ItemId = 53, SKU = "TH-JN01-GREY-XL", Color = "Grey", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 54: Modern Cotton Bralette
                new ItemVariant { Id = 160, ItemId = 54, SKU = "CK-BR01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 161, ItemId = 54, SKU = "CK-BR01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 162, ItemId = 54, SKU = "CK-BR01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 55: Monogram Logo T-Shirt
                new ItemVariant { Id = 163, ItemId = 55, SKU = "CK-TS01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 164, ItemId = 55, SKU = "CK-TS01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 165, ItemId = 55, SKU = "CK-TS01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 56: 90s Straight Denim Jeans
                new ItemVariant { Id = 166, ItemId = 56, SKU = "CK-JN90-BLAC-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 167, ItemId = 56, SKU = "CK-JN90-DARK-L", Color = "Dark Blue", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 168, ItemId = 56, SKU = "CK-JN90-GREY-XL", Color = "Grey", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 57: 3-Pack Cotton Stretch Boxer Briefs
                new ItemVariant { Id = 169, ItemId = 57, SKU = "CK-BX3P-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 170, ItemId = 57, SKU = "CK-BX3P-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 171, ItemId = 57, SKU = "CK-BX3P-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 58: UA Tech 2.0 Short Sleeve
                new ItemVariant { Id = 172, ItemId = 58, SKU = "UA-TS20-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 173, ItemId = 58, SKU = "UA-TS20-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 174, ItemId = 58, SKU = "UA-TS20-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 59: Curry 11 Basketball Shoes
                new ItemVariant { Id = 175, ItemId = 59, SKU = "UA-CUR11-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 176, ItemId = 59, SKU = "UA-CUR11-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 177, ItemId = 59, SKU = "UA-CUR11-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 60: Hustle 5.0 Backpack
                new ItemVariant { Id = 178, ItemId = 60, SKU = "UA-BP50-BLAC-20L", Color = "Black", Size = "20L", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 179, ItemId = 60, SKU = "UA-BP50-NAVY-25L", Color = "Navy", Size = "25L", PriceAdjustment = 500.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 180, ItemId = 60, SKU = "UA-BP50-GREY-30L", Color = "Grey", Size = "30L", PriceAdjustment = 800.00m, StockQuantity = 2, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 61: HeatGear Armour Compression Leggings
                new ItemVariant { Id = 181, ItemId = 61, SKU = "UA-HGLEG-BLAC-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 182, ItemId = 61, SKU = "UA-HGLEG-DARK-L", Color = "Dark Blue", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 183, ItemId = 61, SKU = "UA-HGLEG-GREY-XL", Color = "Grey", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 62: Club C 85 Vintage Shoes
                new ItemVariant { Id = 184, ItemId = 62, SKU = "RBK-C85-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 185, ItemId = 62, SKU = "RBK-C85-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 186, ItemId = 62, SKU = "RBK-C85-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 63: Nano X4 Training Shoes
                new ItemVariant { Id = 187, ItemId = 63, SKU = "RBK-NX4-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 188, ItemId = 63, SKU = "RBK-NX4-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 189, ItemId = 63, SKU = "RBK-NX4-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 64: Vector Track Pants
                new ItemVariant { Id = 190, ItemId = 64, SKU = "RBK-TRKP-BLAC-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 191, ItemId = 64, SKU = "RBK-TRKP-DARK-L", Color = "Dark Blue", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 192, ItemId = 64, SKU = "RBK-TRKP-GREY-XL", Color = "Grey", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 65: Identity Logo Fleece Hoodie
                new ItemVariant { Id = 193, ItemId = 65, SKU = "RBK-HD01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 194, ItemId = 65, SKU = "RBK-HD01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 195, ItemId = 65, SKU = "RBK-HD01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 66: Quechua 2-Second Camping Tent 3-Person
                new ItemVariant { Id = 196, ItemId = 66, SKU = "DEC-TNT2S-GREE-2PERSO", Color = "Green", Size = "2 Person", PriceAdjustment = 0.00m, StockQuantity = 18, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 197, ItemId = 66, SKU = "DEC-TNT2S-BLUE-3PERSO", Color = "Blue", Size = "3 Person", PriceAdjustment = 1200.00m, StockQuantity = 5, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 198, ItemId = 66, SKU = "DEC-TNT2S-GREY-4PERSO", Color = "Grey", Size = "4 Person", PriceAdjustment = 2200.00m, StockQuantity = 1, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 67: Domyos Adjustable Dumbbell Set 20kg
                new ItemVariant { Id = 199, ItemId = 67, SKU = "DEC-DB20-BLAC-10KG", Color = "Black", Size = "10kg", PriceAdjustment = 0.00m, StockQuantity = 20, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 200, ItemId = 67, SKU = "DEC-DB20-BLAC-20KG", Color = "Black", Size = "20kg", PriceAdjustment = 1000.00m, StockQuantity = 6, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 201, ItemId = 67, SKU = "DEC-DB20-BLAC-30KG", Color = "Black", Size = "30kg", PriceAdjustment = 2200.00m, StockQuantity = 1, LowStockThreshold = 4, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 68: Kalenji Run Cushion Shoes
                new ItemVariant { Id = 202, ItemId = 68, SKU = "DEC-RCS-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 203, ItemId = 68, SKU = "DEC-RCS-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 204, ItemId = 68, SKU = "DEC-RCS-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 69: Kiprun Running GPS Watch
                new ItemVariant { Id = 205, ItemId = 69, SKU = "DEC-GPSW-BLAC-40MM", Color = "Black", Size = "40mm", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 206, ItemId = 69, SKU = "DEC-GPSW-SILV-44MM", Color = "Silver", Size = "44mm", PriceAdjustment = 1500.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 207, ItemId = 69, SKU = "DEC-GPSW-BLUE-44MM", Color = "Blue", Size = "44mm", PriceAdjustment = 2500.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 70: 574 Core Sneakers
                new ItemVariant { Id = 208, ItemId = 70, SKU = "NB-574C-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 209, ItemId = 70, SKU = "NB-574C-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 210, ItemId = 70, SKU = "NB-574C-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 71: 990v6 Made in USA
                new ItemVariant { Id = 211, ItemId = 71, SKU = "NB-990V6-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 212, ItemId = 71, SKU = "NB-990V6-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 213, ItemId = 71, SKU = "NB-990V6-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 72: Fresh Foam X 1080v13
                new ItemVariant { Id = 214, ItemId = 72, SKU = "NB-1080V13-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 215, ItemId = 72, SKU = "NB-1080V13-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 216, ItemId = 72, SKU = "NB-1080V13-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 73: Athletics French Terry Hoodie
                new ItemVariant { Id = 217, ItemId = 73, SKU = "NB-HD01-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 218, ItemId = 73, SKU = "NB-HD01-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 219, ItemId = 73, SKU = "NB-HD01-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 74: Watertight II Rain Jacket
                new ItemVariant { Id = 220, ItemId = 74, SKU = "COL-WT2-WHIT-M", Color = "White", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 221, ItemId = 74, SKU = "COL-WT2-BLAC-L", Color = "Black", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 222, ItemId = 74, SKU = "COL-WT2-NAVY-XL", Color = "Navy", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 75: Steens Mountain Full Zip Fleece
                new ItemVariant { Id = 223, ItemId = 75, SKU = "COL-FLC-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 224, ItemId = 75, SKU = "COL-FLC-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 225, ItemId = 75, SKU = "COL-FLC-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 76: Newton Ridge Plus Hiking Boots
                new ItemVariant { Id = 226, ItemId = 76, SKU = "COL-NTR-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 227, ItemId = 76, SKU = "COL-NTR-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 228, ItemId = 76, SKU = "COL-NTR-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 77: Silver Ridge Utility Pants
                new ItemVariant { Id = 229, ItemId = 77, SKU = "COL-PNT-BLAC-M", Color = "Black", Size = "M", PriceAdjustment = 0.00m, StockQuantity = 30, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 230, ItemId = 77, SKU = "COL-PNT-DARK-L", Color = "Dark Blue", Size = "L", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 231, ItemId = 77, SKU = "COL-PNT-GREY-XL", Color = "Grey", Size = "XL", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 78: Go Walk 6 - Slip-Ins
                new ItemVariant { Id = 232, ItemId = 78, SKU = "SKC-GW6-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 233, ItemId = 78, SKU = "SKC-GW6-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 234, ItemId = 78, SKU = "SKC-GW6-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 79: Arch Fit 2.0 Sneakers
                new ItemVariant { Id = 235, ItemId = 79, SKU = "SKC-AF2-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 236, ItemId = 79, SKU = "SKC-AF2-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 237, ItemId = 79, SKU = "SKC-AF2-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 80: UNO - Stand on Air
                new ItemVariant { Id = 238, ItemId = 80, SKU = "SKC-UNO-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 239, ItemId = 80, SKU = "SKC-UNO-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 240, ItemId = 80, SKU = "SKC-UNO-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 81: D'Lites 4.0 Pro
                new ItemVariant { Id = 241, ItemId = 81, SKU = "SKC-DLT-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 242, ItemId = 81, SKU = "SKC-DLT-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 243, ItemId = 81, SKU = "SKC-DLT-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 82: GEL-KAYANO 30
                new ItemVariant { Id = 244, ItemId = 82, SKU = "ASC-GK30-WHIT-200ML", Color = "White", Size = "200ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 245, ItemId = 82, SKU = "ASC-GK30-WHIT-350ML", Color = "White", Size = "350ml", PriceAdjustment = 200.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 246, ItemId = 82, SKU = "ASC-GK30-WHIT-500ML", Color = "White", Size = "500ml", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 83: GEL-NIMBUS 26
                new ItemVariant { Id = 247, ItemId = 83, SKU = "ASC-GN26-WHIT-200ML", Color = "White", Size = "200ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 248, ItemId = 83, SKU = "ASC-GN26-WHIT-350ML", Color = "White", Size = "350ml", PriceAdjustment = 200.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 249, ItemId = 83, SKU = "ASC-GN26-WHIT-500ML", Color = "White", Size = "500ml", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 84: GT-2000 12
                new ItemVariant { Id = 250, ItemId = 84, SKU = "ASC-GT20-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 251, ItemId = 84, SKU = "ASC-GT20-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 252, ItemId = 84, SKU = "ASC-GT20-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 85: GEL-VENTURE 9 Hiking Shoes
                new ItemVariant { Id = 253, ItemId = 85, SKU = "ASC-GV9-BLAC-41", Color = "Black / White", Size = "41", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 254, ItemId = 85, SKU = "ASC-GV9-BLUE-42", Color = "Blue", Size = "42", PriceAdjustment = 200.00m, StockQuantity = 7, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 255, ItemId = 85, SKU = "ASC-GV9-REDW-44", Color = "Red / White", Size = "44", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 86: Revitalift 1.5% Pure Hyaluronic Acid Serum
                new ItemVariant { Id = 256, ItemId = 86, SKU = "LOR-HA15-CLEA-30ML", Color = "Clear", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 257, ItemId = 86, SKU = "LOR-HA15-CLEA-50ML", Color = "Clear", Size = "50ml", PriceAdjustment = 250.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 258, ItemId = 86, SKU = "LOR-HA15-CLEA-100ML", Color = "Clear", Size = "100ml", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 87: Infallible 24H Fresh Wear Foundation
                new ItemVariant { Id = 259, ItemId = 87, SKU = "LOR-INF24-LIGH-30ML", Color = "Light", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 260, ItemId = 87, SKU = "LOR-INF24-MEDI-30ML", Color = "Medium", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 261, ItemId = 87, SKU = "LOR-INF24-DEEP-30ML", Color = "Deep", Size = "30ml", PriceAdjustment = 100.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 88: Elvive Total Repair 5 Shampoo 400ml
                new ItemVariant { Id = 262, ItemId = 88, SKU = "LOR-ELV400-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 263, ItemId = 88, SKU = "LOR-ELV400-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 264, ItemId = 88, SKU = "LOR-ELV400-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 89: Lash Paradise Mascara Black
                new ItemVariant { Id = 265, ItemId = 89, SKU = "LOR-LASH-VERY-95ML", Color = "Very Black", Size = "9.5ml", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 266, ItemId = 89, SKU = "LOR-LASH-BROW-95ML", Color = "Brown Black", Size = "9.5ml", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 267, ItemId = 89, SKU = "LOR-LASH-WATE-95ML", Color = "Waterproof Black", Size = "9.5ml", PriceAdjustment = 50.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 90: Lash Sensational Sky High Mascara
                new ItemVariant { Id = 268, ItemId = 90, SKU = "MAY-SKYH-VERY-95ML", Color = "Very Black", Size = "9.5ml", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 269, ItemId = 90, SKU = "MAY-SKYH-BROW-95ML", Color = "Brown Black", Size = "9.5ml", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 270, ItemId = 90, SKU = "MAY-SKYH-WATE-95ML", Color = "Waterproof Black", Size = "9.5ml", PriceAdjustment = 50.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 91: Fit Me Matte + Poreless Foundation
                new ItemVariant { Id = 271, ItemId = 91, SKU = "MAY-FITM-PAST-6MM", Color = "Pastel Pink", Size = "6mm", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 272, ItemId = 91, SKU = "MAY-FITM-PURP-8MM", Color = "Purple", Size = "8mm", PriceAdjustment = 300.00m, StockQuantity = 8, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 273, ItemId = 91, SKU = "MAY-FITM-MINT-10MM", Color = "Mint Green", Size = "10mm", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 92: SuperStay Matte Ink Liquid Lipstick
                new ItemVariant { Id = 274, ItemId = 92, SKU = "MAY-SINK-PAST-6MM", Color = "Pastel Pink", Size = "6mm", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 275, ItemId = 92, SKU = "MAY-SINK-PURP-8MM", Color = "Purple", Size = "8mm", PriceAdjustment = 300.00m, StockQuantity = 8, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 276, ItemId = 92, SKU = "MAY-SINK-MINT-10MM", Color = "Mint Green", Size = "10mm", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 93: Instant Age Rewind Eraser Concealer
                new ItemVariant { Id = 277, ItemId = 93, SKU = "MAY-ARWC-LIGH-30ML", Color = "Light", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 278, ItemId = 93, SKU = "MAY-ARWC-MEDI-30ML", Color = "Medium", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 279, ItemId = 93, SKU = "MAY-ARWC-DEEP-30ML", Color = "Deep", Size = "30ml", PriceAdjustment = 100.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 94: Hydrating Facial Cleanser 473ml
                new ItemVariant { Id = 280, ItemId = 94, SKU = "CRV-HFC-WHIT-200ML", Color = "White", Size = "200ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 281, ItemId = 94, SKU = "CRV-HFC-WHIT-350ML", Color = "White", Size = "350ml", PriceAdjustment = 200.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 282, ItemId = 94, SKU = "CRV-HFC-WHIT-500ML", Color = "White", Size = "500ml", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 95: Moisturizing Cream 454g
                new ItemVariant { Id = 283, ItemId = 95, SKU = "CRV-MC454-WHIT-200ML", Color = "White", Size = "200ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 284, ItemId = 95, SKU = "CRV-MC454-WHIT-350ML", Color = "White", Size = "350ml", PriceAdjustment = 200.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 285, ItemId = 95, SKU = "CRV-MC454-WHIT-500ML", Color = "White", Size = "500ml", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 96: AM Facial Moisturizing Lotion SPF 30
                new ItemVariant { Id = 286, ItemId = 96, SKU = "CRV-AM30-WHIT-200ML", Color = "White", Size = "200ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 287, ItemId = 96, SKU = "CRV-AM30-WHIT-350ML", Color = "White", Size = "350ml", PriceAdjustment = 200.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 288, ItemId = 96, SKU = "CRV-AM30-WHIT-500ML", Color = "White", Size = "500ml", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 97: Resurfacing Retinol Serum 30ml
                new ItemVariant { Id = 289, ItemId = 97, SKU = "CRV-RRS-CLEA-30ML", Color = "Clear", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 290, ItemId = 97, SKU = "CRV-RRS-CLEA-50ML", Color = "Clear", Size = "50ml", PriceAdjustment = 250.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 291, ItemId = 97, SKU = "CRV-RRS-CLEA-100ML", Color = "Clear", Size = "100ml", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 98: Matte Lipstick - Ruby Woo
                new ItemVariant { Id = 292, ItemId = 98, SKU = "MAC-RW-PAST-6MM", Color = "Pastel Pink", Size = "6mm", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 293, ItemId = 98, SKU = "MAC-RW-PURP-8MM", Color = "Purple", Size = "8mm", PriceAdjustment = 300.00m, StockQuantity = 8, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 294, ItemId = 98, SKU = "MAC-RW-MINT-10MM", Color = "Mint Green", Size = "10mm", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 99: Studio Fix Fluid SPF 15 Foundation
                new ItemVariant { Id = 295, ItemId = 99, SKU = "MAC-SFF-LIGH-30ML", Color = "Light", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 35, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 296, ItemId = 99, SKU = "MAC-SFF-MEDI-30ML", Color = "Medium", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 7, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 297, ItemId = 99, SKU = "MAC-SFF-DEEP-30ML", Color = "Deep", Size = "30ml", PriceAdjustment = 100.00m, StockQuantity = 1, LowStockThreshold = 8, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 100: Prep + Prime Fix+ Setting Spray 100ml
                new ItemVariant { Id = 298, ItemId = 100, SKU = "MAC-FIXP-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 299, ItemId = 100, SKU = "MAC-FIXP-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 300, ItemId = 100, SKU = "MAC-FIXP-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 101: Mineralize Skinfinish Powder
                new ItemVariant { Id = 301, ItemId = 101, SKU = "MAC-MSF-LIGH-10G", Color = "Light", Size = "10g", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 302, ItemId = 101, SKU = "MAC-MSF-MEDI-10G", Color = "Medium", Size = "10g", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 303, ItemId = 101, SKU = "MAC-MSF-DEEP-10G", Color = "Deep", Size = "10g", PriceAdjustment = 100.00m, StockQuantity = 1, LowStockThreshold = 6, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 102: Nivea Creme Tin 150ml
                new ItemVariant { Id = 304, ItemId = 102, SKU = "NIV-CRM150-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 305, ItemId = 102, SKU = "NIV-CRM150-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 306, ItemId = 102, SKU = "NIV-CRM150-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 103: Naturally Good Body Lotion 350ml
                new ItemVariant { Id = 307, ItemId = 103, SKU = "NIV-NGL350-WHIT-200ML", Color = "White", Size = "200ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 308, ItemId = 103, SKU = "NIV-NGL350-WHIT-350ML", Color = "White", Size = "350ml", PriceAdjustment = 200.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 309, ItemId = 103, SKU = "NIV-NGL350-WHIT-500ML", Color = "White", Size = "500ml", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 104: Black & White Invisible Roll-On 50ml
                new ItemVariant { Id = 310, ItemId = 104, SKU = "NIV-BWRO-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 311, ItemId = 104, SKU = "NIV-BWRO-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 312, ItemId = 104, SKU = "NIV-BWRO-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 105: Q10 Power Anti-Wrinkle Day Cream SPF 15
                new ItemVariant { Id = 313, ItemId = 105, SKU = "NIV-Q10DC-WHIT-200ML", Color = "White", Size = "200ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 314, ItemId = 105, SKU = "NIV-Q10DC-WHIT-350ML", Color = "White", Size = "350ml", PriceAdjustment = 200.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 315, ItemId = 105, SKU = "NIV-Q10DC-WHIT-500ML", Color = "White", Size = "500ml", PriceAdjustment = 400.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 106: Niacinamide 10% + Zinc 1%
                new ItemVariant { Id = 316, ItemId = 106, SKU = "ORD-NIA10-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 317, ItemId = 106, SKU = "ORD-NIA10-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 318, ItemId = 106, SKU = "ORD-NIA10-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 107: Hyaluronic Acid 2% + B5
                new ItemVariant { Id = 319, ItemId = 107, SKU = "ORD-HA2B5-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 320, ItemId = 107, SKU = "ORD-HA2B5-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 321, ItemId = 107, SKU = "ORD-HA2B5-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 108: AHA 30% + BHA 2% Peeling Solution
                new ItemVariant { Id = 322, ItemId = 108, SKU = "ORD-PEEL30-CLEA-30ML", Color = "Clear", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 323, ItemId = 108, SKU = "ORD-PEEL30-CLEA-50ML", Color = "Clear", Size = "50ml", PriceAdjustment = 250.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 324, ItemId = 108, SKU = "ORD-PEEL30-CLEA-100ML", Color = "Clear", Size = "100ml", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 109: Caffeine Solution 5% + EGCG
                new ItemVariant { Id = 325, ItemId = 109, SKU = "ORD-CAF5-CLEA-30ML", Color = "Clear", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 326, ItemId = 109, SKU = "ORD-CAF5-CLEA-50ML", Color = "Clear", Size = "50ml", PriceAdjustment = 250.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 327, ItemId = 109, SKU = "ORD-CAF5-CLEA-100ML", Color = "Clear", Size = "100ml", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 110: Minéral 89 Hyaluronic Acid Booster 50ml
                new ItemVariant { Id = 328, ItemId = 110, SKU = "VCH-M89-CLEA-30ML", Color = "Clear", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 329, ItemId = 110, SKU = "VCH-M89-CLEA-50ML", Color = "Clear", Size = "50ml", PriceAdjustment = 250.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 330, ItemId = 110, SKU = "VCH-M89-CLEA-100ML", Color = "Clear", Size = "100ml", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 111: LiftActiv Vitamin C Serum 20ml
                new ItemVariant { Id = 331, ItemId = 111, SKU = "VCH-LAVITC-CLEA-30ML", Color = "Clear", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 332, ItemId = 111, SKU = "VCH-LAVITC-CLEA-50ML", Color = "Clear", Size = "50ml", PriceAdjustment = 250.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 333, ItemId = 111, SKU = "VCH-LAVITC-CLEA-100ML", Color = "Clear", Size = "100ml", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 112: Normaderm PhytoSolution Cleansing Gel
                new ItemVariant { Id = 334, ItemId = 112, SKU = "VCH-NORM200-CLEA-30ML", Color = "Clear", Size = "30ml", PriceAdjustment = 0.00m, StockQuantity = 40, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 335, ItemId = 112, SKU = "VCH-NORM200-CLEA-50ML", Color = "Clear", Size = "50ml", PriceAdjustment = 250.00m, StockQuantity = 8, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 336, ItemId = 112, SKU = "VCH-NORM200-CLEA-100ML", Color = "Clear", Size = "100ml", PriceAdjustment = 500.00m, StockQuantity = 1, LowStockThreshold = 10, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },

                // Item 113: Capital Soleil UV-Clear Fluid SPF 50+
                new ItemVariant { Id = 337, ItemId = 113, SKU = "VCH-UV50-BLAC-STANDA", Color = "Black", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 25, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 338, ItemId = 113, SKU = "VCH-UV50-WHIT-STANDA", Color = "White", Size = "Standard", PriceAdjustment = 0.00m, StockQuantity = 6, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder" },
                new ItemVariant { Id = 339, ItemId = 113, SKU = "VCH-UV50-BLUE-STANDA", Color = "Blue", Size = "Standard", PriceAdjustment = 200.00m, StockQuantity = 1, LowStockThreshold = 5, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc), CreatedBy = "SystemSeeder"}

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
