using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    
    public class OrderDetailRepository : IOrderDetailRepository
    {
        OrderDetailDAO orderDetailDAO = new OrderDetailDAO();

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            orderDetailDAO.AddOrderDetail(orderDetail);
        }

        //public void DeleteOrderDetail(int orderId)
        //{
        //    orderDetailDAO.DeleteOrderDetail(orderId);
        //}

        public List<OrderDetail> GetAllOrderDetails()
        {
           return orderDetailDAO.GetAllOrderDetails().ToList();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            orderDetailDAO.UpdateOrderDetail(orderDetail);
        }

        //public List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        //{
        //    return orderDetailDAO.GetOrderDetailsByOrderId(orderId);
        //}
    }
}
