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
            using (SaleStoreDbContext context = new SaleStoreDbContext())
            {
                return context.Categories.ToList();
            }
        }

        public void AddCategoyry(Category category)
        {
            using (SaleStoreDbContext context = new SaleStoreDbContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public Category GetCategoryByID(int categoyryId)
        {
            using (SaleStoreDbContext context = new SaleStoreDbContext())
            {
                return context.Categories.FirstOrDefault(c => c.CategoryId.Equals(categoyryId));
            }
        }

        public void UpdateCategory(Category category)
        {
            using (SaleStoreDbContext context = new SaleStoreDbContext())
            {
                context.Categories.Update(category);
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int categoyryId)
        {
            using (SaleStoreDbContext context = new SaleStoreDbContext())
            {
                Category category = GetCategoryByID(categoyryId);
                if (category != null) {
                    context.Categories.Remove(category);
                    context.SaveChanges();
                }
            }
        }

    }
}
