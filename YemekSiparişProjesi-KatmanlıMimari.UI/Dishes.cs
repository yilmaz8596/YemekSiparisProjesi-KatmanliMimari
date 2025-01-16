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
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.UI
{
    public partial class Dishes : Form
    {
        private readonly DishService _dishService;
        public Dishes()
        {
            InitializeComponent();

            var dbContext = new ApplicationDBContext();
            var dishRepo = new DishRepository(dbContext);
            _dishService = new DishService(dishRepo);
        }

        private void Dishes_Load(object sender, EventArgs e)
        {

        }

        private Category _selectedCategory;

        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                LoadDishes();
            }
        }

        private void LoadDishes()
        {
            var dishes = _dishService.GetDishesByCategoryId(SelectedCategory.CategoryID);
        }

    
    }

}
