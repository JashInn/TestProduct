using TestProduct.DAL.DataContext;
using TestProduct.DAL.Providers;
namespace TestProduct.DAL.RepositoryInterfaces
{
    interface IProductRepository : IProvider<Product>
    {

    }
}
