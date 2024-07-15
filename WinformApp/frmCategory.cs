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
            if(tbCategory.Text == null)
            {
                MessageBox.Show("Please enter an Category Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var category = new Category();
            category.CategoryName = tbCategory.Text;
            if (categoryRepository.GetAllCategories().Where(c => c.CategoryName.Equals(tbCategory.Text)).FirstOrDefault() != null) {

                MessageBox.Show("Category Name already exists. Please enter a different category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCategory.Focus(); // Đặt focus lại vào textbox email để người dùng nhập lại
                return;
            }
            categoryRepository.AddCategory(category);
            LoadData();
            ClearData();

        }

        private void UpdateCategory(object sender, EventArgs e)
        {

        }

        private void DeleteCategory(object sender, EventArgs e)
        {


        }

        private void ClickCellShowContent(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dgvCategory.DataSource = categoryRepository.GetAllCategories().ToList();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dgvCategory.Rows[e.RowIndex];
                tbId.Text = rowSelected.Cells["CategoryId"].Value.ToString();
                tbCategory.Text = rowSelected.Cells["CategoryName"].Value.ToString();

            }
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
    }
}
