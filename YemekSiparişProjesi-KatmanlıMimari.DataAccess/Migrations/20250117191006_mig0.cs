using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreateDate" },
                values: new object[] { new Guid("a0e18a96-f796-473a-b86a-00f7573fc91d"), new DateTime(2025, 1, 17, 22, 10, 6, 94, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreateDate" },
                values: new object[] { new Guid("2a28b357-aa81-4fc8-96af-d75d0d6f3b14"), new DateTime(2025, 1, 17, 22, 10, 6, 95, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreateDate" },
                values: new object[] { new Guid("c7645c09-2f78-4a24-bb22-64410f1dd068"), new DateTime(2025, 1, 17, 22, 10, 6, 95, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreateDate" },
                values: new object[] { new Guid("152574ca-f679-4b0f-8e3d-b33e69344c38"), new DateTime(2025, 1, 17, 22, 10, 6, 95, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a5555555-5555-5555-5555-555555555555"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a6666666-6666-6666-6666-666666666666"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a7777777-7777-7777-7777-777777777777"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a8888888-8888-8888-8888-888888888888"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4246));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CreateDate" },
                values: new object[] { new Guid("437861a3-6546-436f-8e7c-15edac91a1d4"), new DateTime(2025, 1, 17, 18, 13, 48, 714, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreateDate" },
                values: new object[] { new Guid("f1ae1e69-2870-4034-bccd-6bf45732d7d8"), new DateTime(2025, 1, 17, 18, 13, 48, 715, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreateDate" },
                values: new object[] { new Guid("0b826fdd-371e-4741-b6d5-c269da6c2edb"), new DateTime(2025, 1, 17, 18, 13, 48, 715, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CreateDate" },
                values: new object[] { new Guid("414c7a9f-12bd-4a81-9600-0745d1590d26"), new DateTime(2025, 1, 17, 18, 13, 48, 715, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a5555555-5555-5555-5555-555555555555"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a6666666-6666-6666-6666-666666666666"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a7777777-7777-7777-7777-777777777777"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a8888888-8888-8888-8888-888888888888"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d1111111-1111-1111-1111-111111111111"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d2222222-2222-2222-2222-222222222222"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d3333333-3333-3333-3333-333333333333"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d4444444-4444-4444-4444-444444444444"),
                column: "CreateDate",
                value: new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1378));
        }
    }
}
