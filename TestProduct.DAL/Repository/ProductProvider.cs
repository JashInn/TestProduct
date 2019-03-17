using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProduct.DAL.DataContext;
using TestProduct.DAL.Providers;
using TestProduct.DAL.RepositoryInterfaces;

namespace TestProduct.DAL.Repository
{
    public class ProductProvider: GenericProvider<DataModel, Product>, IProductRepository
    {
        public override IQueryable<Product> GetAll()
        {
            return Context.Products.Include("Category");
        }
    }
}
