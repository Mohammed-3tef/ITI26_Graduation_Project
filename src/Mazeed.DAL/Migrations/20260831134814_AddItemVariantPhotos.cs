using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddItemVariantPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemVariantPhotos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ItemVariantId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVariantPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemVariantPhotos_ItemVariants_ItemVariantId",
                        column: x => x.ItemVariantId,
                        principalTable: "ItemVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 31, 13, 48, 8, 650, DateTimeKind.Utc).AddTicks(2272), "AQAAAAIAAYagAAAAEE5mgG82Ua8kMUhqk+lhZWmoL5+a5eJ4hxTUWyeJtfRsbFXv7eiRGUTppOwHq/k7ag==" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemVariantPhotos_ItemVariantId",
                table: "ItemVariantPhotos",
                column: "ItemVariantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemVariantPhotos");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 31, 1, 31, 18, 779, DateTimeKind.Utc).AddTicks(9176), "AQAAAAIAAYagAAAAEK881qcpFMPONU5Qc94O1oK9D72HynAPPTKoi2FDmukwvYiNk0P1GJVWbQxYX63rhw==" });
        }
    }
}
