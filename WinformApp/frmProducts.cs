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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == null)
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
            product.Weight = txtWeight.Text;
            product.UnitPrice = decimal.Parse(txtUnitPrice.Text);

            productRepository.AddProduct(product);
            MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearData();
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

        private void frmProducts_Load_1(object sender, EventArgs e)
        {
            LoadData();
            LoadCate();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int prodID;
            if (int.TryParse(txtProductID.Text, out prodID))
            {
                if (prodID != null)
                {
                    if (MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        productRepository.DeleteProduct(prodID);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Product ID is empty. Please choose a different ID.",
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
            ClearData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchProduct.Text.Trim().ToLower();
            var list = productRepository.GetAllProducts().Where(p => p.ProductName.ToLower().Contains(keyword)).Select(p => new
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                UnitStock = p.UnitsInStock,
                //CategoryId = p.CategoryId,
                CategoryName = p.Category.CategoryName,
                Weitght = p.Weight,
                UnitPrice = p.UnitPrice
            }).ToList();
            dgvProductList.DataSource = list;
        }
    }
}
