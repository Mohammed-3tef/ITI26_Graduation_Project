using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserImageToByteArray : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Users");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfileImage",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash", "ProfileImage" },
                values: new object[] { new DateTime(2026, 8, 19, 13, 15, 46, 412, DateTimeKind.Utc).AddTicks(8955), "AQAAAAIAAYagAAAAEOno/55mv49aRLi5RP1tjFmhivHaO6JZNw5ljXCiprn8wvm1TAIdDomadyzzg52wag==", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ImageUrl", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 15, 11, 42, 23, 533, DateTimeKind.Utc).AddTicks(6638), null, "AQAAAAIAAYagAAAAEN+/6rxBr5lZ4p6ftZGJUxtae5Y11kvahvInEtDNWflstJrzGcv4NNdRheqJoo6ehg==" });
        }
    }
}
