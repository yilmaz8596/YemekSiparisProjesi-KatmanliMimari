﻿using MaterialSkin;
using MaterialSkin.Controls;
using YemekSiparişProjesi_KatmanlıMimari.Business.Services;
using YemekSiparişProjesi_KatmanlıMimari.Business.Validators;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.UI
{
    public partial class Main1 : MaterialForm
    {
        List<CartItem> cart = new List<CartItem>();
        private readonly UserService _userService;
        private readonly OrderDetailService _orderDetailService;
        private readonly OrderService _orderService;
        private readonly ApplicationDBContext _dbContext;  
        private User _currentUser;

        public Main1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;

            _dbContext = new ApplicationDBContext();
            var userRepo = new UserRepository(_dbContext);
            var orderDetailRepo = new OrderDetailRepository(_dbContext);
            var orderRepo = new OrderRepository(_dbContext);
            // Initialize services
            _userService = new UserService(userRepo);
            _orderDetailService = new OrderDetailService(orderDetailRepo);

            // Initialize MaterialSkinManager
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                Color.FromArgb(0, 121, 107),
                Color.FromArgb(0, 150, 136),
                Color.DarkOliveGreen,
                Color.GreenYellow,
                TextShade.WHITE
            );

            foreach (TabPage page in materialTabControl1.TabPages)
            {
                page.BackColor = Color.FromArgb(50, 50, 50);
            }

            foreach (Control control in this.Controls)
            {
                if (control is Panel || control is TabPage)
                {
                    control.BackColor = Color.FromArgb(50, 50, 50);
                }
            }

            MaterialCard[] cards = {
                    materialCard1, materialCard2, materialCard3, materialCard4, materialCard5,
                    materialCard6, materialCard7, materialCard8, materialCard9, materialCard10,
                    materialCard11, materialCard12, materialCard13, materialCard14, materialCard15,
                    materialCard16, materialCard17, materialCard18, materialCard19, materialCard20
                };

            foreach (var card in cards)
            {
                card.BackColor = Color.FromArgb(50, 50, 50);
            }

            materialCard21.BackColor = Color.FromArgb(50, 50, 50);

            Label[] labels = {
                    label3, label4, label5, label6, label7, label8, label9, label10,
                    label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22
                };

            foreach (var label in labels)
            {
                label.ForeColor = Color.WhiteSmoke;
            }

            materialListView1.BackColor = Color.FromArgb(50, 50, 50);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.View = View.Details;
            materialListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            materialListView1.Columns.Clear();
            materialListView1.Columns.Add(new ColumnHeader() { Text = "Ürün Adı", Width = 150 });
            materialListView1.Columns.Add(new ColumnHeader() { Text = "Fiyat", Width = 150 });
            materialListView1.Columns.Add(new ColumnHeader() { Text = "Adet", Width = 150 });
            materialListView1.Columns.Add(new ColumnHeader() { Text = "Toplam", Width = 150 });

            materialListView1.OwnerDraw = true;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.FullRowSelect = true;

            materialListView2.BackColor = Color.FromArgb(50, 50, 50);
            materialListView2.BorderStyle = BorderStyle.None;
            materialListView2.View = View.Details;
            materialListView2.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            materialListView2.Columns.Clear();
            materialListView2.Columns.Add(new ColumnHeader() { Text = "Sipariş Tarihi", Width = 200 });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "Ürün Adı", Width = 200 });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "Adet", Width = 200 });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "Birim Fiyat", Width = 200 });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "Toplam", Width = 200 });

            materialListView2.OwnerDraw = true;
            materialListView2.UseCompatibleStateImageBehavior = false;
            materialListView2.FullRowSelect = true;
            materialListView1.Width = 600;
            materialListView2.Width = 1000;


        }


        private void ValidateAndPlaceOrder()
        {
            try
            {
                // Create user from text boxes
                var user = new User
                {
                    ID = Guid.NewGuid(),
                    UserName = materialTextBox21.Text,
                    UserSurname = materialTextBox22.Text,
                    Address = materialTextBox23.Text,
                    PhoneNumber = materialTextBox26.Text,
                    Email = materialTextBox25.Text
                };

                // Validate user using FluentValidation
                var userValidator = new UserValidator();
                var userValidationResult = userValidator.Validate(user);

                if (!userValidationResult.IsValid)
                {
                    var errors = string.Join("\n", userValidationResult.Errors.Select(e => e.ErrorMessage));
                    MessageBox.Show(errors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // If validation passes, assign the user and place order
                _currentUser = user;

                var order = new Order
                {
                    ID = Guid.NewGuid(),
                    OrderDate = DateTime.Now,
                    UserID = _currentUser.ID,
                    TotalAmount = cart.Sum(item => item.Dish.UnitPrice * item.Quantity)

                };


                // Create order details for each cart item
                foreach (var cartItem in cart)
                {
                    // Ensure the Dish has an ID
                    if (cartItem.Dish.ID == Guid.Empty)
                    {
                        // If Dish ID is not set, you might need to fetch or create it
                        var existingDish = _dbContext.Dishes.FirstOrDefault(d => d.DishName == cartItem.Dish.DishName);
                        if (existingDish == null)
                        {
                            // Create a new dish if it doesn't exist
                            existingDish = new Dish
                            {
                                ID = Guid.NewGuid(),
                                DishName = cartItem.Dish.DishName,
                                UnitPrice = cartItem.Dish.UnitPrice
                            };
                            //_dbContext.Dishes.Add(existingDish);
                        }

                        cartItem.Dish = existingDish;
                    }

                    var orderDetail = new OrderDetail
                    {
                        OrderID = order.ID,
                        DishID = cartItem.Dish.ID,
                        Quantity = cartItem.Quantity,
                        UnitPrice = cartItem.Dish.UnitPrice
                    };

                    var orderDetailValidator = new OrderDetailValidator();
                    var orderDetailValidationResult = orderDetailValidator.Validate(orderDetail);

                    if (!orderDetailValidationResult.IsValid)
                    {
                        var errors = string.Join("\n", orderDetailValidationResult.Errors.Select(e => e.ErrorMessage));
                        MessageBox.Show(errors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _orderDetailService.Add(orderDetail);
                    _orderService.Add(order);
                }

                // Save changes to the database
                _dbContext.SaveChanges();

                // Clear the cart after order is placed
                cart.Clear();
                materialListView1.Items.Clear();

                MessageBox.Show("Sipariş başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş oluşturulurken bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateCartView(string dishName, string dishPrice, string quantity)
        {
            // Check if item exists in cart
            var existingItem = cart.FirstOrDefault(x => x.Dish.DishName == dishName);

            if (existingItem != null)
            {
                existingItem.Quantity++;

                materialListView1.Items.Clear();
                foreach (var item in cart)
                {
                    materialListView1.Items.Add(new ListViewItem(new string[]
                    {
                item.Dish.DishName,
                item.Dish.UnitPrice.ToString(),
                item.Quantity.ToString(),
                (item.Dish.UnitPrice * item.Quantity).ToString()
                    }));
                }
            }
            else
            {
                var cartItem = new CartItem
                {
                    Dish = new Dish
                    {
                        DishName = dishName,
                        UnitPrice = decimal.Parse(dishPrice)
                    },
                    Quantity = int.Parse(quantity)
                };
                cart.Add(cartItem);

                materialListView1.Items.Add(new ListViewItem(new string[]
                {
            dishName,
            dishPrice,
            quantity,
            (decimal.Parse(dishPrice) * int.Parse(quantity)).ToString()
                }));
            }

            MessageBox.Show($"Ürün sepete eklendi: {dishName}");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main1_Load(object sender, EventArgs e)
        {
            materialButton1.MinimumSize = new Size(250, 60);
            materialButton1.MaximumSize = new Size(250, 60);
        }

        private void showCartContents_Click(object dishName, object unitPrice, object quantity)
        {

            UpdateCartView((string)dishName, unitPrice.ToString(), quantity.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void anaSayfa_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }

        private void baslangiclar_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void corbalar_Click(object sender, EventArgs e)
        {

        }

        private void anaYemekler_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialCard7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void menu_Click_1(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {

            showCartContents_Click(label3.Text, 25.99m, 1);
        }

        private void baslangiclar_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialCard20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void materialCard21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTextBox25_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox22_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox23_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox26_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

            showCartContents_Click(label4.Text, 22.99m, 1);
        }

        private void materialListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label5.Text, 30.99m, 1);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label6.Text, 20.99m, 1);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label10.Text, 24.99m, 1);
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label9.Text, 26.99m, 1);

        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label8.Text, 25.99m, 1);
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label7.Text, 30.99m, 1);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void materialButton13_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label14.Text, 45.99m, 1);

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label13.Text, 40.99m, 1);

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label12.Text, 38.99m, 1);

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label11.Text, 35.99m, 1);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void materialButton17_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label18.Text, 30.99m, 1);

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void materialButton16_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label17.Text, 28.99m, 1);

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void materialButton15_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label16.Text, 32.99m, 1);

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void materialButton14_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label15.Text, 25.99m, 1);

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void materialButton21_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label22.Text, 10.99m, 1);

        }

        private void materialButton20_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label21.Text, 12.99m, 1);

        }

        private void materialButton19_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label20.Text, 14.99m, 1);

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void materialButton18_Click(object sender, EventArgs e)
        {
            showCartContents_Click(label19.Text, 15.99m, 1);

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void materialButton22_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Sepetiniz boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ValidateAndPlaceOrder();
        }
    }
}
