using TestProduct.DAL.DataContext;
using TestProduct.DAL.Providers;
using TestProduct.DAL.RepositoryInterfaces;

namespace TestProduct.DAL.Repository
{
    public class AttributeProvider : GenericProvider<DataModel, Attribute>, IAttributeRepository
    {

    }
}
