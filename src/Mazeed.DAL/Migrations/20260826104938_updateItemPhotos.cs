using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateItemPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 2L, "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 3L, "https://images.unsplash.com/photo-1544244015-0df4b3ffc6b0?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 4L, "https://images.unsplash.com/photo-1600294037681-c80b4cb5b434?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 5L, "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 6L, "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 7L, "https://images.unsplash.com/photo-1580910051074-3eb694886505?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 8L, "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 9L, "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 19L, "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 20L, "https://images.unsplash.com/photo-1531297484001-80022131f5a1?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 21L, "https://images.unsplash.com/photo-1561154464-82e9adf32764?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 22L, "https://images.unsplash.com/photo-1584622650111-993a426fbf0a?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 23L, "https://images.unsplash.com/photo-1461151304267-38535e780c79?w=500&auto=format&fit=crop" });

            migrationBuilder.InsertData(
                table: "ItemPhotos",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "ItemId", "PhotoUrl", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 10L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 10L, "https://images.unsplash.com/photo-1606813907291-d86efa9b94db?w=500&auto=format&fit=crop", null, null },
                    { 11L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 11L, "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&auto=format&fit=crop", null, null },
                    { 12L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 12L, "https://images.unsplash.com/photo-1593784991095-a205069470b6?w=500&auto=format&fit=crop", null, null },
                    { 13L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 13L, "https://images.unsplash.com/photo-1516035069371-29a1b244cc32?w=500&auto=format&fit=crop", null, null },
                    { 14L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 14L, "https://images.unsplash.com/photo-1588872657578-7efd1f1555ed?w=500&auto=format&fit=crop", null, null },
                    { 15L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 15L, "https://images.unsplash.com/photo-1603302576837-37561b2e2302?w=500&auto=format&fit=crop", null, null },
                    { 16L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 16L, "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf?w=500&auto=format&fit=crop", null, null },
                    { 17L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 17L, "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?w=500&auto=format&fit=crop", null, null },
                    { 18L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 18L, "https://images.unsplash.com/photo-1611186871348-b1ce696e52c9?w=500&auto=format&fit=crop", null, null },
                    { 24L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 24L, "https://images.unsplash.com/photo-1626806787461-102c1bfaaea1?w=500&auto=format&fit=crop", null, null },
                    { 25L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 25L, "https://images.unsplash.com/photo-1547082299-de196ea013d6?w=500&auto=format&fit=crop", null, null },
                    { 26L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 26L, "https://images.unsplash.com/photo-1571175443880-49e1d25b2bc5?w=500&auto=format&fit=crop", null, null },
                    { 27L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 27L, "https://images.unsplash.com/photo-1574269909862-7e1d70bb8078?w=500&auto=format&fit=crop", null, null },
                    { 28L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 28L, "https://images.unsplash.com/photo-1585771724684-38269d6639fd?w=500&auto=format&fit=crop", null, null },
                    { 29L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 29L, "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1?w=500&auto=format&fit=crop", null, null },
                    { 30L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 30L, "https://images.unsplash.com/photo-1551028719-00167b16eac5?w=500&auto=format&fit=crop", null, null },
                    { 31L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 31L, "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?w=500&auto=format&fit=crop", null, null },
                    { 32L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 32L, "https://images.unsplash.com/photo-1598033129183-c4f50c736f10?w=500&auto=format&fit=crop", null, null },
                    { 33L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 33L, "https://images.unsplash.com/photo-1595777457583-95e059d581b8?w=500&auto=format&fit=crop", null, null },
                    { 34L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 34L, "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", null, null },
                    { 35L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 35L, "https://images.unsplash.com/photo-1541099649105-f69ad21f3246?w=500&auto=format&fit=crop", null, null },
                    { 36L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 36L, "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?w=500&auto=format&fit=crop", null, null },
                    { 37L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 37L, "https://images.unsplash.com/photo-1434389677669-e08b4cac3105?w=500&auto=format&fit=crop", null, null },
                    { 38L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 38L, "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=500&auto=format&fit=crop", null, null },
                    { 39L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 39L, "https://images.unsplash.com/photo-1544441893-675973e31985?w=500&auto=format&fit=crop", null, null },
                    { 40L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 40L, "https://images.unsplash.com/photo-1552902865-b72c031ac5ea?w=500&auto=format&fit=crop", null, null },
                    { 41L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 41L, "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=500&auto=format&fit=crop", null, null },
                    { 42L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 42L, "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", null, null },
                    { 43L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 43L, "https://images.unsplash.com/photo-1607522370275-f14206abe5d3?w=500&auto=format&fit=crop", null, null },
                    { 44L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 44L, "https://images.unsplash.com/photo-1578587018452-892bacefd3f2?w=500&auto=format&fit=crop", null, null },
                    { 45L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 45L, "https://images.unsplash.com/photo-1515886657613-9f3515b0c78f?w=500&auto=format&fit=crop", null, null },
                    { 46L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 46L, "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=500&auto=format&fit=crop", null, null },
                    { 47L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 47L, "https://images.unsplash.com/photo-1509631179647-0177331693ae?w=500&auto=format&fit=crop", null, null },
                    { 48L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 48L, "https://images.unsplash.com/photo-1579338559194-a162d19bf842?w=500&auto=format&fit=crop", null, null },
                    { 49L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 49L, "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", null, null },
                    { 50L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 50L, "https://images.unsplash.com/photo-1625910513413-5fc40e34c264?w=500&auto=format&fit=crop", null, null },
                    { 51L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 51L, "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=500&auto=format&fit=crop", null, null },
                    { 52L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 52L, "https://images.unsplash.com/photo-1548883354-7622d03aca27?w=500&auto=format&fit=crop", null, null },
                    { 53L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 53L, "https://images.unsplash.com/photo-1542272604-780c36856d61?w=500&auto=format&fit=crop", null, null },
                    { 54L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 54L, "https://images.unsplash.com/photo-1583743814966-8936f5b7be1a?w=500&auto=format&fit=crop", null, null },
                    { 55L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 55L, "https://images.unsplash.com/photo-1503342217505-b0a15ec3261c?w=500&auto=format&fit=crop", null, null },
                    { 56L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 56L, "https://images.unsplash.com/photo-1565084888279-aca607ecce0c?w=500&auto=format&fit=crop", null, null },
                    { 57L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 57L, "https://images.unsplash.com/photo-1583743814966-8936f5b7be1a?w=500&auto=format&fit=crop", null, null },
                    { 58L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 58L, "https://images.unsplash.com/photo-1581655353564-df123a1eb820?w=500&auto=format&fit=crop", null, null },
                    { 59L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 59L, "https://images.unsplash.com/photo-1511556532299-8f662fc26c06?w=500&auto=format&fit=crop", null, null },
                    { 60L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 60L, "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=500&auto=format&fit=crop", null, null },
                    { 61L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 61L, "https://images.unsplash.com/photo-1506629082925-23688b0729fe?w=500&auto=format&fit=crop", null, null },
                    { 62L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 62L, "https://images.unsplash.com/photo-1539185441755-769473a23570?w=500&auto=format&fit=crop", null, null },
                    { 63L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 63L, "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", null, null },
                    { 64L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 64L, "https://images.unsplash.com/photo-1515886657613-9f3515b0c78f?w=500&auto=format&fit=crop", null, null },
                    { 65L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 65L, "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", null, null },
                    { 66L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 66L, "https://images.unsplash.com/photo-1504280390367-361c6d9f38f4?w=500&auto=format&fit=crop", null, null },
                    { 67L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 67L, "https://images.unsplash.com/photo-1583454110551-21f2fa2afe61?w=500&auto=format&fit=crop", null, null },
                    { 68L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 68L, "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=500&auto=format&fit=crop", null, null },
                    { 69L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 69L, "https://images.unsplash.com/photo-1510017803434-a899398421b3?w=500&auto=format&fit=crop", null, null },
                    { 70L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 70L, "https://images.unsplash.com/photo-1539185441755-769473a23570?w=500&auto=format&fit=crop", null, null },
                    { 71L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 71L, "https://images.unsplash.com/photo-1551107696-a4b0c5a0d9a2?w=500&auto=format&fit=crop", null, null },
                    { 72L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 72L, "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", null, null },
                    { 73L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 73L, "https://images.unsplash.com/photo-1556905055-8f358a7a47b2?w=500&auto=format&fit=crop", null, null },
                    { 74L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 74L, "https://images.unsplash.com/photo-1544441893-675973e31985?w=500&auto=format&fit=crop", null, null },
                    { 75L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 75L, "https://images.unsplash.com/photo-1578587018452-892bacefd3f2?w=500&auto=format&fit=crop", null, null },
                    { 76L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 76L, "https://images.unsplash.com/photo-1520639888713-7851133b1ed0?w=500&auto=format&fit=crop", null, null },
                    { 77L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 77L, "https://images.unsplash.com/photo-1517841905240-472988babdf9?w=500&auto=format&fit=crop", null, null },
                    { 78L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 78L, "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=500&auto=format&fit=crop", null, null },
                    { 79L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 79L, "https://images.unsplash.com/photo-1608231387042-66d1773070a5?w=500&auto=format&fit=crop", null, null },
                    { 80L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 80L, "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?w=500&auto=format&fit=crop", null, null },
                    { 81L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 81L, "https://images.unsplash.com/photo-1600185365483-26d7a4cc7519?w=500&auto=format&fit=crop", null, null },
                    { 82L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 82L, "https://images.unsplash.com/photo-1584735935682-2f2b69dff9d2?w=500&auto=format&fit=crop", null, null },
                    { 83L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 83L, "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=500&auto=format&fit=crop", null, null },
                    { 84L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 84L, "https://images.unsplash.com/photo-1607522370275-f14206abe5d3?w=500&auto=format&fit=crop", null, null },
                    { 85L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 85L, "https://images.unsplash.com/photo-1520639888713-7851133b1ed0?w=500&auto=format&fit=crop", null, null },
                    { 86L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 86L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", null, null },
                    { 87L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 87L, "https://images.unsplash.com/photo-1522337360788-8b13dee7a37e?w=500&auto=format&fit=crop", null, null },
                    { 88L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 88L, "https://images.unsplash.com/photo-1535585209827-a15fcdbc4c2d?w=500&auto=format&fit=crop", null, null },
                    { 89L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 89L, "https://images.unsplash.com/photo-1631214524020-7e18db9a8f9d?w=500&auto=format&fit=crop", null, null },
                    { 90L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 90L, "https://images.unsplash.com/photo-1560700146-7c0137a8b3f2?w=500&auto=format&fit=crop", null, null },
                    { 91L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 91L, "https://images.unsplash.com/photo-1608248597349-f06b6b55dbdf?w=500&auto=format&fit=crop", null, null },
                    { 92L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 92L, "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&auto=format&fit=crop", null, null },
                    { 93L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 93L, "https://images.unsplash.com/photo-1616683693504-3ea7e9ad6fec?w=500&auto=format&fit=crop", null, null },
                    { 94L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 94L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", null, null },
                    { 95L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 95L, "https://images.unsplash.com/photo-1608248597259-be160f25e982?w=500&auto=format&fit=crop", null, null },
                    { 96L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 96L, "https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?w=500&auto=format&fit=crop", null, null },
                    { 97L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 97L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", null, null },
                    { 98L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 98L, "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&auto=format&fit=crop", null, null },
                    { 99L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 99L, "https://images.unsplash.com/photo-1522337360788-8b13dee7a37e?w=500&auto=format&fit=crop", null, null },
                    { 100L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 100L, "https://images.unsplash.com/photo-1616683693504-3ea7e9ad6fec?w=500&auto=format&fit=crop", null, null },
                    { 101L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 101L, "https://images.unsplash.com/photo-1590156206657-19d08e5a73e1?w=500&auto=format&fit=crop", null, null },
                    { 102L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 102L, "https://images.unsplash.com/photo-1608248597259-be160f25e982?w=500&auto=format&fit=crop", null, null },
                    { 103L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 103L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", null, null },
                    { 104L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 104L, "https://images.unsplash.com/photo-1619451334792-150fd785ee74?w=500&auto=format&fit=crop", null, null },
                    { 105L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 105L, "https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?w=500&auto=format&fit=crop", null, null },
                    { 106L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 106L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", null, null },
                    { 107L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 107L, "https://images.unsplash.com/photo-1608248597349-f06b6b55dbdf?w=500&auto=format&fit=crop", null, null },
                    { 108L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 108L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", null, null },
                    { 109L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 109L, "https://images.unsplash.com/photo-1616683693504-3ea7e9ad6fec?w=500&auto=format&fit=crop", null, null },
                    { 110L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 110L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop", null, null },
                    { 111L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 111L, "https://images.unsplash.com/photo-1608248597349-f06b6b55dbdf?w=500&auto=format&fit=crop", null, null },
                    { 112L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 112L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop", null, null },
                    { 113L, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SystemSeeder", null, null, false, 113L, "https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?w=500&auto=format&fit=crop", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 26, 10, 49, 36, 729, DateTimeKind.Utc).AddTicks(5644), "AQAAAAIAAYagAAAAEFUzEAxngxsVCQANrK7qAvG9NSMfxBVFYgRuKxK+h9lt+2C5fyNO70sR6nOXQfyt1Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 1L, "https://images.unsplash.com/photo-1695048133021-32c0d5001306?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 6L, "https://i.ebayimg.com/images/g/gmMAAOSwz1dm6cQH/s-l1600.webp" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 6L, "https://images.unsplash.com/photo-1580910051074-3eb694886505?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 2L, "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 2L, "https://images.unsplash.com/photo-1611186871348-b1ce696e52c9?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 23L, "https://images.unsplash.com/photo-1593784991095-a205069470b6?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 11L, "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 32L, "https://images.unsplash.com/photo-1521572267360-ee0c2909d518?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 86L, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 106L, "https://images.unsplash.com/photo-1608248597261-5421d55ab585?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 94L, "https://images.unsplash.com/photo-1556228720-195a672e8a03?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 90L, "https://images.unsplash.com/photo-1560700146-1c4354911984?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "ItemPhotos",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "ItemId", "PhotoUrl" },
                values: new object[] { 98L, "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&auto=format&fit=crop" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 8, 26, 10, 38, 15, 767, DateTimeKind.Utc).AddTicks(417), "AQAAAAIAAYagAAAAEA5oYCITnPA5DUq1Ctdjjri3bSEj82RgikERYfJlnYexqJ445K78rEBamAsaQQcENQ==" });
        }
    }
}
