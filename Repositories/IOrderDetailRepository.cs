using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        public List<OrderDetail> GetAllOrderDetails();
        public void AddOrderDetail(OrderDetail orderDetail);
        //public void DeleteOrderDetail(int orderId);
        public void UpdateOrderDetail(OrderDetail orderDetail);
        //public List<OrderDetail> GetOrderDetailsByOrderId(int orderId);
    }
}
