using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        CategoryDAO categoryDAO = new CategoryDAO();

        public void AddCategory(Category category) => categoryDAO.AddCategoyry(category);

        public void DeleteCategory(int categoryID)
        {
            categoryDAO.DeleteCategory(categoryID);
        }

        public List<Category> GetAllCategories()
        {
            return categoryDAO.GetAllCategories().ToList();
        }

        public Category GetCategoryByID(int categoryID)
        {
            return categoryDAO.GetCategoryByID(categoryID);
        }

        public void UpdateCategory(Category category)
        {
            categoryDAO.UpdateCategory(category);
        }
    }
}
