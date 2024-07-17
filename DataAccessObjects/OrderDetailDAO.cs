using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        public List<OrderDetail> GetAllOrderDetails()
        {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext())
            {
                return dbContext.OrderDetails.Include(p => p.Product).ToList();
            }
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext())
            {
                dbContext.OrderDetails.Add(orderDetail);
                dbContext.SaveChanges();
            }
        }
   
        public OrderDetail GetOrderDetailById(int orderID)
        {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext())
            {
                return dbContext.OrderDetails.FirstOrDefault(p => p.OrderId == orderID);
            }
        }
        public void DeleteOrderDetail(int orderId, int productId)
        {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext())
            {
                // Find the OrderDetail entry
                var orderDetail = dbContext.OrderDetails.FirstOrDefault(p => p.OrderId == orderId && p.ProductId == productId);

                if (orderDetail != null)
                {
                    // Find the corresponding Product entry
                    var product = dbContext.Products.FirstOrDefault(p => p.ProductId == productId);
                    if (product != null)
                    {
                        // Update the product stock (if necessary)
                        product.UnitsInStock += orderDetail.Quantity;

                        // Save the product stock update
                        dbContext.Products.Update(product);
                    }

                    // Remove the OrderDetail entry
                    dbContext.OrderDetails.Remove(orderDetail);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new KeyNotFoundException($"OrderDetail with OrderId {orderId} and ProductId {productId} not found.");
                }
            }
        }



        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext())
            {
                var existingOrderDetail = dbContext.OrderDetails.FirstOrDefault(p => p.OrderId == orderDetail.OrderId && p.ProductId == orderDetail.ProductId);
                if (existingOrderDetail != null)
                {
                    existingOrderDetail.UnitPrice = orderDetail.UnitPrice;
                    existingOrderDetail.Quantity = orderDetail.Quantity;
                    existingOrderDetail.Discount = orderDetail.Discount;
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
