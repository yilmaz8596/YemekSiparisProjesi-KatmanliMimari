using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekSiparişProjesi_KatmanlıMimari.Business.Services;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;

namespace YemekSiparişProjesi_KatmanlıMimari.UI
{
    public partial class Login : Form
    {
        private readonly UserService userService;
        private UserService _userService;
        public Login()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            var userRepo = new UserRepository(dbContext);
            _userService = new UserService(userRepo);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Eposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               var authenticatedUser = _userService.AuthenticateUser(Eposta.Text, Sifre.Text);

                if (authenticatedUser == null)
                {
                    MessageBox.Show("Hatalı Giriş");
                    return;
                }

                MessageBox.Show("Giriş Başarılı");
                Main mainPage = new Main();
                mainPage.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Hatalı Giriş");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
