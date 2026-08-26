using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CategorySeerder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2026, 8, 25, 19, 37, 29, 912, DateTimeKind.Utc).AddTicks(5291), "AQAAAAIAAYagAAAAEFdlgr/Qz3BxONWfaWvAttWb0OeTZagwVHMKpyHfyaKOmwlgbNbH/XjFab8E01CW8Q==" });
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 19, 13, 15, 46, 412, DateTimeKind.Utc).AddTicks(8955), "AQAAAAIAAYagAAAAEOno/55mv49aRLi5RP1tjFmhivHaO6JZNw5ljXCiprn8wvm1TAIdDomadyzzg52wag==" });
        }
    }
}
