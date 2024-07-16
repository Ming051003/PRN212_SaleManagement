using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICategoryRepository
    {
        public List<Category> GetAllCategories();
        public void AddCategory(Category category);

        public void UpdateCategory(Category category);
        public void DeleteCategory(int categoryID);
        public Category GetCategoryByID(int categoryID);
    }
}
