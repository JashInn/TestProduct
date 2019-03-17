using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProduct.BAL.Model;
using TestProduct.BAL.ServiceInterfaces;
using TestProduct.DAL.Repository;
using AutoMapper;
namespace TestProduct.BAL.Services
{
    public class CategoryService : ICategoryService
    {
        CategoryProvider categoryProvider = new CategoryProvider();
        public void AddNewCategory(Category category)
        {            
            categoryProvider.Add(Mapper.Map<TestProduct.DAL.DataContext.Category>(category));            
        }

        public void DeleteCategory(int id)
        {
            categoryProvider.Delete(new DAL.DataContext.Category() { Id = id });
        }

        public List<Category> GetAllCategory()
        {
            return Mapper.Map<List<Category>>(categoryProvider.GetAll().ToList());
        }

        public Category GetCategoryById(int id)
        {
            return Mapper.Map<Category>(categoryProvider.FindBy(c => c.Id == id).FirstOrDefault());
        }

        public void UpdateCategory(Category category)
        {
            categoryProvider.Edit(Mapper.Map<TestProduct.DAL.DataContext.Category>(category));
        }
    }
}
