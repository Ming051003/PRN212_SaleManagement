using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
        public Product GetProductById(int productID);

        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int productID);
    }
}
