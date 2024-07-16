using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO = new ProductDAO();

        public void AddProduct(Product product)
        {
            productDAO.AddProduct(product);
        }

        public void DeleteProduct(int productID)
        {
            productDAO.DeleteProduct(productID);
        }

        public List<Product> GetAllProducts()
        {
            return productDAO.GetAllProducts().ToList();
        }

        public Product GetProductById(int productID)
        {
            return productDAO.GetProductById(productID);
        }

        public void UpdateProduct(Product product)
        {
            productDAO.UpdateProduct(product);
        }
    }
}
