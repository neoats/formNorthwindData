using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        //Refactor by using unit price

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {//The select * from query returns the product in it for the context
                //using is not mandatory but renewing is mandatory
                dgwProduct.DataSource = context.Products.ToList();
            }
        }
        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p=>p.CategoryId == categoryId).ToList();
            }
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategori.DataSource = context.Categories.ToList();
                cbxCategori.DisplayMember = "categoryname";
                cbxCategori.ValueMember = "CategoryId";
          
            }
        }

        private void cbxCategori_SelectedIndexChanged(object sender, EventArgs e)
        {//cbxCategori.SelectedItem an object needs to be converted to a string
         //In runtime, selected value fills and gives an error

            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategori.SelectedValue));
            }
            catch 
            {

             
            }
        
        }
        private void ListProductsBySearch(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key)).ToList();
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            
            if (key == null)
                ListProducts();
            else
                ListProductsBySearch(key);

            
        }
    }
}
