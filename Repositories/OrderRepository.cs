using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderReposistory
    {

        OrderDAO orderDAO= new OrderDAO();
        public List<Order> GetAllOrders()
        {
            return orderDAO.GetAllOrders().ToList();
        }
    }
}
