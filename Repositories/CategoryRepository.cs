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
        

        public List<Category> GetAllCategories()
        {
            return categoryDAO.GetAllCategories().ToList();
        }
    }
}
