using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        public List<Category> GetAllCategories()
        {
            using(SaleStoreDbContext context = new SaleStoreDbContext())
            {
                return context.Categories.ToList();
            }
        }

        public void AddCategoyry(Category category)
        {
            using(SaleStoreDbContext context= new SaleStoreDbContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

    }
}
