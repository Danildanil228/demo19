using demo19.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demo19
{
    public partial class UserControl1 : UserControl
    {
        private Form1 form1;
        private Product product;
        public UserControl1(Form1 _form1, Product _product)
        {
            InitializeComponent();
            this.form1 = _form1;
            this.product = _product;

            try
            {
                category.Text = product.Category;
                label2.Text = product.ProductName;
                opis.Text = product.Description;
                prois.Text = product.Proisvod;
                post.Text = product.Postavshik;
                price.Text = product.Price.ToString();
                unit.Text = product.Unit;
                count.Text = product.QuantityInStock.ToString();
                label9.Text = product.CurrentDiscount.ToString();
            }
            catch { }
        }
    }
}
