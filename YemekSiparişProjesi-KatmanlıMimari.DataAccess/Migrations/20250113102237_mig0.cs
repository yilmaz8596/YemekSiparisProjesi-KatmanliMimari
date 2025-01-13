using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("0b2246c2-5751-46f9-8cbf-20d6faf3defc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("4d291559-e36f-4909-a4e8-41c5758350b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("ea61a583-f3b8-4c50-95bf-b1e13e9ddd85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("f6e6cd13-0656-46fa-805d-d49ccb81644d"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("0dbe40b1-f96e-4056-aaa0-7885812fd966"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("2ecdd040-4fbe-41dc-90ca-335125a3ea4c"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("2f4638d8-8b1b-4179-8c77-50af1de4f259"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("3641f01c-e65e-47ed-8afa-d519530a751b"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("458c61b4-7c83-4108-a390-eecf7e7015ad"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("49048b52-2d0d-4455-a9be-b7152e54dde7"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("67ebe0e7-07ee-44c2-8712-aba75befe7b2"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("6a054276-88fe-4872-85af-1e986166ec90"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a2f17d3d-74e3-46aa-9427-30e798c64a53"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a78ca396-c1d5-4f5f-afe6-cf507c75eada"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b3af6c60-bee0-438f-9820-b16806a4a1e7"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b7af94a5-7a2f-47c2-939c-29832005582a"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c7e71f47-39ce-4686-94a7-517bf53486b7"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c91b48a0-9de2-49ce-bafa-a01ed4bd79ac"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("daea1477-3703-4a8b-a76e-0f1b9475bbc9"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("e68d2ac8-0cad-4f7a-855b-8bcc351d4b91"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryID", "CategoryImage", "CategoryName", "CreateDate", "CreatedBy", "IsActive", "ModifiedBy", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), 1, "Images/appetizers.jpg", "Appetizers", new DateTime(2025, 1, 13, 13, 22, 37, 540, DateTimeKind.Local).AddTicks(8271), null, true, null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 2, "Images/main_courses.jpg", "Main Courses", new DateTime(2025, 1, 13, 13, 22, 37, 541, DateTimeKind.Local).AddTicks(9162), null, true, null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), 3, "Images/desserts.jpg", "Desserts", new DateTime(2025, 1, 13, 13, 22, 37, 541, DateTimeKind.Local).AddTicks(9173), null, true, null, null },
                    { new Guid("44444444-4444-4444-4444-444444444444"), 4, "Images/beverages.jpg", "Beverages", new DateTime(2025, 1, 13, 13, 22, 37, 541, DateTimeKind.Local).AddTicks(9175), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "ID", "CategoryID", "CategoryID1", "CreateDate", "CreatedBy", "Description", "DishName", "ImageUrl", "IsActive", "ModifiedBy", "UnitPrice", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("a1111111-1111-1111-1111-111111111111"), 1, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(2993), null, "Sarımsak, zeytinyağı, tuz ve domates ile süslenmiş kızarmış ekmek", "Bruschetta", "Images/bruschetta.jpg", true, null, 25.99m, null },
                    { new Guid("a2222222-2222-2222-2222-222222222222"), 1, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3674), null, "Geleneksel Türk mercimek çorbası", "Mercimek Çorbası", "Images/mercimek_corbasi.jpg", true, null, 20.99m, null },
                    { new Guid("a3333333-3333-3333-3333-333333333333"), 1, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3687), null, "Çıtır yufka içinde peynirli sigara böreği", "Sigara Böreği", "Images/sigara_boregi.jpg", true, null, 30.99m, null },
                    { new Guid("a4444444-4444-4444-4444-444444444444"), 1, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3690), null, "Nohut püresi, tahin, limon suyu ve zeytinyağı ile hazırlanan meze", "Humus", "Images/humus.jpg", true, null, 22.99m, null },
                    { new Guid("b1111111-1111-1111-1111-111111111111"), 2, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3693), null, "Baharatlarla harmanlanmış el yapımı ızgara köfte", "Izgara Köfte", "Images/izgara_kofte.jpg", true, null, 45.99m, null },
                    { new Guid("b2222222-2222-2222-2222-222222222222"), 2, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3701), null, "Geleneksel Türk mantısı, yoğurt ve baharatlı domates sosu ile", "Mantı", "Images/manti.jpg", true, null, 40.99m, null },
                    { new Guid("b3333333-3333-3333-3333-333333333333"), 2, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3704), null, "Marine edilmiş tavuk parçaları, ızgara sebzeler ile servis edilir", "Tavuk Şiş", "Images/tavuk_sis.jpg", true, null, 38.99m, null },
                    { new Guid("b4444444-4444-4444-4444-444444444444"), 2, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3706), null, "Zeytinyağlı patlıcan yemeği, domates ve soğan ile", "İmam Bayıldı", "Images/imam_bayildi.jpg", true, null, 35.99m, null },
                    { new Guid("c1111111-1111-1111-1111-111111111111"), 3, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3710), null, "Geleneksel Türk tatlısı, ince yufka katmanları arasında fındık, ceviz ile", "Baklava", "Images/baklava.jpg", true, null, 30.99m, null },
                    { new Guid("c2222222-2222-2222-2222-222222222222"), 3, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3713), null, "Fırında pişirilmiş geleneksel Türk sütlü tatlısı", "Sütlaç", "Images/sutlac.jpg", true, null, 25.99m, null },
                    { new Guid("c3333333-3333-3333-3333-333333333333"), 3, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3716), null, "Karamelize şekerle kaplı muhallebi tatlısı", "Kazandibi", "Images/kazandibi.jpg", true, null, 28.99m, null },
                    { new Guid("c4444444-4444-4444-4444-444444444444"), 3, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3718), null, "Kadayıf ve peynir ile yapılan geleneksel Türk tatlısı", "Künefe", "Images/kunefe.jpg", true, null, 32.99m, null },
                    { new Guid("d1111111-1111-1111-1111-111111111111"), 4, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3720), null, "Geleneksel Türk kahvesi, lokum ile servis edilir", "Türk Kahvesi", "Images/turk_kahvesi.jpg", true, null, 15.99m, null },
                    { new Guid("d2222222-2222-2222-2222-222222222222"), 4, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3722), null, "Geleneksel Türk yoğurt içeceği", "Ayran", "Images/ayran.jpg", true, null, 10.99m, null },
                    { new Guid("d3333333-3333-3333-3333-333333333333"), 4, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3724), null, "Geleneksel Türk turp içeceği", "Şalgam Suyu", "Images/salgam_suyu.jpg", true, null, 12.99m, null },
                    { new Guid("d4444444-4444-4444-4444-444444444444"), 4, null, new DateTime(2025, 1, 13, 13, 22, 37, 542, DateTimeKind.Local).AddTicks(3726), null, "Taze sıkılmış limonata", "Taze Limonata", "Images/limonata.jpg", true, null, 14.99m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a2222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a3333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("a4444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b2222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b3333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("b4444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c2222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c3333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("c4444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d2222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d3333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "ID",
                keyValue: new Guid("d4444444-4444-4444-4444-444444444444"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryID", "CategoryImage", "CategoryName", "CreateDate", "CreatedBy", "IsActive", "ModifiedBy", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0b2246c2-5751-46f9-8cbf-20d6faf3defc"), 4, "Images/beverages.jpg", "Beverages", new DateTime(2025, 1, 13, 13, 6, 12, 911, DateTimeKind.Local).AddTicks(8357), null, true, null, null },
                    { new Guid("4d291559-e36f-4909-a4e8-41c5758350b7"), 2, "Images/main_courses.jpg", "Main Courses", new DateTime(2025, 1, 13, 13, 6, 12, 911, DateTimeKind.Local).AddTicks(8326), null, true, null, null },
                    { new Guid("ea61a583-f3b8-4c50-95bf-b1e13e9ddd85"), 1, "Images/appetizers.jpg", "Appetizers", new DateTime(2025, 1, 13, 13, 6, 12, 910, DateTimeKind.Local).AddTicks(7538), null, true, null, null },
                    { new Guid("f6e6cd13-0656-46fa-805d-d49ccb81644d"), 3, "Images/desserts.jpg", "Desserts", new DateTime(2025, 1, 13, 13, 6, 12, 911, DateTimeKind.Local).AddTicks(8339), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "ID", "CategoryID", "CategoryID1", "CreateDate", "CreatedBy", "Description", "DishName", "ImageUrl", "IsActive", "ModifiedBy", "UnitPrice", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0dbe40b1-f96e-4056-aaa0-7885812fd966"), 2, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3242), null, "Zeytinyağlı patlıcan yemeği, domates ve soğan ile", "İmam Bayıldı", "Images/imam_bayildi.jpg", true, null, 35.99m, null },
                    { new Guid("2ecdd040-4fbe-41dc-90ca-335125a3ea4c"), 4, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3257), null, "Geleneksel Türk yoğurt içeceği", "Ayran", "Images/ayran.jpg", true, null, 10.99m, null },
                    { new Guid("2f4638d8-8b1b-4179-8c77-50af1de4f259"), 2, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3236), null, "Geleneksel Türk mantısı, yoğurt ve baharatlı domates sosu ile", "Mantı", "Images/manti.jpg", true, null, 40.99m, null },
                    { new Guid("3641f01c-e65e-47ed-8afa-d519530a751b"), 1, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3216), null, "Çıtır yufka içinde peynirli sigara böreği", "Sigara Böreği", "Images/sigara_boregi.jpg", true, null, 30.99m, null },
                    { new Guid("458c61b4-7c83-4108-a390-eecf7e7015ad"), 3, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3249), null, "Karamelize şekerle kaplı muhallebi tatlısı", "Kazandibi", "Images/kazandibi.jpg", true, null, 28.99m, null },
                    { new Guid("49048b52-2d0d-4455-a9be-b7152e54dde7"), 4, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3255), null, "Geleneksel Türk kahvesi, lokum ile servis edilir", "Türk Kahvesi", "Images/turk_kahvesi.jpg", true, null, 15.99m, null },
                    { new Guid("67ebe0e7-07ee-44c2-8712-aba75befe7b2"), 3, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3253), null, "Kadayıf ve peynir ile yapılan geleneksel Türk tatlısı", "Künefe", "Images/kunefe.jpg", true, null, 32.99m, null },
                    { new Guid("6a054276-88fe-4872-85af-1e986166ec90"), 2, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3228), null, "Baharatlarla harmanlanmış el yapımı ızgara köfte", "Izgara Köfte", "Images/izgara_kofte.jpg", true, null, 45.99m, null },
                    { new Guid("a2f17d3d-74e3-46aa-9427-30e798c64a53"), 4, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3259), null, "Geleneksel Türk turp içeceği", "Şalgam Suyu", "Images/salgam_suyu.jpg", true, null, 12.99m, null },
                    { new Guid("a78ca396-c1d5-4f5f-afe6-cf507c75eada"), 3, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3244), null, "Geleneksel Türk tatlısı, ince yufka katmanları arasında fındık, ceviz ile", "Baklava", "Images/baklava.jpg", true, null, 30.99m, null },
                    { new Guid("b3af6c60-bee0-438f-9820-b16806a4a1e7"), 3, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3247), null, "Fırında pişirilmiş geleneksel Türk sütlü tatlısı", "Sütlaç", "Images/sutlac.jpg", true, null, 25.99m, null },
                    { new Guid("b7af94a5-7a2f-47c2-939c-29832005582a"), 2, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3238), null, "Marine edilmiş tavuk parçaları, ızgara sebzeler ile servis edilir", "Tavuk Şiş", "Images/tavuk_sis.jpg", true, null, 38.99m, null },
                    { new Guid("c7e71f47-39ce-4686-94a7-517bf53486b7"), 1, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3200), null, "Geleneksel Türk mercimek çorbası", "Mercimek Çorbası", "Images/mercimek_corbasi.jpg", true, null, 20.99m, null },
                    { new Guid("c91b48a0-9de2-49ce-bafa-a01ed4bd79ac"), 1, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(2293), null, "Sarımsak, zeytinyağı, tuz ve domates ile süslenmiş kızarmış ekmek", "Bruschetta", "Images/bruschetta.jpg", true, null, 25.99m, null },
                    { new Guid("daea1477-3703-4a8b-a76e-0f1b9475bbc9"), 1, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3226), null, "Nohut püresi, tahin, limon suyu ve zeytinyağı ile hazırlanan meze", "Humus", "Images/humus.jpg", true, null, 22.99m, null },
                    { new Guid("e68d2ac8-0cad-4f7a-855b-8bcc351d4b91"), 4, null, new DateTime(2025, 1, 13, 13, 6, 12, 912, DateTimeKind.Local).AddTicks(3262), null, "Taze sıkılmış limonata", "Taze Limonata", "Images/limonata.jpg", true, null, 14.99m, null }
                });
        }
    }
}
