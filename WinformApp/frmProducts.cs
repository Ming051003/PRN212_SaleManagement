using BusinessObjects.Models;
using DataAccessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class frmProducts : Form
    {
        IProductRepository productRepository;
        ICategoryRepository categoryRepository;
        public frmProducts()
        {
            InitializeComponent();
            productRepository = new ProductRepository();
            categoryRepository = new CategoryRepository();
        }
       

        private void btnSearch_Click(object sender, System.EventArgs e)
        {

        }



        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            if(txtProductName.Text == null)
            {
                MessageBox.Show("Please enter an Product Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var product = new Product();
            product.ProductName = txtProductName.Text;
            if (productRepository.GetAllProducts().Where(p => p.ProductName.Equals(txtProductName.Text)).FirstOrDefault() != null)
            {

                MessageBox.Show("Prouduct Name already exists. Please enter a different product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus(); // Đặt focus lại vào textbox email để người dùng nhập lại
                return;
            }
            product.UnitsInStock = int.Parse(txtUnitInStock.Text.ToString());
            product.CategoryId = int.Parse(cboCategory.SelectedValue.ToString());
            product.Weight =txtWeight.Text;
            product.UnitPrice = decimal.Parse(txtUnitPrice.Text);

            productRepository.AddProduct(product);
            MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearData();

        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (txtProductID.Text != null && txtProductName.Text != null)
            {
                int productID;
                if (int.TryParse(txtProductID.Text, out productID))
                {
                    Product product = productRepository.GetProductById(productID);
                   
                    product.ProductName = txtProductName.Text;
                    //if (productRepository.GetAllProducts().Where(p => p.ProductName.Equals(txtProductName.Text)).FirstOrDefault() != null)
                    //{

                    //    MessageBox.Show("Prouduct Name already exists. Please enter a different product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txtProductName.Focus(); // Đặt focus lại vào textbox email để người dùng nhập lại
                    //    return;
                    //}
                    product.UnitsInStock = int.Parse(txtUnitInStock.Text);
                    product.CategoryId = int.Parse(cboCategory.SelectedValue.ToString());
                    product.Weight = txtWeight.Text;
                    product.UnitPrice = decimal.Parse(txtUnitPrice.Text);

                    productRepository.UpdateProduct(product);
                    MessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Product ID is empty. Please choose a different ID.",
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCate();
        }

        public void LoadData()
        {
            dgvProductList.DataSource = productRepository.GetAllProducts().Select(p => new
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                UnitStock = p.UnitsInStock,
                //CategoryId = p.CategoryId,
                CategoryName = p.Category.CategoryName,
                Weitght = p.Weight,
                UnitPrice = p.UnitPrice

            }).ToList();
        }
        public void LoadCate()
        {
            cboCategory.DataSource = categoryRepository.GetAllCategories();
            cboCategory.ValueMember = "CategoryId";
            cboCategory.DisplayMember = "CategoryName";

        }
        public void ClearData()
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtWeight.Text = string.Empty;
            cboCategory.SelectedIndex = -1;
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int productID = int.Parse(dgvProductList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                Product product = productRepository.GetProductById(productID);

                txtProductID.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProductName;
                txtUnitInStock.Text = product.UnitsInStock.ToString();
                cboCategory.SelectedValue = product.CategoryId;
                txtWeight.Text = product.Weight.ToString();
                txtUnitPrice.Text = product.UnitPrice.ToString();
            }


            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
