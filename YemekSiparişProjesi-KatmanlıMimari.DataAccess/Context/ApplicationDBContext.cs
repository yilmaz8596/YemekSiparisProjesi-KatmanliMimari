using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }

        // Constructor for dependency injection
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public ApplicationDBContext()
        {
        }

        // Optional: Override OnConfiguring for connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OJQ7MOU\SQLEXPRESS;Initial Catalog=KatmanlıMimari_YemekSiprais;Integrated Security=True;
Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

            optionsBuilder.EnableSensitiveDataLogging();

            // Add this line to suppress the warning
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        // Optional: Configure model relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .Property(u => u.UserName).IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Email).IsRequired();

            // Order Configuration
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            // OrderDetail Configuration
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Dish)
                .WithMany(d => d.OrderDetails)
                .HasForeignKey(od => od.DishID)
                .OnDelete(DeleteBehavior.Restrict);

             //Dish Configuration
            modelBuilder.Entity<Dish>()
                .HasOne<Category>()
                .WithMany(c => c.Dishes)
                .HasForeignKey(d => d.CategoryID)
                .OnDelete(DeleteBehavior.Restrict);

            // Cart Configuration
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany(u => u.Carts)
                .HasForeignKey(c => c.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            // CartItem Configuration
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.CartID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Dish)
                .WithMany()
                .HasForeignKey(ci => ci.DishID)
                .OnDelete(DeleteBehavior.Restrict);

            // Payment Configuration
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Order)
                .WithMany(o => o.Payments)
                .HasForeignKey(p => p.OrderID)
                .OnDelete(DeleteBehavior.Restrict);



            //composite key
            modelBuilder.Entity<OrderDetail>().HasKey(o => new { o.OrderID, o.DishID });
            modelBuilder.Entity<OrderDetail>().Ignore(o => o.ID);

            SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            var categories = new List<Category>
    {
        new Category {
            ID = 1,
            CategoryID = Guid.NewGuid(),
            CategoryName = "Başlangıçlar",
            CategoryImage = "Images/baslangıclar.jpg"
        },
        new Category {
            ID = 2,
            CategoryID = Guid.NewGuid(),
            CategoryName = "Ana Yemekler",
            CategoryImage = "Images/ana_yemekler.jpg"
        },
        new Category {
            ID = 3,
            CategoryID = Guid.NewGuid(),
            CategoryName = "Tatlılar",
            CategoryImage = "Images/tatlilar.jpg"
        },
        new Category {
            ID = 4,
            CategoryID = Guid.NewGuid(),
            CategoryName = "İçecekler",
            CategoryImage = "Images/icecekler.jpg"
        }
    };

            modelBuilder.Entity<Category>().HasData(categories);

            var dishes = new List<Dish>
    {
        // Appetizers
        new Dish
        {
            ID = new Guid("A1111111-1111-1111-1111-111111111111"),
            DishName = "Bruschetta",
            Description = "Sarımsak, zeytinyağı, tuz ve domates ile süslenmiş kızarmış ekmek",
            UnitPrice = 25.99m,
            ImageUrl = "Images/bruschetta.jpg",
            CategoryID = 1
        },
        new Dish
        {
            ID = new Guid("A2222222-2222-2222-2222-222222222222"),
            DishName = "Kombo Tabağı",
            Description = "Çıtır soğan halkaları, parmak tavuk, patates kızartması ve soslar ile",
            UnitPrice = 20.99m,
            ImageUrl = "Images/kombo_tabagi.jpg",
            CategoryID = 1
        },
        new Dish
        {
            ID = new Guid("A3333333-3333-3333-3333-333333333333"),
            DishName = "Sigara Böreği",
            Description = "Çıtır yufka içinde peynirli sigara böreği",
            UnitPrice = 30.99m,
            ImageUrl = "Images/sigara_boregi.jpg",
            CategoryID = 1
        },
        new Dish
        {
            ID = new Guid("A4444444-4444-4444-4444-444444444444"),
            DishName = "Humus",
            Description = "Nohut püresi, tahin, limon suyu ve zeytinyağı ile hazırlanan meze",
            UnitPrice = 22.99m,
            ImageUrl = "Images/humus.jpg",
            CategoryID = 1
        },

        // Soups
        // Soups
new Dish
{
    ID = new Guid("A5555555-5555-5555-5555-555555555555"),
    DishName = "Mercimek Çorbası",
    Description = "Geleneksel Türk mutfağının vazgeçilmezi, baharatlı kırmızı mercimek çorbası",
    UnitPrice = 24.99m,
    ImageUrl = "Images/mercimek_corbasi.jpg",
    CategoryID = 1
},
new Dish
{
    ID = new Guid("A6666666-6666-6666-6666-666666666666"),
    DishName = "Ezogelin Çorbası",
    Description = "Mercimek, pirinç ve bulgur ile hazırlanan geleneksel çorba",
    UnitPrice = 26.99m,
    ImageUrl = "Images/ezogelin_corbasi.jpg",
    CategoryID = 1
},
new Dish
{
    ID = new Guid("A7777777-7777-7777-7777-777777777777"),
    DishName = "Tavuk Çorbası",
    Description = "Terbiye edilmiş köy tavuğu çorbası",
    UnitPrice = 28.99m,
    ImageUrl = "Images/tavuk_corbasi.jpg",
    CategoryID = 1
},
new Dish
{
    ID = new Guid("A8888888-8888-8888-8888-888888888888"),
    DishName = "Yayla Çorbası",
    Description = "Yoğurt ve pirinç ile hazırlanan nefis bir çorba",
    UnitPrice = 25.99m,
    ImageUrl = "Images/yayla_corbasi.jpg",
    CategoryID = 1
},


        // Main Courses
        new Dish
        {
            ID = new Guid("B1111111-1111-1111-1111-111111111111"),
            DishName = "Izgara Köfte",
            Description = "Baharatlarla harmanlanmış el yapımı ızgara köfte",
            UnitPrice = 45.99m,
            ImageUrl = "Images/izgara_kofte.jpg",
            CategoryID = 2
        },
        new Dish
        {
            ID = new Guid("B2222222-2222-2222-2222-222222222222"),
            DishName = "Mantı",
            Description = "Geleneksel Türk mantısı, yoğurt ve baharatlı domates sosu ile",
            UnitPrice = 40.99m,
            ImageUrl = "Images/manti.jpg",
            CategoryID = 2
        },
        new Dish
        {
            ID = new Guid("B3333333-3333-3333-3333-333333333333"),
            DishName = "Tavuk Şiş",
            Description = "Marine edilmiş tavuk parçaları, ızgara sebzeler ile servis edilir",
            UnitPrice = 38.99m,
            ImageUrl = "Images/tavuk_sis.jpg",
            CategoryID = 2
        },
        new Dish
        {
            ID = new Guid("B4444444-4444-4444-4444-444444444444"),
            DishName = "İmam Bayıldı",
            Description = "Zeytinyağlı patlıcan yemeği, domates ve soğan ile",
            UnitPrice = 35.99m,
            ImageUrl = "Images/imam_bayildi.jpg",
            CategoryID = 2
        },

        // Desserts
        new Dish
        {
            ID = new Guid("C1111111-1111-1111-1111-111111111111"),
            DishName = "Baklava",
            Description = "Geleneksel Türk tatlısı, ince yufka katmanları arasında fındık, ceviz ile",
            UnitPrice = 30.99m,
            ImageUrl = "Images/baklava.jpg",
            CategoryID = 3
        },
        new Dish
        {
            ID = new Guid("C2222222-2222-2222-2222-222222222222"),
            DishName = "Sütlaç",
            Description = "Fırında pişirilmiş geleneksel Türk sütlü tatlısı",
            UnitPrice = 25.99m,
            ImageUrl = "Images/sutlac.jpg",
            CategoryID = 3
        },
        new Dish
        {
            ID = new Guid("C3333333-3333-3333-3333-333333333333"),
            DishName = "Kazandibi",
            Description = "Karamelize şekerle kaplı muhallebi tatlısı",
            UnitPrice = 28.99m,
            ImageUrl = "Images/kazandibi.jpg",
            CategoryID = 3
        },
        new Dish
        {
            ID = new Guid("C4444444-4444-4444-4444-444444444444"),
            DishName = "Künefe",
            Description = "Kadayıf ve peynir ile yapılan geleneksel Türk tatlısı",
            UnitPrice = 32.99m,
            ImageUrl = "Images/kunefe.jpg",
            CategoryID = 3
        },

        // Beverages
        new Dish
        {
            ID = new Guid("D1111111-1111-1111-1111-111111111111"),
            DishName = "Türk Kahvesi",
            Description = "Geleneksel Türk kahvesi, lokum ile servis edilir",
            UnitPrice = 15.99m,
            ImageUrl = "Images/turk_kahvesi.jpg",
            CategoryID = 4
        },
        new Dish
        {
            ID = new Guid("D2222222-2222-2222-2222-222222222222"),
            DishName = "Ayran",
            Description = "Geleneksel Türk yoğurt içeceği",
            UnitPrice = 10.99m,
            ImageUrl = "Images/ayran.jpg",
            CategoryID = 4
        },
        new Dish
        {
            ID = new Guid("D3333333-3333-3333-3333-333333333333"),
            DishName = "Şalgam Suyu",
            Description = "Geleneksel Türk turp içeceği",
            UnitPrice = 12.99m,
            ImageUrl = "Images/salgam_suyu.jpg",
            CategoryID = 4
        },
        new Dish
        {
            ID = new Guid("D4444444-4444-4444-4444-444444444444"),
            DishName = "Taze Limonata",
            Description = "Taze sıkılmış limonata",
            UnitPrice = 14.99m,
            ImageUrl = "Images/limonata.jpg",
            CategoryID = 4
        }
    };

            modelBuilder.Entity<Dish>().HasData(dishes);
        }

    }
}