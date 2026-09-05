using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateSeederPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 31L,
                column: "PhotoUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQph9tunhwAttz2agSx8Gq9rdTkCtZD94qSlSXF_xtYHScGKem6QHv7D3qp&s=10");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 34L,
                column: "PhotoUrl",
                value: "https://gympluscoffee.com/cdn/shop/files/ECOM-DAILY-RELAXED-FIT-HOODIE-GLACIAL-BLUE-3.jpg?v=1788357868&width=800");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 35L,
                column: "PhotoUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_vpyB2cKH2360GvcK5rRcS89BNnv1bCEprRbyVqaL_g&s=10");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 36L,
                column: "PhotoUrl",
                value: "https://www.plainandsimple.com/cdn/shop/files/Men_Oversized_Heavyweight_Organic_Cotton_Tshirt_Oversized_Fit_White_1.jpg?v=1765991530");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 37L,
                column: "PhotoUrl",
                value: "https://media.soliver.com/i/soliver/2174841.7900_front?$ai$&fmt=auto&qlt=default&scale=clamp&w=2048");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 50L,
                column: "PhotoUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSLjs-Sp-LM4cP9k3zPhbHyKYGccqYKusHFFE7eXZUJuw&s=10");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 52L,
                column: "PhotoUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTdmzVRJCqGiWg4Y3MjFcGuISVTPUnC3peA5OqU-1Tbpw&s=10");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 53L,
                column: "PhotoUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoYCBSz9KkjzhNYWG7YZZTkt7ixGaf1apesjQ7uYZy2A&s=10");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 9, 5, 11, 1, 50, 254, DateTimeKind.Utc).AddTicks(8253), "AQAAAAIAAYagAAAAECqRn8cFwZgV0azvSHq4/rkncVuQfUJWsbYcddlK3QaCfSQKD3393ivdgPSdNz6E3A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 31L,
                column: "PhotoUrl",
                value: "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=500&auto=format&fit=crop");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 34L,
                column: "PhotoUrl",
                value: "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 35L,
                column: "PhotoUrl",
                value: "https://images.unsplash.com/photo-1541099649105-f69ad21f3246?w=500&auto=format&fit=crop");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 36L,
                column: "PhotoUrl",
                value: "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?w=500&auto=format&fit=crop");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 37L,
                column: "PhotoUrl",
                value: "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=500&auto=format&fit=crop");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 50L,
                column: "PhotoUrl",
                value: "https://images.unsplash.com/photo-1625910513413-5fc40e34c264?w=500&auto=format&fit=crop");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 52L,
                column: "PhotoUrl",
                value: "https://images.unsplash.com/photo-1548883354-7622d03aca27?w=500&auto=format&fit=crop");

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 53L,
                column: "PhotoUrl",
                value: "https://images.unsplash.com/photo-1542272604-780c36856d61?w=500&auto=format&fit=crop");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 9, 4, 20, 15, 55, 709, DateTimeKind.Utc).AddTicks(2216), "AQAAAAIAAYagAAAAEMTE8s8WUUFxgde1WFpnCJh+C6rUUhBwWnUcbbX24laxmzYo4WTfomuAyfcNOdqsgA==" });
        }
    }
}
