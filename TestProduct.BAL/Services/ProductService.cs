using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TestProduct.BAL.Model;
using TestProduct.BAL.ServiceInterfaces;
using TestProduct.DAL.Repository;

namespace TestProduct.BAL.Services
{
    public class ProductService : IProductService
    {
        ProductProvider productProvider = new ProductProvider();
        public void AddNewProduct(Product product)
        {
            product.ProductAttributeMaps.ForEach(m => m.Attribute = null);
            productProvider.Add(Mapper.Map<TestProduct.DAL.DataContext.Product>(product));
            productProvider.Save();
        }

        public void DeleteProduct(int id)
        {
            productProvider.Delete(new DAL.DataContext.Product() { Id = id });
            productProvider.Save();
        }

        public List<Product> GetAllProducts()
        {
            return Mapper.Map<List<Product>>(productProvider.GetAll().ToList());
        }

        public Product GetProductById(int id)
        {
            return Mapper.Map<Product>(productProvider.FindBy(c => c.Id == id).FirstOrDefault());
        }

        public void UpdateProduct(Product product)
        {
            productProvider.Edit(Mapper.Map<TestProduct.DAL.DataContext.Product>(product));
            productProvider.Save();
        }
    }
}
