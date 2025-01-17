﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;

#nullable disable

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20250117191006_mig0")]
    partial class mig0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Cart", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.CartItem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DishID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("DishID");

                    b.HasIndex("OrderID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = new Guid("a0e18a96-f796-473a-b86a-00f7573fc91d"),
                            CategoryImage = "Images/baslangıclar.jpg",
                            CategoryName = "Başlangıçlar",
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 94, DateTimeKind.Local).AddTicks(9550),
                            IsActive = true
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = new Guid("2a28b357-aa81-4fc8-96af-d75d0d6f3b14"),
                            CategoryImage = "Images/ana_yemekler.jpg",
                            CategoryName = "Ana Yemekler",
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 95, DateTimeKind.Local).AddTicks(9771),
                            IsActive = true
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = new Guid("c7645c09-2f78-4a24-bb22-64410f1dd068"),
                            CategoryImage = "Images/tatlilar.jpg",
                            CategoryName = "Tatlılar",
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 95, DateTimeKind.Local).AddTicks(9785),
                            IsActive = true
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = new Guid("152574ca-f679-4b0f-8e3d-b33e69344c38"),
                            CategoryImage = "Images/icecekler.jpg",
                            CategoryName = "İçecekler",
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 95, DateTimeKind.Local).AddTicks(9787),
                            IsActive = true
                        });
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Dish", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            ID = new Guid("a1111111-1111-1111-1111-111111111111"),
                            CategoryID = 1,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(3435),
                            Description = "Sarımsak, zeytinyağı, tuz ve domates ile süslenmiş kızarmış ekmek",
                            DishName = "Bruschetta",
                            ImageUrl = "Images/bruschetta.jpg",
                            IsActive = true,
                            UnitPrice = 25.99m
                        },
                        new
                        {
                            ID = new Guid("a2222222-2222-2222-2222-222222222222"),
                            CategoryID = 1,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4187),
                            Description = "Çıtır soğan halkaları, parmak tavuk, patates kızartması ve soslar ile",
                            DishName = "Kombo Tabağı",
                            ImageUrl = "Images/kombo_tabagi.jpg",
                            IsActive = true,
                            UnitPrice = 20.99m
                        },
                        new
                        {
                            ID = new Guid("a3333333-3333-3333-3333-333333333333"),
                            CategoryID = 1,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4192),
                            Description = "Çıtır yufka içinde peynirli sigara böreği",
                            DishName = "Sigara Böreği",
                            ImageUrl = "Images/sigara_boregi.jpg",
                            IsActive = true,
                            UnitPrice = 30.99m
                        },
                        new
                        {
                            ID = new Guid("a4444444-4444-4444-4444-444444444444"),
                            CategoryID = 1,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4195),
                            Description = "Nohut püresi, tahin, limon suyu ve zeytinyağı ile hazırlanan meze",
                            DishName = "Humus",
                            ImageUrl = "Images/humus.jpg",
                            IsActive = true,
                            UnitPrice = 22.99m
                        },
                        new
                        {
                            ID = new Guid("a5555555-5555-5555-5555-555555555555"),
                            CategoryID = 1,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4197),
                            Description = "Geleneksel Türk mutfağının vazgeçilmezi, baharatlı kırmızı mercimek çorbası",
                            DishName = "Mercimek Çorbası",
                            ImageUrl = "Images/mercimek_corbasi.jpg",
                            IsActive = true,
                            UnitPrice = 24.99m
                        },
                        new
                        {
                            ID = new Guid("a6666666-6666-6666-6666-666666666666"),
                            CategoryID = 1,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4203),
                            Description = "Mercimek, pirinç ve bulgur ile hazırlanan geleneksel çorba",
                            DishName = "Ezogelin Çorbası",
                            ImageUrl = "Images/ezogelin_corbasi.jpg",
                            IsActive = true,
                            UnitPrice = 26.99m
                        },
                        new
                        {
                            ID = new Guid("a7777777-7777-7777-7777-777777777777"),
                            CategoryID = 1,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4214),
                            Description = "Terbiye edilmiş köy tavuğu çorbası",
                            DishName = "Tavuk Çorbası",
                            ImageUrl = "Images/tavuk_corbasi.jpg",
                            IsActive = true,
                            UnitPrice = 28.99m
                        },
                        new
                        {
                            ID = new Guid("a8888888-8888-8888-8888-888888888888"),
                            CategoryID = 1,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4217),
                            Description = "Yoğurt ve pirinç ile hazırlanan nefis bir çorba",
                            DishName = "Yayla Çorbası",
                            ImageUrl = "Images/yayla_corbasi.jpg",
                            IsActive = true,
                            UnitPrice = 25.99m
                        },
                        new
                        {
                            ID = new Guid("b1111111-1111-1111-1111-111111111111"),
                            CategoryID = 2,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4219),
                            Description = "Baharatlarla harmanlanmış el yapımı ızgara köfte",
                            DishName = "Izgara Köfte",
                            ImageUrl = "Images/izgara_kofte.jpg",
                            IsActive = true,
                            UnitPrice = 45.99m
                        },
                        new
                        {
                            ID = new Guid("b2222222-2222-2222-2222-222222222222"),
                            CategoryID = 2,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4224),
                            Description = "Geleneksel Türk mantısı, yoğurt ve baharatlı domates sosu ile",
                            DishName = "Mantı",
                            ImageUrl = "Images/manti.jpg",
                            IsActive = true,
                            UnitPrice = 40.99m
                        },
                        new
                        {
                            ID = new Guid("b3333333-3333-3333-3333-333333333333"),
                            CategoryID = 2,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4226),
                            Description = "Marine edilmiş tavuk parçaları, ızgara sebzeler ile servis edilir",
                            DishName = "Tavuk Şiş",
                            ImageUrl = "Images/tavuk_sis.jpg",
                            IsActive = true,
                            UnitPrice = 38.99m
                        },
                        new
                        {
                            ID = new Guid("b4444444-4444-4444-4444-444444444444"),
                            CategoryID = 2,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4228),
                            Description = "Zeytinyağlı patlıcan yemeği, domates ve soğan ile",
                            DishName = "İmam Bayıldı",
                            ImageUrl = "Images/imam_bayildi.jpg",
                            IsActive = true,
                            UnitPrice = 35.99m
                        },
                        new
                        {
                            ID = new Guid("c1111111-1111-1111-1111-111111111111"),
                            CategoryID = 3,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4230),
                            Description = "Geleneksel Türk tatlısı, ince yufka katmanları arasında fındık, ceviz ile",
                            DishName = "Baklava",
                            ImageUrl = "Images/baklava.jpg",
                            IsActive = true,
                            UnitPrice = 30.99m
                        },
                        new
                        {
                            ID = new Guid("c2222222-2222-2222-2222-222222222222"),
                            CategoryID = 3,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4232),
                            Description = "Fırında pişirilmiş geleneksel Türk sütlü tatlısı",
                            DishName = "Sütlaç",
                            ImageUrl = "Images/sutlac.jpg",
                            IsActive = true,
                            UnitPrice = 25.99m
                        },
                        new
                        {
                            ID = new Guid("c3333333-3333-3333-3333-333333333333"),
                            CategoryID = 3,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4234),
                            Description = "Karamelize şekerle kaplı muhallebi tatlısı",
                            DishName = "Kazandibi",
                            ImageUrl = "Images/kazandibi.jpg",
                            IsActive = true,
                            UnitPrice = 28.99m
                        },
                        new
                        {
                            ID = new Guid("c4444444-4444-4444-4444-444444444444"),
                            CategoryID = 3,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4236),
                            Description = "Kadayıf ve peynir ile yapılan geleneksel Türk tatlısı",
                            DishName = "Künefe",
                            ImageUrl = "Images/kunefe.jpg",
                            IsActive = true,
                            UnitPrice = 32.99m
                        },
                        new
                        {
                            ID = new Guid("d1111111-1111-1111-1111-111111111111"),
                            CategoryID = 4,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4239),
                            Description = "Geleneksel Türk kahvesi, lokum ile servis edilir",
                            DishName = "Türk Kahvesi",
                            ImageUrl = "Images/turk_kahvesi.jpg",
                            IsActive = true,
                            UnitPrice = 15.99m
                        },
                        new
                        {
                            ID = new Guid("d2222222-2222-2222-2222-222222222222"),
                            CategoryID = 4,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4243),
                            Description = "Geleneksel Türk yoğurt içeceği",
                            DishName = "Ayran",
                            ImageUrl = "Images/ayran.jpg",
                            IsActive = true,
                            UnitPrice = 10.99m
                        },
                        new
                        {
                            ID = new Guid("d3333333-3333-3333-3333-333333333333"),
                            CategoryID = 4,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4245),
                            Description = "Geleneksel Türk turp içeceği",
                            DishName = "Şalgam Suyu",
                            ImageUrl = "Images/salgam_suyu.jpg",
                            IsActive = true,
                            UnitPrice = 12.99m
                        },
                        new
                        {
                            ID = new Guid("d4444444-4444-4444-4444-444444444444"),
                            CategoryID = 4,
                            CreateDate = new DateTime(2025, 1, 17, 22, 10, 6, 96, DateTimeKind.Local).AddTicks(4246),
                            Description = "Taze sıkılmış limonata",
                            DishName = "Taze Limonata",
                            ImageUrl = "Images/limonata.jpg",
                            IsActive = true,
                            UnitPrice = 14.99m
                        });
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DishID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID", "DishID");

                    b.HasIndex("DishID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Payment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PaymentAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Cart", b =>
                {
                    b.HasOne("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.CartItem", b =>
                {
                    b.HasOne("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Dish");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Dish", b =>
                {
                    b.HasOne("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Category", null)
                        .WithMany("Dishes")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Order", b =>
                {
                    b.HasOne("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.OrderDetail", b =>
                {
                    b.HasOne("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Dish", "Dish")
                        .WithMany("OrderDetails")
                        .HasForeignKey("DishID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Payment", b =>
                {
                    b.HasOne("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Category", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Dish", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("YemekSiparişProjesi_KatmanlıMimari.Entites.Models.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
