using BusinessObjects.Models;
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
    public partial class frmCategory : Form
    {
        ICategoryRepository categoryRepository;
        public frmCategory()
        {
            InitializeComponent();
            categoryRepository = new CategoryRepository();
        }
        private void CreateCategory(object sender, EventArgs e)
        {
            if (tbCategory.Text == null)
            {
                MessageBox.Show("Please enter an Category Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var category = new Category();
            category.CategoryName = tbCategory.Text;
            if (categoryRepository.GetAllCategories().Where(c => c.CategoryName.Equals(tbCategory.Text)).FirstOrDefault() != null)
            {

                MessageBox.Show("Category Name already exists. Please enter a different category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCategory.Focus(); // Đặt focus lại vào textbox email để người dùng nhập lại
                return;
            }
            categoryRepository.AddCategory(category);
            MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearData();

        }

        private void UpdateCategory(object sender, EventArgs e)
        {
            if (tbId.Text != null || tbCategory.Text != null)
            {
                int cateID;
                if (int.TryParse(tbId.Text, out cateID))
                {
                    Category category = categoryRepository.GetCategoryByID(cateID);
                    category.CategoryName = tbCategory.Text;
                    if (categoryRepository.GetAllCategories().Where(c => c.CategoryName.Equals(tbCategory.Text)).FirstOrDefault() != null)
                    {

                        MessageBox.Show("Category Name already exists. Please enter a different category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbCategory.Focus(); // Đặt focus lại vào textbox email để người dùng nhập lại
                        return;
                    }
                    categoryRepository.UpdateCategory(category);
                    MessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Category ID is empty. Please choose a different ID.",
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteCategory(object sender, EventArgs e)
        {
            int cateID;
            if (int.TryParse(tbId.Text, out cateID))
            {
                if (cateID != null)
                {
                    if (MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        categoryRepository.DeleteCategory(cateID);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Category ID is empty. Please choose a different ID.",
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
            ClearData();

        }


        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dgvCategory.DataSource = categoryRepository.GetAllCategories().Select(c => new
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
            }).ToList();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dgvCategory.Rows[e.RowIndex];
                tbId.Text = rowSelected.Cells["CategoryId"].Value.ToString();
                tbCategory.Text = rowSelected.Cells["CategoryName"].Value.ToString();
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void ClearData()
        {
            tbId.Text = string.Empty;
            tbCategory.Text = string.Empty;
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text.Trim().ToLower();
            var list = categoryRepository.GetAllCategories().Where(c => c.CategoryName.ToLower().Contains(keyword)).Select(c => new
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
            }).ToList();
            dgvCategory.DataSource = list;
        }
    }
}
