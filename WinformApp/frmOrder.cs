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
    public partial class frmOrder : Form
    {
        IOrderReposistory orderReposistory = new OrderRepository();
        public frmOrder()
        {
            InitializeComponent();

        }

        public void LoadData()
        {
            dgvOrders.DataSource = orderReposistory.GetAllOrders().ToList();
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
    
            LoadData();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var list = orderReposistory.GetAllOrders().Where(p => p.OrderDate <= dtpEndDate.Value.Date && p.OrderDate >= dtpStartDate.Value.Date).ToList();
            if (list != null)
            {
                dgvOrders.DataSource = list;
            }
            else
            {
                MessageBox.Show("Cannot Find Any Order. Please Try again !", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
