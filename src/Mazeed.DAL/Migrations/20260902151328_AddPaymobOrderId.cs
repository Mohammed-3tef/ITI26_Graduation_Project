using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymobOrderId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PaymobOrderId",
                table: "Payments",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 9, 2, 15, 13, 27, 258, DateTimeKind.Utc).AddTicks(3878), "AQAAAAIAAYagAAAAENQiA5GgzsdH5I3dNSlSSK9oQ5mfDthSM4gXooJUAUxHhKA+0DiL5SU0L75IZwdWFQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymobOrderId",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 9, 2, 14, 12, 31, 743, DateTimeKind.Utc).AddTicks(7088), "AQAAAAIAAYagAAAAEFh/umOMNxpBu0O5nkLI9Uu/SgvQhkYruJ4Pl6B3Mrn+bp09vYTPOs/2Xrr5sHwHYw==" });
        }
    }
}
