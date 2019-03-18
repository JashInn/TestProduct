using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProduct.DAL.DataContext;
using TestProduct.DAL.Providers;
namespace TestProduct.DAL.RepositoryInterfaces
{
    interface ICategoryRepository:IProvider<Category>
    {

    }
}
