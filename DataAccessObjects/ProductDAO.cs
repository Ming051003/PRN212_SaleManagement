using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        public List<Product> GetAllProducts()
        {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext()) { 
                return dbContext.Products.Include(c => c.Category).ToList();
            }
        }

        public Product GetProductById(int productID) {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext()) {
                return dbContext.Products.FirstOrDefault(p => p.ProductId == productID);
            }
        }

        public void AddProduct(Product product) {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext()) { 
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
            }
        }

        public void UpdateProduct(Product product) {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext()) { 
                dbContext.Products.Update(product);
                dbContext.SaveChanges();
            }
        }

        public void DeleteProduct(int productID) {
            using (SaleStoreDbContext dbContext = new SaleStoreDbContext()) { 

                Product product = GetProductById(productID);
                if (product != null) {
                    dbContext.Products.Remove(product);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
