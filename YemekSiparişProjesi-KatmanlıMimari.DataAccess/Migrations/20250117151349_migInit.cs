using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Dishes_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Dishes_DishID",
                        column: x => x.DishID,
                        principalTable: "Dishes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryID", "CategoryImage", "CategoryName", "CreateDate", "CreatedBy", "IsActive", "ModifiedBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new Guid("437861a3-6546-436f-8e7c-15edac91a1d4"), "Images/baslangıclar.jpg", "Başlangıçlar", new DateTime(2025, 1, 17, 18, 13, 48, 714, DateTimeKind.Local).AddTicks(4869), null, true, null, null },
                    { 2, new Guid("f1ae1e69-2870-4034-bccd-6bf45732d7d8"), "Images/ana_yemekler.jpg", "Ana Yemekler", new DateTime(2025, 1, 17, 18, 13, 48, 715, DateTimeKind.Local).AddTicks(6946), null, true, null, null },
                    { 3, new Guid("0b826fdd-371e-4741-b6d5-c269da6c2edb"), "Images/tatlilar.jpg", "Tatlılar", new DateTime(2025, 1, 17, 18, 13, 48, 715, DateTimeKind.Local).AddTicks(6968), null, true, null, null },
                    { 4, new Guid("414c7a9f-12bd-4a81-9600-0745d1590d26"), "Images/icecekler.jpg", "İçecekler", new DateTime(2025, 1, 17, 18, 13, 48, 715, DateTimeKind.Local).AddTicks(6970), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "ID", "CategoryID", "CreateDate", "CreatedBy", "Description", "DishName", "ImageUrl", "IsActive", "ModifiedBy", "UnitPrice", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("a1111111-1111-1111-1111-111111111111"), 1, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(566), null, "Sarımsak, zeytinyağı, tuz ve domates ile süslenmiş kızarmış ekmek", "Bruschetta", "Images/bruschetta.jpg", true, null, 25.99m, null },
                    { new Guid("a2222222-2222-2222-2222-222222222222"), 1, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1273), null, "Çıtır soğan halkaları, parmak tavuk, patates kızartması ve soslar ile", "Kombo Tabağı", "Images/kombo_tabagi.jpg", true, null, 20.99m, null },
                    { new Guid("a3333333-3333-3333-3333-333333333333"), 1, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1277), null, "Çıtır yufka içinde peynirli sigara böreği", "Sigara Böreği", "Images/sigara_boregi.jpg", true, null, 30.99m, null },
                    { new Guid("a4444444-4444-4444-4444-444444444444"), 1, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1318), null, "Nohut püresi, tahin, limon suyu ve zeytinyağı ile hazırlanan meze", "Humus", "Images/humus.jpg", true, null, 22.99m, null },
                    { new Guid("a5555555-5555-5555-5555-555555555555"), 1, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1325), null, "Geleneksel Türk mutfağının vazgeçilmezi, baharatlı kırmızı mercimek çorbası", "Mercimek Çorbası", "Images/mercimek_corbasi.jpg", true, null, 24.99m, null },
                    { new Guid("a6666666-6666-6666-6666-666666666666"), 1, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1335), null, "Mercimek, pirinç ve bulgur ile hazırlanan geleneksel çorba", "Ezogelin Çorbası", "Images/ezogelin_corbasi.jpg", true, null, 26.99m, null },
                    { new Guid("a7777777-7777-7777-7777-777777777777"), 1, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1346), null, "Terbiye edilmiş köy tavuğu çorbası", "Tavuk Çorbası", "Images/tavuk_corbasi.jpg", true, null, 28.99m, null },
                    { new Guid("a8888888-8888-8888-8888-888888888888"), 1, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1349), null, "Yoğurt ve pirinç ile hazırlanan nefis bir çorba", "Yayla Çorbası", "Images/yayla_corbasi.jpg", true, null, 25.99m, null },
                    { new Guid("b1111111-1111-1111-1111-111111111111"), 2, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1351), null, "Baharatlarla harmanlanmış el yapımı ızgara köfte", "Izgara Köfte", "Images/izgara_kofte.jpg", true, null, 45.99m, null },
                    { new Guid("b2222222-2222-2222-2222-222222222222"), 2, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1355), null, "Geleneksel Türk mantısı, yoğurt ve baharatlı domates sosu ile", "Mantı", "Images/manti.jpg", true, null, 40.99m, null },
                    { new Guid("b3333333-3333-3333-3333-333333333333"), 2, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1357), null, "Marine edilmiş tavuk parçaları, ızgara sebzeler ile servis edilir", "Tavuk Şiş", "Images/tavuk_sis.jpg", true, null, 38.99m, null },
                    { new Guid("b4444444-4444-4444-4444-444444444444"), 2, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1359), null, "Zeytinyağlı patlıcan yemeği, domates ve soğan ile", "İmam Bayıldı", "Images/imam_bayildi.jpg", true, null, 35.99m, null },
                    { new Guid("c1111111-1111-1111-1111-111111111111"), 3, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1363), null, "Geleneksel Türk tatlısı, ince yufka katmanları arasında fındık, ceviz ile", "Baklava", "Images/baklava.jpg", true, null, 30.99m, null },
                    { new Guid("c2222222-2222-2222-2222-222222222222"), 3, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1365), null, "Fırında pişirilmiş geleneksel Türk sütlü tatlısı", "Sütlaç", "Images/sutlac.jpg", true, null, 25.99m, null },
                    { new Guid("c3333333-3333-3333-3333-333333333333"), 3, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1367), null, "Karamelize şekerle kaplı muhallebi tatlısı", "Kazandibi", "Images/kazandibi.jpg", true, null, 28.99m, null },
                    { new Guid("c4444444-4444-4444-4444-444444444444"), 3, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1369), null, "Kadayıf ve peynir ile yapılan geleneksel Türk tatlısı", "Künefe", "Images/kunefe.jpg", true, null, 32.99m, null },
                    { new Guid("d1111111-1111-1111-1111-111111111111"), 4, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1371), null, "Geleneksel Türk kahvesi, lokum ile servis edilir", "Türk Kahvesi", "Images/turk_kahvesi.jpg", true, null, 15.99m, null },
                    { new Guid("d2222222-2222-2222-2222-222222222222"), 4, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1374), null, "Geleneksel Türk yoğurt içeceği", "Ayran", "Images/ayran.jpg", true, null, 10.99m, null },
                    { new Guid("d3333333-3333-3333-3333-333333333333"), 4, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1375), null, "Geleneksel Türk turp içeceği", "Şalgam Suyu", "Images/salgam_suyu.jpg", true, null, 12.99m, null },
                    { new Guid("d4444444-4444-4444-4444-444444444444"), 4, new DateTime(2025, 1, 17, 18, 13, 48, 716, DateTimeKind.Local).AddTicks(1378), null, "Taze sıkılmış limonata", "Taze Limonata", "Images/limonata.jpg", true, null, 14.99m, null }
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
                name: "IX_CartItems_OrderID",
                table: "CartItems",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserID",
                table: "Carts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_CategoryID",
                table: "Dishes",
                column: "CategoryID");

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
