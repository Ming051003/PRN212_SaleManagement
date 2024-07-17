using BusinessObjects.Models;
using DataAccessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class frmCheckOut : Form
    {
        IProductRepository productRepository = new ProductRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        ProductDAO ProductDAO = new ProductDAO();
        OrderDetailDAO orderDetailDAO = new OrderDetailDAO();

        int memberId = 1; // Replace this with the actual member ID

        public frmCheckOut()
        {
            InitializeComponent();
            var list = orderDetailRepository.GetAllOrderDetails().Where(p => p.Discount != 1)
                .Select(p => new { p.OrderId, p.ProductId, p.UnitPrice, p.Quantity, p.Discount }).ToList();

            dgvOrderDetails.DataSource = list;
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            var list = orderDetailRepository.GetAllOrderDetails().Where(p => p.Discount != 1)
                .Select(p => new { p.OrderId, p.ProductId, p.UnitPrice, p.Quantity, p.Discount }).ToList();

            dgvOrderDetails.DataSource = list;
        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dgvOrderDetails.Rows[e.RowIndex];
                // rowSelected.Cells["City"].Value;
                //rowSelected.Cells[3].Value;

            }
            btnCheckout.Enabled = false;// bam vo la o check out bi mo di ko cho sai nua
            btnRemoveCart.Enabled = true;
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetails.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedRowIndex = dgvOrderDetails.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvOrderDetails.Rows[selectedRowIndex];
            List<string> cellValues = new List<string>();
            foreach (DataGridViewCell cell in row.Cells)
            {
                string cellValue = cell.Value?.ToString() ?? string.Empty;
                cellValues.Add(cellValue);
            }

            int orderId = int.Parse(cellValues[0]);
            int productId = int.Parse(cellValues[1]);

            OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
            orderDetailDAO.DeleteOrderDetail(orderId, productId);

            frmCheckOut_Load(null, null);
            MessageBox.Show("Remove a product done", "Notification", MessageBoxButtons.OK);
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();

            if (dgvOrderDetails.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a row to checkout.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedRowIndex = dgvOrderDetails.SelectedCells[0].RowIndex;
            // DataGridViewRow row = dgvListCart.Rows[selectedRowIndex];
            List<string> cellValues = new List<string>();
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellValue = cell.Value?.ToString() ?? string.Empty;
                    cellValues.Add(cellValue);
                }

                var order = new OrderDetail
                {
                    OrderId = int.Parse(cellValues[0]),
                    ProductId = int.Parse(cellValues[1]),
                    UnitPrice = decimal.Parse(cellValues[2]),
                    Quantity = int.Parse(cellValues[3]),
                    Discount = 1
                };

                Product product = productDAO.GetAllProducts().FirstOrDefault(p => p.ProductId == int.Parse(cellValues[1]));
                if (product != null)
                {
                    product.UnitsInStock -= int.Parse(cellValues[3]);
                    productDAO.UpdateProduct(product);
                }

                orderDetailRepository.UpdateOrderDetail(order);
                cellValues.Clear();


            };

            MessageBox.Show("Pay a product done", "Notification", MessageBoxButtons.OK);
            dgvOrderDetails.Update();

            
            var list = orderDetailRepository.GetAllOrderDetails().Where(p => p.Discount != 1)
                .Select(p => new { p.OrderId, p.ProductId, p.UnitPrice, p.Quantity, p.Discount }).ToList();
            dgvOrderDetails.DataSource = list;
        }
    }
    
}
