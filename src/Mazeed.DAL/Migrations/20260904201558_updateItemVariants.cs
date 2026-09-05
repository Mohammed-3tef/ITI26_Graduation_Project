using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateItemVariants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ItemVariants",
                columns: new[] { "Id", "Color", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ItemId", "LowStockThreshold", "PriceAdjustment", "SKU", "Size", "StockQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 61L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 21L, 5, 0.00m, "LNV-TP12P-BLAC-STANDA", "Standard", 25, null, null },
                    { 62L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 21L, 5, 0.00m, "LNV-TP12P-WHIT-STANDA", "Standard", 6, null, null },
                    { 63L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 21L, 5, 200.00m, "LNV-TP12P-BLUE-STANDA", "Standard", 1, null, null },
                    { 64L, "Silver", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 22L, 3, 0.00m, "LG-REF26-SILV-500L", "500L", 18, null, null },
                    { 65L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 22L, 3, 7000.00m, "LG-REF26-BLAC-600L", "600L", 5, null, null },
                    { 66L, "Stainless Steel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 22L, 3, 14000.00m, "LG-REF26-STAI-700L", "700L", 1, null, null },
                    { 67L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 23L, 4, 0.00m, "LG-C365-BLAC-55INCH", "55 Inch", 25, null, null },
                    { 68L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 23L, 4, 9000.00m, "LG-C365-BLAC-65INCH", "65 Inch", 6, null, null },
                    { 69L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 23L, 4, 18000.00m, "LG-C365-BLAC-75INCH", "75 Inch", 1, null, null },
                    { 70L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 24L, 3, 0.00m, "LG-WASH1-WHIT-8KG", "8kg", 15, null, null },
                    { 71L, "Silver", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 24L, 3, 5000.00m, "LG-WASH1-SILV-10KG", "10kg", 5, null, null },
                    { 72L, "Graphite", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 24L, 3, 10000.00m, "LG-WASH1-GRAP-12KG", "12kg", 1, null, null },
                    { 73L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 25L, 4, 0.00m, "LG-34UG-BLAC-27INCH", "27 Inch", 30, null, null },
                    { 74L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 25L, 4, 4500.00m, "LG-34UG-BLAC-32INCH", "32 Inch", 8, null, null },
                    { 75L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 25L, 4, 9000.00m, "LG-34UG-BLAC-34INCH", "34 Inch", 2, null, null },
                    { 76L, "Silver", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 26L, 3, 0.00m, "SHP-REF4D-SILV-500L", "500L", 18, null, null },
                    { 77L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 26L, 3, 7000.00m, "SHP-REF4D-BLAC-600L", "600L", 5, null, null },
                    { 78L, "Stainless Steel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 26L, 3, 14000.00m, "SHP-REF4D-STAI-700L", "700L", 1, null, null },
                    { 79L, "Silver", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 27L, 4, 0.00m, "SHP-MW34L-SILV-25L", "25L", 25, null, null },
                    { 80L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 27L, 4, 800.00m, "SHP-MW34L-BLAC-34L", "34L", 7, null, null },
                    { 81L, "Stainless Steel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 27L, 4, 1800.00m, "SHP-MW34L-STAI-42L", "42L", 2, null, null },
                    { 82L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 28L, 4, 0.00m, "SHP-AP50-WHIT-SMALL", "Small", 20, null, null },
                    { 83L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 28L, 4, 1500.00m, "SHP-AP50-WHIT-MEDIUM", "Medium", 6, null, null },
                    { 84L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 28L, 4, 3000.00m, "SHP-AP50-BLAC-LARGE", "Large", 1, null, null },
                    { 85L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 29L, 4, 0.00m, "SHP-AQ55-BLAC-55INCH", "55 Inch", 25, null, null },
                    { 86L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 29L, 4, 9000.00m, "SHP-AQ55-BLAC-65INCH", "65 Inch", 6, null, null },
                    { 87L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 29L, 4, 18000.00m, "SHP-AQ55-BLAC-75INCH", "75 Inch", 1, null, null },
                    { 88L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 30L, 8, 0.00m, "ZRA-JKT01-WHIT-M", "M", 35, null, null },
                    { 89L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 30L, 8, 0.00m, "ZRA-JKT01-BLAC-L", "L", 7, null, null },
                    { 90L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 30L, 8, 200.00m, "ZRA-JKT01-NAVY-XL", "XL", 1, null, null },
                    { 91L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 31L, 6, 0.00m, "ZRA-TR01-BLAC-M", "M", 30, null, null },
                    { 92L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 31L, 6, 0.00m, "ZRA-TR01-DARK-L", "L", 7, null, null },
                    { 93L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 31L, 6, 200.00m, "ZRA-TR01-GREY-XL", "XL", 1, null, null },
                    { 94L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 32L, 8, 0.00m, "ZRA-SHT01-WHIT-M", "M", 35, null, null },
                    { 95L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 32L, 8, 0.00m, "ZRA-SHT01-BLAC-L", "L", 7, null, null },
                    { 96L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 32L, 8, 200.00m, "ZRA-SHT01-NAVY-XL", "XL", 1, null, null },
                    { 97L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 33L, 6, 0.00m, "ZRA-DRS01-BLAC-S", "S", 25, null, null },
                    { 98L, "Burgundy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 33L, 6, 300.00m, "ZRA-DRS01-BURG-M", "M", 6, null, null },
                    { 99L, "Emerald", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 33L, 6, 500.00m, "ZRA-DRS01-EMER-L", "L", 1, null, null },
                    { 100L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 34L, 8, 0.00m, "HM-HD01-WHIT-M", "M", 35, null, null },
                    { 101L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 34L, 8, 0.00m, "HM-HD01-BLAC-L", "L", 7, null, null },
                    { 102L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 34L, 8, 200.00m, "HM-HD01-NAVY-XL", "XL", 1, null, null },
                    { 103L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 35L, 6, 0.00m, "HM-JN01-BLAC-M", "M", 30, null, null },
                    { 104L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 35L, 6, 0.00m, "HM-JN01-DARK-L", "L", 7, null, null },
                    { 105L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 35L, 6, 200.00m, "HM-JN01-GREY-XL", "XL", 1, null, null },
                    { 106L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 36L, 8, 0.00m, "HM-TS01-WHIT-M", "M", 35, null, null },
                    { 107L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 36L, 8, 0.00m, "HM-TS01-BLAC-L", "L", 7, null, null },
                    { 108L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 36L, 8, 200.00m, "HM-TS01-NAVY-XL", "XL", 1, null, null },
                    { 109L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 37L, 8, 0.00m, "HM-CD01-WHIT-M", "M", 35, null, null },
                    { 110L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 37L, 8, 0.00m, "HM-CD01-BLAC-L", "L", 7, null, null },
                    { 111L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 37L, 8, 200.00m, "HM-CD01-NAVY-XL", "XL", 1, null, null },
                    { 112L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 38L, 5, 0.00m, "NKE-AF1-BLAC-STANDA", "Standard", 25, null, null },
                    { 113L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 38L, 5, 0.00m, "NKE-AF1-WHIT-STANDA", "Standard", 6, null, null },
                    { 114L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 38L, 5, 200.00m, "NKE-AF1-BLUE-STANDA", "Standard", 1, null, null },
                    { 115L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 39L, 5, 0.00m, "NKE-TFWR-BLAC-STANDA", "Standard", 25, null, null },
                    { 116L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 39L, 5, 0.00m, "NKE-TFWR-WHIT-STANDA", "Standard", 6, null, null },
                    { 117L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 39L, 5, 200.00m, "NKE-TFWR-BLUE-STANDA", "Standard", 1, null, null },
                    { 118L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 40L, 6, 0.00m, "NKE-JOG01-BLAC-M", "M", 30, null, null },
                    { 119L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 40L, 6, 0.00m, "NKE-JOG01-DARK-L", "L", 7, null, null },
                    { 120L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 40L, 6, 200.00m, "NKE-JOG01-GREY-XL", "XL", 1, null, null },
                    { 121L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 41L, 5, 0.00m, "NKE-DNK-BLAC-STANDA", "Standard", 25, null, null },
                    { 122L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 41L, 5, 0.00m, "NKE-DNK-WHIT-STANDA", "Standard", 6, null, null },
                    { 123L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 41L, 5, 200.00m, "NKE-DNK-BLUE-STANDA", "Standard", 1, null, null },
                    { 124L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 42L, 6, 0.00m, "ADI-UBL-BLAC-41", "41", 35, null, null },
                    { 125L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 42L, 6, 200.00m, "ADI-UBL-BLUE-42", "42", 7, null, null },
                    { 126L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 42L, 6, 400.00m, "ADI-UBL-REDW-44", "44", 1, null, null },
                    { 127L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 43L, 6, 0.00m, "ADI-SMB-BLAC-41", "41", 35, null, null },
                    { 128L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 43L, 6, 200.00m, "ADI-SMB-BLUE-42", "42", 7, null, null },
                    { 129L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 43L, 6, 400.00m, "ADI-SMB-REDW-44", "44", 1, null, null },
                    { 130L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 44L, 8, 0.00m, "ADI-TRK-WHIT-M", "M", 35, null, null },
                    { 131L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 44L, 8, 0.00m, "ADI-TRK-BLAC-L", "L", 7, null, null },
                    { 132L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 44L, 8, 200.00m, "ADI-TRK-NAVY-XL", "XL", 1, null, null },
                    { 133L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 45L, 6, 0.00m, "ADI-TIRO-BLAC-M", "M", 30, null, null },
                    { 134L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 45L, 6, 0.00m, "ADI-TIRO-DARK-L", "L", 7, null, null },
                    { 135L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 45L, 6, 200.00m, "ADI-TIRO-GREY-XL", "XL", 1, null, null },
                    { 136L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 46L, 6, 0.00m, "PMA-SUD-BLAC-41", "41", 35, null, null },
                    { 137L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 46L, 6, 200.00m, "PMA-SUD-BLUE-42", "42", 7, null, null },
                    { 138L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 46L, 6, 400.00m, "PMA-SUD-REDW-44", "44", 1, null, null },
                    { 139L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 47L, 8, 0.00m, "PMA-T7JKT-WHIT-M", "M", 35, null, null },
                    { 140L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 47L, 8, 0.00m, "PMA-T7JKT-BLAC-L", "L", 7, null, null },
                    { 141L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 47L, 8, 200.00m, "PMA-T7JKT-NAVY-XL", "XL", 1, null, null },
                    { 142L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 48L, 6, 0.00m, "PMA-MB03-BLAC-41", "41", 35, null, null },
                    { 143L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 48L, 6, 200.00m, "PMA-MB03-BLUE-42", "42", 7, null, null },
                    { 144L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 48L, 6, 400.00m, "PMA-MB03-REDW-44", "44", 1, null, null },
                    { 145L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 49L, 8, 0.00m, "PMA-HD01-WHIT-M", "M", 35, null, null },
                    { 146L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 49L, 8, 0.00m, "PMA-HD01-BLAC-L", "L", 7, null, null },
                    { 147L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 49L, 8, 200.00m, "PMA-HD01-NAVY-XL", "XL", 1, null, null },
                    { 148L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 50L, 8, 0.00m, "TH-POLO-WHIT-M", "M", 35, null, null },
                    { 149L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 50L, 8, 0.00m, "TH-POLO-BLAC-L", "L", 7, null, null },
                    { 150L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 50L, 8, 200.00m, "TH-POLO-NAVY-XL", "XL", 1, null, null },
                    { 151L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 51L, 5, 0.00m, "TH-SNK-BLAC-STANDA", "Standard", 25, null, null },
                    { 152L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 51L, 5, 0.00m, "TH-SNK-WHIT-STANDA", "Standard", 6, null, null },
                    { 153L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 51L, 5, 200.00m, "TH-SNK-BLUE-STANDA", "Standard", 1, null, null },
                    { 154L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 52L, 8, 0.00m, "TH-JKT-WHIT-M", "M", 35, null, null },
                    { 155L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 52L, 8, 0.00m, "TH-JKT-BLAC-L", "L", 7, null, null },
                    { 156L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 52L, 8, 200.00m, "TH-JKT-NAVY-XL", "XL", 1, null, null },
                    { 157L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 53L, 6, 0.00m, "TH-JN01-BLAC-M", "M", 30, null, null },
                    { 158L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 53L, 6, 0.00m, "TH-JN01-DARK-L", "L", 7, null, null },
                    { 159L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 53L, 6, 200.00m, "TH-JN01-GREY-XL", "XL", 1, null, null },
                    { 160L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 54L, 8, 0.00m, "CK-BR01-WHIT-M", "M", 35, null, null },
                    { 161L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 54L, 8, 0.00m, "CK-BR01-BLAC-L", "L", 7, null, null },
                    { 162L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 54L, 8, 200.00m, "CK-BR01-NAVY-XL", "XL", 1, null, null },
                    { 163L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 55L, 8, 0.00m, "CK-TS01-WHIT-M", "M", 35, null, null },
                    { 164L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 55L, 8, 0.00m, "CK-TS01-BLAC-L", "L", 7, null, null },
                    { 165L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 55L, 8, 200.00m, "CK-TS01-NAVY-XL", "XL", 1, null, null },
                    { 166L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 56L, 6, 0.00m, "CK-JN90-BLAC-M", "M", 30, null, null },
                    { 167L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 56L, 6, 0.00m, "CK-JN90-DARK-L", "L", 7, null, null },
                    { 168L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 56L, 6, 200.00m, "CK-JN90-GREY-XL", "XL", 1, null, null },
                    { 169L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 57L, 8, 0.00m, "CK-BX3P-WHIT-M", "M", 35, null, null },
                    { 170L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 57L, 8, 0.00m, "CK-BX3P-BLAC-L", "L", 7, null, null },
                    { 171L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 57L, 8, 200.00m, "CK-BX3P-NAVY-XL", "XL", 1, null, null },
                    { 172L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 58L, 5, 0.00m, "UA-TS20-BLAC-STANDA", "Standard", 25, null, null },
                    { 173L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 58L, 5, 0.00m, "UA-TS20-WHIT-STANDA", "Standard", 6, null, null },
                    { 174L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 58L, 5, 200.00m, "UA-TS20-BLUE-STANDA", "Standard", 1, null, null },
                    { 175L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 59L, 6, 0.00m, "UA-CUR11-BLAC-41", "41", 35, null, null },
                    { 176L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 59L, 6, 200.00m, "UA-CUR11-BLUE-42", "42", 7, null, null },
                    { 177L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 59L, 6, 400.00m, "UA-CUR11-REDW-44", "44", 1, null, null },
                    { 178L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 60L, 6, 0.00m, "UA-BP50-BLAC-20L", "20L", 30, null, null },
                    { 179L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 60L, 6, 500.00m, "UA-BP50-NAVY-25L", "25L", 7, null, null },
                    { 180L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 60L, 6, 800.00m, "UA-BP50-GREY-30L", "30L", 2, null, null },
                    { 181L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 61L, 6, 0.00m, "UA-HGLEG-BLAC-M", "M", 30, null, null },
                    { 182L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 61L, 6, 0.00m, "UA-HGLEG-DARK-L", "L", 7, null, null },
                    { 183L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 61L, 6, 200.00m, "UA-HGLEG-GREY-XL", "XL", 1, null, null },
                    { 184L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 62L, 6, 0.00m, "RBK-C85-BLAC-41", "41", 35, null, null },
                    { 185L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 62L, 6, 200.00m, "RBK-C85-BLUE-42", "42", 7, null, null },
                    { 186L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 62L, 6, 400.00m, "RBK-C85-REDW-44", "44", 1, null, null },
                    { 187L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 63L, 6, 0.00m, "RBK-NX4-BLAC-41", "41", 35, null, null },
                    { 188L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 63L, 6, 200.00m, "RBK-NX4-BLUE-42", "42", 7, null, null },
                    { 189L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 63L, 6, 400.00m, "RBK-NX4-REDW-44", "44", 1, null, null },
                    { 190L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 64L, 6, 0.00m, "RBK-TRKP-BLAC-M", "M", 30, null, null },
                    { 191L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 64L, 6, 0.00m, "RBK-TRKP-DARK-L", "L", 7, null, null },
                    { 192L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 64L, 6, 200.00m, "RBK-TRKP-GREY-XL", "XL", 1, null, null },
                    { 193L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 65L, 8, 0.00m, "RBK-HD01-WHIT-M", "M", 35, null, null },
                    { 194L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 65L, 8, 0.00m, "RBK-HD01-BLAC-L", "L", 7, null, null },
                    { 195L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 65L, 8, 200.00m, "RBK-HD01-NAVY-XL", "XL", 1, null, null },
                    { 196L, "Green", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 66L, 4, 0.00m, "DEC-TNT2S-GREE-2PERSO", "2 Person", 18, null, null },
                    { 197L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 66L, 4, 1200.00m, "DEC-TNT2S-BLUE-3PERSO", "3 Person", 5, null, null },
                    { 198L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 66L, 4, 2200.00m, "DEC-TNT2S-GREY-4PERSO", "4 Person", 1, null, null },
                    { 199L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 67L, 4, 0.00m, "DEC-DB20-BLAC-10KG", "10kg", 20, null, null },
                    { 200L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 67L, 4, 1000.00m, "DEC-DB20-BLAC-20KG", "20kg", 6, null, null },
                    { 201L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 67L, 4, 2200.00m, "DEC-DB20-BLAC-30KG", "30kg", 1, null, null },
                    { 202L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 68L, 6, 0.00m, "DEC-RCS-BLAC-41", "41", 35, null, null },
                    { 203L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 68L, 6, 200.00m, "DEC-RCS-BLUE-42", "42", 7, null, null },
                    { 204L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 68L, 6, 400.00m, "DEC-RCS-REDW-44", "44", 1, null, null },
                    { 205L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 69L, 5, 0.00m, "DEC-GPSW-BLAC-40MM", "40mm", 25, null, null },
                    { 206L, "Silver", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 69L, 5, 1500.00m, "DEC-GPSW-SILV-44MM", "44mm", 6, null, null },
                    { 207L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 69L, 5, 2500.00m, "DEC-GPSW-BLUE-44MM", "44mm", 1, null, null },
                    { 208L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 70L, 6, 0.00m, "NB-574C-BLAC-41", "41", 35, null, null },
                    { 209L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 70L, 6, 200.00m, "NB-574C-BLUE-42", "42", 7, null, null },
                    { 210L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 70L, 6, 400.00m, "NB-574C-REDW-44", "44", 1, null, null },
                    { 211L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 71L, 5, 0.00m, "NB-990V6-BLAC-STANDA", "Standard", 25, null, null },
                    { 212L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 71L, 5, 0.00m, "NB-990V6-WHIT-STANDA", "Standard", 6, null, null },
                    { 213L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 71L, 5, 200.00m, "NB-990V6-BLUE-STANDA", "Standard", 1, null, null },
                    { 214L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 72L, 5, 0.00m, "NB-1080V13-BLAC-STANDA", "Standard", 25, null, null },
                    { 215L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 72L, 5, 0.00m, "NB-1080V13-WHIT-STANDA", "Standard", 6, null, null },
                    { 216L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 72L, 5, 200.00m, "NB-1080V13-BLUE-STANDA", "Standard", 1, null, null },
                    { 217L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 73L, 8, 0.00m, "NB-HD01-WHIT-M", "M", 35, null, null },
                    { 218L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 73L, 8, 0.00m, "NB-HD01-BLAC-L", "L", 7, null, null },
                    { 219L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 73L, 8, 200.00m, "NB-HD01-NAVY-XL", "XL", 1, null, null },
                    { 220L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 74L, 8, 0.00m, "COL-WT2-WHIT-M", "M", 35, null, null },
                    { 221L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 74L, 8, 0.00m, "COL-WT2-BLAC-L", "L", 7, null, null },
                    { 222L, "Navy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 74L, 8, 200.00m, "COL-WT2-NAVY-XL", "XL", 1, null, null },
                    { 223L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 75L, 5, 0.00m, "COL-FLC-BLAC-STANDA", "Standard", 25, null, null },
                    { 224L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 75L, 5, 0.00m, "COL-FLC-WHIT-STANDA", "Standard", 6, null, null },
                    { 225L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 75L, 5, 200.00m, "COL-FLC-BLUE-STANDA", "Standard", 1, null, null },
                    { 226L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 76L, 6, 0.00m, "COL-NTR-BLAC-41", "41", 35, null, null },
                    { 227L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 76L, 6, 200.00m, "COL-NTR-BLUE-42", "42", 7, null, null },
                    { 228L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 76L, 6, 400.00m, "COL-NTR-REDW-44", "44", 1, null, null },
                    { 229L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 77L, 6, 0.00m, "COL-PNT-BLAC-M", "M", 30, null, null },
                    { 230L, "Dark Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 77L, 6, 0.00m, "COL-PNT-DARK-L", "L", 7, null, null },
                    { 231L, "Grey", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 77L, 6, 200.00m, "COL-PNT-GREY-XL", "XL", 1, null, null },
                    { 232L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 78L, 5, 0.00m, "SKC-GW6-BLAC-STANDA", "Standard", 25, null, null },
                    { 233L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 78L, 5, 0.00m, "SKC-GW6-WHIT-STANDA", "Standard", 6, null, null },
                    { 234L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 78L, 5, 200.00m, "SKC-GW6-BLUE-STANDA", "Standard", 1, null, null },
                    { 235L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 79L, 6, 0.00m, "SKC-AF2-BLAC-41", "41", 35, null, null },
                    { 236L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 79L, 6, 200.00m, "SKC-AF2-BLUE-42", "42", 7, null, null },
                    { 237L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 79L, 6, 400.00m, "SKC-AF2-REDW-44", "44", 1, null, null },
                    { 238L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 80L, 5, 0.00m, "SKC-UNO-BLAC-STANDA", "Standard", 25, null, null },
                    { 239L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 80L, 5, 0.00m, "SKC-UNO-WHIT-STANDA", "Standard", 6, null, null },
                    { 240L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 80L, 5, 200.00m, "SKC-UNO-BLUE-STANDA", "Standard", 1, null, null },
                    { 241L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 81L, 5, 0.00m, "SKC-DLT-BLAC-STANDA", "Standard", 25, null, null },
                    { 242L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 81L, 5, 0.00m, "SKC-DLT-WHIT-STANDA", "Standard", 6, null, null },
                    { 243L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 81L, 5, 200.00m, "SKC-DLT-BLUE-STANDA", "Standard", 1, null, null },
                    { 244L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 82L, 10, 0.00m, "ASC-GK30-WHIT-200ML", "200ml", 40, null, null },
                    { 245L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 82L, 10, 200.00m, "ASC-GK30-WHIT-350ML", "350ml", 8, null, null },
                    { 246L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 82L, 10, 400.00m, "ASC-GK30-WHIT-500ML", "500ml", 1, null, null },
                    { 247L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 83L, 10, 0.00m, "ASC-GN26-WHIT-200ML", "200ml", 40, null, null },
                    { 248L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 83L, 10, 200.00m, "ASC-GN26-WHIT-350ML", "350ml", 8, null, null },
                    { 249L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 83L, 10, 400.00m, "ASC-GN26-WHIT-500ML", "500ml", 1, null, null },
                    { 250L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 84L, 5, 0.00m, "ASC-GT20-BLAC-STANDA", "Standard", 25, null, null },
                    { 251L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 84L, 5, 0.00m, "ASC-GT20-WHIT-STANDA", "Standard", 6, null, null },
                    { 252L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 84L, 5, 200.00m, "ASC-GT20-BLUE-STANDA", "Standard", 1, null, null },
                    { 253L, "Black / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 85L, 6, 0.00m, "ASC-GV9-BLAC-41", "41", 35, null, null },
                    { 254L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 85L, 6, 200.00m, "ASC-GV9-BLUE-42", "42", 7, null, null },
                    { 255L, "Red / White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 85L, 6, 400.00m, "ASC-GV9-REDW-44", "44", 1, null, null },
                    { 256L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 86L, 10, 0.00m, "LOR-HA15-CLEA-30ML", "30ml", 40, null, null },
                    { 257L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 86L, 10, 250.00m, "LOR-HA15-CLEA-50ML", "50ml", 8, null, null },
                    { 258L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 86L, 10, 500.00m, "LOR-HA15-CLEA-100ML", "100ml", 1, null, null },
                    { 259L, "Light", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 87L, 8, 0.00m, "LOR-INF24-LIGH-30ML", "30ml", 35, null, null },
                    { 260L, "Medium", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 87L, 8, 0.00m, "LOR-INF24-MEDI-30ML", "30ml", 7, null, null },
                    { 261L, "Deep", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 87L, 8, 100.00m, "LOR-INF24-DEEP-30ML", "30ml", 1, null, null },
                    { 262L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 88L, 5, 0.00m, "LOR-ELV400-BLAC-STANDA", "Standard", 25, null, null },
                    { 263L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 88L, 5, 0.00m, "LOR-ELV400-WHIT-STANDA", "Standard", 6, null, null },
                    { 264L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 88L, 5, 200.00m, "LOR-ELV400-BLUE-STANDA", "Standard", 1, null, null },
                    { 265L, "Very Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 89L, 8, 0.00m, "LOR-LASH-VERY-95ML", "9.5ml", 35, null, null },
                    { 266L, "Brown Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 89L, 8, 0.00m, "LOR-LASH-BROW-95ML", "9.5ml", 7, null, null },
                    { 267L, "Waterproof Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 89L, 8, 50.00m, "LOR-LASH-WATE-95ML", "9.5ml", 1, null, null },
                    { 268L, "Very Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 90L, 8, 0.00m, "MAY-SKYH-VERY-95ML", "9.5ml", 35, null, null },
                    { 269L, "Brown Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 90L, 8, 0.00m, "MAY-SKYH-BROW-95ML", "9.5ml", 7, null, null },
                    { 270L, "Waterproof Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 90L, 8, 50.00m, "MAY-SKYH-WATE-95ML", "9.5ml", 1, null, null },
                    { 271L, "Pastel Pink", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 91L, 8, 0.00m, "MAY-FITM-PAST-6MM", "6mm", 35, null, null },
                    { 272L, "Purple", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 91L, 8, 300.00m, "MAY-FITM-PURP-8MM", "8mm", 8, null, null },
                    { 273L, "Mint Green", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 91L, 8, 500.00m, "MAY-FITM-MINT-10MM", "10mm", 1, null, null },
                    { 274L, "Pastel Pink", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 92L, 8, 0.00m, "MAY-SINK-PAST-6MM", "6mm", 35, null, null },
                    { 275L, "Purple", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 92L, 8, 300.00m, "MAY-SINK-PURP-8MM", "8mm", 8, null, null },
                    { 276L, "Mint Green", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 92L, 8, 500.00m, "MAY-SINK-MINT-10MM", "10mm", 1, null, null },
                    { 277L, "Light", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 93L, 8, 0.00m, "MAY-ARWC-LIGH-30ML", "30ml", 35, null, null },
                    { 278L, "Medium", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 93L, 8, 0.00m, "MAY-ARWC-MEDI-30ML", "30ml", 7, null, null },
                    { 279L, "Deep", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 93L, 8, 100.00m, "MAY-ARWC-DEEP-30ML", "30ml", 1, null, null },
                    { 280L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 94L, 10, 0.00m, "CRV-HFC-WHIT-200ML", "200ml", 40, null, null },
                    { 281L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 94L, 10, 200.00m, "CRV-HFC-WHIT-350ML", "350ml", 8, null, null },
                    { 282L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 94L, 10, 400.00m, "CRV-HFC-WHIT-500ML", "500ml", 1, null, null },
                    { 283L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 95L, 10, 0.00m, "CRV-MC454-WHIT-200ML", "200ml", 40, null, null },
                    { 284L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 95L, 10, 200.00m, "CRV-MC454-WHIT-350ML", "350ml", 8, null, null },
                    { 285L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 95L, 10, 400.00m, "CRV-MC454-WHIT-500ML", "500ml", 1, null, null },
                    { 286L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 96L, 10, 0.00m, "CRV-AM30-WHIT-200ML", "200ml", 40, null, null },
                    { 287L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 96L, 10, 200.00m, "CRV-AM30-WHIT-350ML", "350ml", 8, null, null },
                    { 288L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 96L, 10, 400.00m, "CRV-AM30-WHIT-500ML", "500ml", 1, null, null },
                    { 289L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 97L, 10, 0.00m, "CRV-RRS-CLEA-30ML", "30ml", 40, null, null },
                    { 290L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 97L, 10, 250.00m, "CRV-RRS-CLEA-50ML", "50ml", 8, null, null },
                    { 291L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 97L, 10, 500.00m, "CRV-RRS-CLEA-100ML", "100ml", 1, null, null },
                    { 292L, "Pastel Pink", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 98L, 8, 0.00m, "MAC-RW-PAST-6MM", "6mm", 35, null, null },
                    { 293L, "Purple", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 98L, 8, 300.00m, "MAC-RW-PURP-8MM", "8mm", 8, null, null },
                    { 294L, "Mint Green", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 98L, 8, 500.00m, "MAC-RW-MINT-10MM", "10mm", 1, null, null },
                    { 295L, "Light", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 99L, 8, 0.00m, "MAC-SFF-LIGH-30ML", "30ml", 35, null, null },
                    { 296L, "Medium", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 99L, 8, 0.00m, "MAC-SFF-MEDI-30ML", "30ml", 7, null, null },
                    { 297L, "Deep", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 99L, 8, 100.00m, "MAC-SFF-DEEP-30ML", "30ml", 1, null, null },
                    { 298L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 100L, 5, 0.00m, "MAC-FIXP-BLAC-STANDA", "Standard", 25, null, null },
                    { 299L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 100L, 5, 0.00m, "MAC-FIXP-WHIT-STANDA", "Standard", 6, null, null },
                    { 300L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 100L, 5, 200.00m, "MAC-FIXP-BLUE-STANDA", "Standard", 1, null, null },
                    { 301L, "Light", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 101L, 6, 0.00m, "MAC-MSF-LIGH-10G", "10g", 25, null, null },
                    { 302L, "Medium", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 101L, 6, 0.00m, "MAC-MSF-MEDI-10G", "10g", 6, null, null },
                    { 303L, "Deep", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 101L, 6, 100.00m, "MAC-MSF-DEEP-10G", "10g", 1, null, null },
                    { 304L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 102L, 5, 0.00m, "NIV-CRM150-BLAC-STANDA", "Standard", 25, null, null },
                    { 305L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 102L, 5, 0.00m, "NIV-CRM150-WHIT-STANDA", "Standard", 6, null, null },
                    { 306L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 102L, 5, 200.00m, "NIV-CRM150-BLUE-STANDA", "Standard", 1, null, null },
                    { 307L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 103L, 10, 0.00m, "NIV-NGL350-WHIT-200ML", "200ml", 40, null, null },
                    { 308L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 103L, 10, 200.00m, "NIV-NGL350-WHIT-350ML", "350ml", 8, null, null },
                    { 309L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 103L, 10, 400.00m, "NIV-NGL350-WHIT-500ML", "500ml", 1, null, null },
                    { 310L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 104L, 5, 0.00m, "NIV-BWRO-BLAC-STANDA", "Standard", 25, null, null },
                    { 311L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 104L, 5, 0.00m, "NIV-BWRO-WHIT-STANDA", "Standard", 6, null, null },
                    { 312L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 104L, 5, 200.00m, "NIV-BWRO-BLUE-STANDA", "Standard", 1, null, null },
                    { 313L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 105L, 10, 0.00m, "NIV-Q10DC-WHIT-200ML", "200ml", 40, null, null },
                    { 314L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 105L, 10, 200.00m, "NIV-Q10DC-WHIT-350ML", "350ml", 8, null, null },
                    { 315L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 105L, 10, 400.00m, "NIV-Q10DC-WHIT-500ML", "500ml", 1, null, null },
                    { 316L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 106L, 5, 0.00m, "ORD-NIA10-BLAC-STANDA", "Standard", 25, null, null },
                    { 317L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 106L, 5, 0.00m, "ORD-NIA10-WHIT-STANDA", "Standard", 6, null, null },
                    { 318L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 106L, 5, 200.00m, "ORD-NIA10-BLUE-STANDA", "Standard", 1, null, null },
                    { 319L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 107L, 5, 0.00m, "ORD-HA2B5-BLAC-STANDA", "Standard", 25, null, null },
                    { 320L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 107L, 5, 0.00m, "ORD-HA2B5-WHIT-STANDA", "Standard", 6, null, null },
                    { 321L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 107L, 5, 200.00m, "ORD-HA2B5-BLUE-STANDA", "Standard", 1, null, null },
                    { 322L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 108L, 10, 0.00m, "ORD-PEEL30-CLEA-30ML", "30ml", 40, null, null },
                    { 323L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 108L, 10, 250.00m, "ORD-PEEL30-CLEA-50ML", "50ml", 8, null, null },
                    { 324L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 108L, 10, 500.00m, "ORD-PEEL30-CLEA-100ML", "100ml", 1, null, null },
                    { 325L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 109L, 10, 0.00m, "ORD-CAF5-CLEA-30ML", "30ml", 40, null, null },
                    { 326L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 109L, 10, 250.00m, "ORD-CAF5-CLEA-50ML", "50ml", 8, null, null },
                    { 327L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 109L, 10, 500.00m, "ORD-CAF5-CLEA-100ML", "100ml", 1, null, null },
                    { 328L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 110L, 10, 0.00m, "VCH-M89-CLEA-30ML", "30ml", 40, null, null },
                    { 329L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 110L, 10, 250.00m, "VCH-M89-CLEA-50ML", "50ml", 8, null, null },
                    { 330L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 110L, 10, 500.00m, "VCH-M89-CLEA-100ML", "100ml", 1, null, null },
                    { 331L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 111L, 10, 0.00m, "VCH-LAVITC-CLEA-30ML", "30ml", 40, null, null },
                    { 332L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 111L, 10, 250.00m, "VCH-LAVITC-CLEA-50ML", "50ml", 8, null, null },
                    { 333L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 111L, 10, 500.00m, "VCH-LAVITC-CLEA-100ML", "100ml", 1, null, null },
                    { 334L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 112L, 10, 0.00m, "VCH-NORM200-CLEA-30ML", "30ml", 40, null, null },
                    { 335L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 112L, 10, 250.00m, "VCH-NORM200-CLEA-50ML", "50ml", 8, null, null },
                    { 336L, "Clear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 112L, 10, 500.00m, "VCH-NORM200-CLEA-100ML", "100ml", 1, null, null },
                    { 337L, "Black", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 113L, 5, 0.00m, "VCH-UV50-BLAC-STANDA", "Standard", 25, null, null },
                    { 338L, "White", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 113L, 5, 0.00m, "VCH-UV50-WHIT-STANDA", "Standard", 6, null, null },
                    { 339L, "Blue", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 113L, 5, 200.00m, "VCH-UV50-BLUE-STANDA", "Standard", 1, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 9, 4, 20, 15, 55, 709, DateTimeKind.Utc).AddTicks(2216), "AQAAAAIAAYagAAAAEMTE8s8WUUFxgde1WFpnCJh+C6rUUhBwWnUcbbX24laxmzYo4WTfomuAyfcNOdqsgA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "ItemVariants",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 9, 2, 15, 13, 27, 258, DateTimeKind.Utc).AddTicks(3878), "AQAAAAIAAYagAAAAENQiA5GgzsdH5I3dNSlSSK9oQ5mfDthSM4gXooJUAUxHhKA+0DiL5SU0L75IZwdWFQ==" });
        }
    }
}
