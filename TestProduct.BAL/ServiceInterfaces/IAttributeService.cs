using System.Collections.Generic;

namespace TestProduct.BAL.ServiceInterfaces
{
    public interface IAttributeService
    {
        Model.Attribute GetAttributeById(int id);
        List<Model.Attribute> GetAllAttributes();
        List<Model.Attribute> GetAllAttributesByCategoryId(int CategoryId);
        List<Model.ProductAttributeMap> GetAllAttributesByCategoryIdForProductCreate(int CategoryId);
    }
}
