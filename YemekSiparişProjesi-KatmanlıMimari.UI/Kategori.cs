
using YemekSiparişProjesi_KatmanlıMimari.Business.Services;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.UI
{
    public partial class Kategori : Form
    {
        private readonly CategoryService _categoryService;
        private FlowLayoutPanel categoriesFlowPanel;



        public Kategori()
        {
            InitializeComponent();

        }

        //    categoriesFlowPanel = this.flowLayoutPanel1; 

        //    var dbContext = new ApplicationDBContext();
        //    var categoryRepo = new CategoryRepository(dbContext);
        //    _categoryService = new CategoryService(categoryRepo);

        //    categoriesFlowPanel.Dock = DockStyle.Fill;
        //    categoriesFlowPanel.FlowDirection = FlowDirection.LeftToRight;
        //    categoriesFlowPanel.WrapContents = true;
        //    categoriesFlowPanel.AutoScroll = true; 
        //    categoriesFlowPanel.Padding = new Padding(35); 
        //    categoriesFlowPanel.Margin = new Padding(30);
        //    categoriesFlowPanel.HorizontalScroll.Enabled = false;
        //    categoriesFlowPanel.HorizontalScroll.Visible = false;
        //    categoriesFlowPanel.VerticalScroll.Enabled = false;
        //    categoriesFlowPanel.VerticalScroll.Visible = false;



        //    this.Load += (s, e) => LoadCategories();
        //}

        private void LoadCategories()
        {
            try
            {
                //categoriesFlowPanel.Controls.Clear();

                var categories = _categoryService.GetAll().ToList();
                //int totalRows = (categories.Count + 1) / 2; 

                //for (int i = 0; i < totalRows; i++)
                //{
                //    Panel rowPanel = new Panel
                //    {
                //        Width = categoriesFlowPanel.ClientSize.Width,
                //        Height = 350,
                //        BackColor = categoriesFlowPanel.BackColor,
                //        Dock = DockStyle.Top,
                //    };

                //    for (int j = 0; j < 2 && (i * 2 + j) < categories.Count; j++)
                //    {
                //        Panel categoryCard = CreateCategoryCard(categories[i * 2 + j]);
                //        categoryCard.Dock = DockStyle.Left;
                //        categoryCard.Margin = new Padding(20);
                //        rowPanel.Controls.Add(categoryCard);
                //    }

                //    rowPanel.Left = (categoriesFlowPanel.ClientSize.Width - rowPanel.Width) / 2;

                //    categoriesFlowPanel.Controls.Add(rowPanel);
                //}

                //categoriesFlowPanel.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in LoadCategories: {ex.Message}\n\nStack Trace: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //private Panel CreateCategoryCard(Category category)
        //{
        //    Panel cardPanel = new Panel
        //    {
        //        Width = (categoriesFlowPanel.ClientSize.Width / 2) - 40, 
        //        Height = 300,
        //        BorderStyle = BorderStyle.FixedSingle,
        //        BackColor = Color.FromArgb(50, 50, 50),
        //        Margin = new Padding(10) ,
               
        //    };


        //    PictureBox pictureBox = new PictureBox
        //    {
        //        Dock = DockStyle.Top,
        //        Height = 280,
        //        SizeMode = PictureBoxSizeMode.StretchImage
        //    };

        //    string projectRootPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\"));
        //    string imagePath = Path.Combine(projectRootPath, category.CategoryImage);

        //    if (File.Exists(imagePath))
        //    {
        //        // Use the image file
        //        pictureBox.Image = Image.FromFile(imagePath);
        //    }
        //    else
        //    {
        //        MessageBox.Show($"Image file not found: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }



        //    pictureBox.Image = Image.FromFile(imagePath);

        //    Label nameLabel = new Label
        //    {
        //        Text = category.CategoryName,
        //        Dock = DockStyle.Top,
        //        TextAlign = ContentAlignment.MiddleCenter,
        //        Font = new Font("Snap ITC", 12, FontStyle.Italic),
        //        Height = 50,
        //        ForeColor = Color.WhiteSmoke
        //    };

        //    cardPanel.Controls.Add(nameLabel);
        //    cardPanel.Controls.Add(pictureBox);

        //    cardPanel.Left = (categoriesFlowPanel.ClientSize.Width - cardPanel.Width) / 2;
   

        //    return cardPanel;
        //}

        private void OpenDishesForm(Category selectedCategory)
        {
            Dishes dishesForm = new Dishes();
            dishesForm.SelectedCategory = selectedCategory;
            dishesForm.Show();
            dishesForm.BringToFront();
        }

 
    }
}