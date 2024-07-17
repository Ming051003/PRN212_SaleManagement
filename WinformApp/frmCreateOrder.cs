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
    public partial class frmCreateOrder : Form
    {
        IProductRepository productRepository;
        ICategoryRepository categoryRepository;
        IOrderDetailRepository orderDetailRepository;
        IMemberRepository memberRepository;


        public frmCreateOrder()
        {
            InitializeComponent();
            productRepository = new ProductRepository();
            categoryRepository = new CategoryRepository();
            orderDetailRepository = new OrderDetailRepository();
            memberRepository = new MemberRepository();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgvProducts.DataSource = productRepository.GetAllProducts().Select(p => new
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


        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int productID = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                Product product = productRepository.GetProductById(productID);

                txtProductID.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProductName;
                txtUnitInStock.Text = product.UnitsInStock.ToString();
                txtUnitPrice.Text = product.UnitPrice.ToString();
            }
        }

        private void btnLoadProduct_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            frmCheckOut frmCheckOut = new frmCheckOut();
            frmCheckOut.ShowDialog();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var quantityTxt = txtQuantity.Text;
            int quantity;

            if (int.TryParse(quantityTxt, out quantity))
            {
                if (quantity <= 0) MessageBox.Show("Quantity cannot <= 0", "Warning", MessageBoxButtons.OK);
                else if (txtProductID.Text.ToString() != "")
                {

                    Random random = new Random();
                    var products = (new OrderDetail
                    {
                        OrderId = random.Next(),
                        ProductId = Int16.Parse(txtProductID.Text),
                        UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                        Quantity = quantity,
                        Discount = 0
                    });
                    orderDetailRepository.AddOrderDetail(products);
                    MessageBox.Show("Add a product done", "Notification", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Please select a product", "Warning", MessageBoxButtons.OK);

            }
            else MessageBox.Show("Please input a number", "Warning", MessageBoxButtons.OK);

        }



    }
}
