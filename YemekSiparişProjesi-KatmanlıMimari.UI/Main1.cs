using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparişProjesi_KatmanlıMimari.UI
{
    public partial class Main1 : MaterialForm
    {
        private string dishCategory;

        public Main1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;


            // Initialize MaterialSkinManager

            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
           Color.FromArgb(0, 121, 107),
              Color.FromArgb(0, 150, 136),
                Color.DarkOliveGreen,
                Color.GreenYellow,
           TextShade.WHITE
       );
            this.BackColor = Color.FromArgb(50, 50, 50);

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

            Label[] labels = {
             label3, label4, label5, label6, label7, label8, label9, label10,
                label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22
            };

            foreach (var label in labels)
            {
                label.ForeColor = Color.WhiteSmoke;
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Main1_Load(object sender, EventArgs e)
        {
            materialButton1.MinimumSize = new Size(250, 60);
            materialButton1.MaximumSize = new Size(250, 60);


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
    }
}
