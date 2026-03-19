using demo19.Models;

namespace demo19
{
    public partial class Form1 : Form
    {
        private List<Product> productList;
        private Demo19dbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new Demo19dbContext();
            LoadProduct();
        }

        private void LoadProduct()
        {
            try
            {
                productList = db.Products.ToList();
                UpdateForms(productList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке продуктов" + ex.Message);
            }
        }

        private void UpdateForms(List<Product> products)
        {
            panel1.Controls.Clear();
            int yPosition = 0;
            foreach (Product product in products)
            {
                UserControl1 productControl = new UserControl1(this, product);
                productControl.Top = yPosition;
                productControl.Left = 0;
                panel1.Controls.Add(productControl);
                yPosition += productControl.Height + 5;
            }
        }
    }
}
