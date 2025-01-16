using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 187, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a2222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "Description", "DishName", "ImageUrl" },
                values: new object[] { new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7222), "Çıtır soğan halkaları, parmak tavuk, patates kızartması ve soslar ile", "Kombo Tabağı", "Images/kombo_tabagi.jpg" });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "ID", "CategoryID", "CategoryID1", "CreateDate", "CreatedBy", "Description", "DishName", "ImageUrl", "IsActive", "ModifiedBy", "UnitPrice", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("a5555555-5555-5555-5555-555555555555"), 1, null, new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7252), null, "Geleneksel Türk mutfağının vazgeçilmezi, baharatlı kırmızı mercimek çorbası", "Mercimek Çorbası", "Images/mercimek_corbasi.jpg", true, null, 24.99m, null },
                    { new Guid("a6666666-6666-6666-6666-666666666666"), 1, null, new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7258), null, "Mercimek, pirinç ve bulgur ile hazırlanan geleneksel çorba", "Ezogelin Çorbası", "Images/ezogelin_corbasi.jpg", true, null, 26.99m, null },
                    { new Guid("a7777777-7777-7777-7777-777777777777"), 1, null, new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7261), null, "Sarımsaklı ve sirkeli geleneksel Türk çorbası", "İşkembe Çorbası", "Images/iskembe_corbasi.jpg", true, null, 28.99m, null },
                    { new Guid("a8888888-8888-8888-8888-888888888888"), 1, null, new DateTime(2025, 1, 15, 19, 20, 48, 189, DateTimeKind.Local).AddTicks(7263), null, "Yoğurt ve pirinç ile hazırlanan nefis bir çorba", "Yayla Çorbası", "Images/yayla_corbasi.jpg", true, null, 25.99m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a5555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a6666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a7777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a8888888-8888-8888-8888-888888888888"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 254, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a2222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreateDate", "Description", "DishName", "ImageUrl" },
                values: new object[] { new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8370), "Geleneksel Türk mercimek çorbası", "Mercimek Çorbası", "Images/mercimek_corbasi.jpg" });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8453));
        }
    }
}
