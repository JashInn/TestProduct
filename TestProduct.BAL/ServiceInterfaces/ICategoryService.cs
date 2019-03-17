using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProduct.BAL.Model;
namespace TestProduct.BAL.ServiceInterfaces
{
    public interface ICategoryService
    {
        Category GetCategoryById(int id);
        List<Category> GetAllCategory();
        void AddNewCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
