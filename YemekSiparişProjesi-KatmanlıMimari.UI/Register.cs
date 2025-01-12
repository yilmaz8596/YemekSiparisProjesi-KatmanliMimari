
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using YemekSiparişProjesi_KatmanlıMimari.Business.Services;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.UI
{
    public partial class Register : Form
    {

        private readonly UserService userService;
        private UserService _userService;


        public Register()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            var userRepo = new UserRepository(dbContext);
            _userService = new UserService(userRepo);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User
                {
                    UserName = Ad.Text,
                    UserSurname = Soyad.Text,
                    Email = Eposta.Text,
                    Password = Sifre.Text,
                    IsAdmin = false,
                };



                if (Sifre.Text != SifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler eşleşmiyor!");
                    return;
                }

                _userService.AddUser(user);
                MessageBox.Show("Kayıt Başarılı");
                this.Close();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database update error: {dbEx.InnerException?.Message ?? dbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında bir hata oluştu: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
