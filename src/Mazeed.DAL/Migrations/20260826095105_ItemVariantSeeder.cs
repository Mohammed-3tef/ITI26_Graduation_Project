using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ItemVariantSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ItemPhotos",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ItemId", "PhotoUrl", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 1L, "https://images.unsplash.com/photo-1695048133142-1a20484d2569?w=500&auto=format&fit=crop", null, null },
                    { 2L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 1L, "https://images.unsplash.com/photo-1695048133021-32c0d5001306?w=500&auto=format&fit=crop", null, null },
                    { 3L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 2L, "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?w=500&auto=format&fit=crop", null, null },
                    { 4L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 2L, "https://images.unsplash.com/photo-1580910051074-3eb694886505?w=500&auto=format&fit=crop", null, null },
                    { 5L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 3L, "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=500&auto=format&fit=crop", null, null },
                    { 6L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 3L, "https://images.unsplash.com/photo-1611186871348-b1ce696e52c9?w=500&auto=format&fit=crop", null, null },
                    { 7L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 4L, "https://images.unsplash.com/photo-1593784991095-a205069470b6?w=500&auto=format&fit=crop", null, null },
                    { 8L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 5L, "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&auto=format&fit=crop", null, null },
                    { 9L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 6L, "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?w=500&auto=format&fit=crop", null, null },
                    { 10L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 7L, "https://images.unsplash.com/photo-1542272604-780c36856d66?w=500&auto=format&fit=crop", null, null },
                    { 11L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 8L, "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", null, null },
                    { 12L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 9L, "https://images.unsplash.com/photo-1544441893-675973e31985?w=500&auto=format&fit=crop", null, null },
                    { 13L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 10L, "https://images.unsplash.com/photo-1591195853828-11db59a44f6b?w=500&auto=format&fit=crop", null, null },
                    { 14L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 11L, "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=500&auto=format&fit=crop", null, null },
                    { 15L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 12L, "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=500&auto=format&fit=crop", null, null },
                    { 16L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 13L, "https://images.unsplash.com/photo-1518310383802-640c2de311b2?w=500&auto=format&fit=crop", null, null },
                    { 17L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 14L, "https://images.unsplash.com/photo-1622279457486-62dcc4a431d6?w=500&auto=format&fit=crop", null, null },
                    { 18L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 15L, "https://images.unsplash.com/photo-1601925260368-ae2f83cf8b7f?w=500&auto=format&fit=crop", null, null },
                    { 19L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 16L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", null, null },
                    { 20L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 17L, "https://images.unsplash.com/photo-1608248597261-5421d55ab585?w=500&auto=format&fit=crop", null, null },
                    { 21L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 18L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", null, null },
                    { 22L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 19L, "https://images.unsplash.com/photo-1560700146-1c4354911984?w=500&auto=format&fit=crop", null, null },
                    { 23L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 20L, "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&auto=format&fit=crop", null, null }
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 26, 9, 51, 2, 52, DateTimeKind.Utc).AddTicks(2520), "AQAAAAIAAYagAAAAELV0JWJq0Z0XmVEYA5lVzVRQWDLQzcPu8PP+w1OhLts3a0Z6GYaAwSUcPySsNlAkJQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 26, 8, 56, 16, 695, DateTimeKind.Utc).AddTicks(8984), "AQAAAAIAAYagAAAAEPwCcGROqW5KggHpi+ZEFiFmFV58OBEsW+Vs8CuZ0na/j+lsSfrxtBcBLzEQzp9xDg==" });
        }
    }
}
