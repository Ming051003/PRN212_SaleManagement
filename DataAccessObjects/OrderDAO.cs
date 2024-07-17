using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        public List<Order> GetAllOrders()
        {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext())
            {
                return dbContext.Orders.ToList();
            }
        }
    }
}
