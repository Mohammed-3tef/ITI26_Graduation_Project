using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateFashionCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 38L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 39L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 40L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 41L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 42L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 43L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 44L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 45L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 46L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 47L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 48L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 49L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 50L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 51L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 52L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 53L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 54L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 55L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 56L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 57L });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "CategoryId", "ItemId" },
                values: new object[,]
                {
                    { 2L, 38L },
                    { 2L, 39L },
                    { 2L, 40L },
                    { 2L, 41L },
                    { 2L, 42L },
                    { 2L, 43L },
                    { 2L, 44L },
                    { 2L, 45L },
                    { 2L, 46L },
                    { 2L, 47L },
                    { 2L, 48L },
                    { 2L, 49L },
                    { 2L, 50L },
                    { 2L, 51L },
                    { 2L, 52L },
                    { 2L, 53L },
                    { 2L, 54L },
                    { 2L, 55L },
                    { 2L, 56L },
                    { 2L, 57L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 9, 5, 11, 8, 0, 584, DateTimeKind.Utc).AddTicks(7896), "AQAAAAIAAYagAAAAENqj21Brpal02IxtcNSBfET38EU/friGWvPIP/EVkcXmUlADv11hXrddXlD8ZqKq0g==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 38L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 39L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 40L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 41L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 42L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 43L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 44L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 45L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 46L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 47L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 48L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 49L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 50L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 51L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 52L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 53L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 54L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 55L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 56L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 57L });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "CategoryId", "ItemId" },
                values: new object[,]
                {
                    { 3L, 38L },
                    { 3L, 39L },
                    { 3L, 40L },
                    { 3L, 41L },
                    { 3L, 42L },
                    { 3L, 43L },
                    { 3L, 44L },
                    { 3L, 45L },
                    { 3L, 46L },
                    { 3L, 47L },
                    { 3L, 48L },
                    { 3L, 49L },
                    { 3L, 50L },
                    { 3L, 51L },
                    { 3L, 52L },
                    { 3L, 53L },
                    { 3L, 54L },
                    { 3L, 55L },
                    { 3L, 56L },
                    { 3L, 57L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 9, 5, 11, 1, 50, 254, DateTimeKind.Utc).AddTicks(8253), "AQAAAAIAAYagAAAAECqRn8cFwZgV0azvSHq4/rkncVuQfUJWsbYcddlK3QaCfSQKD3393ivdgPSdNz6E3A==" });
        }
    }
}
