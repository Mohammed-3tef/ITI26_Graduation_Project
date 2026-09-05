using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ItemCategorySeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "CategoryId", "ItemId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 1L, 2L },
                    { 1L, 3L },
                    { 1L, 4L },
                    { 1L, 5L },
                    { 1L, 6L },
                    { 1L, 7L },
                    { 1L, 8L },
                    { 1L, 9L },
                    { 1L, 10L },
                    { 1L, 11L },
                    { 1L, 12L },
                    { 1L, 13L },
                    { 1L, 14L },
                    { 1L, 15L },
                    { 1L, 16L },
                    { 1L, 17L },
                    { 1L, 18L },
                    { 1L, 19L },
                    { 1L, 20L },
                    { 1L, 21L },
                    { 1L, 22L },
                    { 1L, 23L },
                    { 1L, 24L },
                    { 1L, 25L },
                    { 1L, 26L },
                    { 1L, 27L },
                    { 1L, 28L },
                    { 1L, 29L },
                    { 2L, 30L },
                    { 2L, 31L },
                    { 2L, 32L },
                    { 2L, 33L },
                    { 2L, 34L },
                    { 2L, 35L },
                    { 2L, 36L },
                    { 2L, 37L },
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
                    { 3L, 57L },
                    { 3L, 58L },
                    { 3L, 59L },
                    { 3L, 60L },
                    { 3L, 61L },
                    { 3L, 62L },
                    { 3L, 63L },
                    { 3L, 64L },
                    { 3L, 65L },
                    { 3L, 66L },
                    { 3L, 67L },
                    { 3L, 68L },
                    { 3L, 69L },
                    { 3L, 70L },
                    { 3L, 71L },
                    { 3L, 72L },
                    { 3L, 73L },
                    { 3L, 74L },
                    { 3L, 75L },
                    { 3L, 76L },
                    { 3L, 77L },
                    { 3L, 78L },
                    { 3L, 79L },
                    { 3L, 80L },
                    { 3L, 81L },
                    { 3L, 82L },
                    { 3L, 83L },
                    { 3L, 84L },
                    { 3L, 85L },
                    { 4L, 86L },
                    { 4L, 87L },
                    { 4L, 88L },
                    { 4L, 89L },
                    { 4L, 90L },
                    { 4L, 91L },
                    { 4L, 92L },
                    { 4L, 93L },
                    { 4L, 94L },
                    { 4L, 95L },
                    { 4L, 96L },
                    { 4L, 97L },
                    { 4L, 98L },
                    { 4L, 99L },
                    { 4L, 100L },
                    { 4L, 101L },
                    { 4L, 102L },
                    { 4L, 103L },
                    { 4L, 104L },
                    { 4L, 105L },
                    { 4L, 106L },
                    { 4L, 107L },
                    { 4L, 108L },
                    { 4L, 109L },
                    { 4L, 110L },
                    { 4L, 111L },
                    { 4L, 112L },
                    { 4L, 113L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 31, 1, 31, 18, 779, DateTimeKind.Utc).AddTicks(9176), "AQAAAAIAAYagAAAAEK881qcpFMPONU5Qc94O1oK9D72HynAPPTKoi2FDmukwvYiNk0P1GJVWbQxYX63rhw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 2L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 3L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 4L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 5L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 6L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 7L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 8L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 9L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 10L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 11L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 12L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 13L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 14L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 15L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 16L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 17L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 18L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 19L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 20L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 21L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 22L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 23L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 24L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 25L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 26L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 27L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 28L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 1L, 29L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 30L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 31L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 32L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 33L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 34L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 35L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 36L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 2L, 37L });

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

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 58L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 59L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 60L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 61L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 62L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 63L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 64L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 65L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 66L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 67L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 68L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 69L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 70L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 71L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 72L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 73L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 74L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 75L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 76L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 77L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 78L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 79L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 80L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 81L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 82L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 83L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 84L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 3L, 85L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 86L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 87L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 88L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 89L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 90L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 91L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 92L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 93L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 94L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 95L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 96L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 97L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 98L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 99L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 100L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 101L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 102L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 103L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 104L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 105L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 106L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 107L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 108L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 109L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 110L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 111L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 112L });

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumns: new[] { "CategoryId", "ItemId" },
                keyValues: new object[] { 4L, 113L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 26, 15, 27, 38, 319, DateTimeKind.Utc).AddTicks(7659), "AQAAAAIAAYagAAAAEL3mhT0I5vGMHAv5S9NyT3ql9xYnIfBn56gqH3M2XSV5fWNNMw1uuS5FePHOo/+cVg==" });
        }
    }
}
