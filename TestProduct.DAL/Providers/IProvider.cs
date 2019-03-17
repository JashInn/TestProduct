using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestProduct.DAL.Providers
{
    interface IProvider<T> where T:class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);        
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
