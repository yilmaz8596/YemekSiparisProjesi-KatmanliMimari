using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CategoryImage", "CategoryName", "CreateDate" },
                values: new object[] { "Images/baslangıclar.jpg", "Başlangıçlar", new DateTime(2025, 1, 13, 14, 26, 28, 254, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CategoryImage", "CategoryName", "CreateDate" },
                values: new object[] { "Images/ana_yemekler.jpg", "Ana Yemekler", new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CategoryImage", "CategoryName", "CreateDate" },
                values: new object[] { "Images/tatlilar.jpg", "Tatlılar", new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CategoryImage", "CategoryName", "CreateDate" },
                values: new object[] { "Images/icecekler.jpg", "İçecekler", new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(3739) });

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
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 14, 26, 28, 255, DateTimeKind.Local).AddTicks(8370));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CategoryImage", "CategoryName", "CreateDate" },
                values: new object[] { "Images/appetizers.jpg", "Appetizers", new DateTime(2025, 1, 13, 13, 22, 37, 540, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CategoryImage", "CategoryName", "CreateDate" },
                values: new object[] { "Images/main_courses.jpg", "Main Courses", new DateTime(2025, 1, 13, 13, 22, 37, 541, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CategoryImage", "CategoryName", "CreateDate" },
                values: new object[] { "Images/desserts.jpg", "Desserts", new DateTime(2025, 1, 13, 13, 22, 37, 541, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CategoryImage", "CategoryName", "CreateDate" },
                values: new object[] { "Images/beverages.jpg", "Beverages", new DateTime(2025, 1, 13, 13, 22, 37, 541, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3726));
        }
    }
}
