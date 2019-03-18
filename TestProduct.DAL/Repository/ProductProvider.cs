using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            return Context.Products.Include("Category").Include("ProductAttributeMaps").Include("ProductAttributeMaps.Attribute");
        }
        public override IQueryable<Product> FindBy(Expression<Func<Product, bool>> predicate)
        {
            Context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            return Context.Products.Include("Category").Include("ProductAttributeMaps").Include("ProductAttributeMaps.Attribute").Where(predicate);            
        }
        public override void Add(Product entity)
        {
            Context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            base.Add(entity);            
        }
    }
}
