using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    CategoryID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dishes_Categories_CategoryID1",
                        column: x => x.CategoryID1,
                        principalTable: "Categories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartID",
                        column: x => x.CartID,
                        principalTable: "Carts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Dishes_DishID",
                        column: x => x.DishID,
                        principalTable: "Dishes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderID, x.DishID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Dishes_DishID",
                        column: x => x.DishID,
                        principalTable: "Dishes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartID",
                table: "CartItems",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_DishID",
                table: "CartItems",
                column: "DishID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserID",
                table: "Carts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_CategoryID1",
                table: "Dishes",
                column: "CategoryID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_DishID",
                table: "OrderDetails",
                column: "DishID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderID",
                table: "Payments",
                column: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
