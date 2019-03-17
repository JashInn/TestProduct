using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProduct.BAL.Model;

namespace TestProduct.BAL.ServiceInterfaces
{
    public interface IProductService
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
        void AddNewProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
