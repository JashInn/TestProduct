using System.Collections.Generic;

namespace TestProduct.BAL.ServiceInterfaces
{
    public interface IProductAttributeMapService
    {
        Model.ProductAttributeMap GetProductAttributeMapById(int id);
        List<Model.ProductAttributeMap> GetAllProductAttributeMap();
        List<Model.ProductAttributeMap> GetProductAttributeMapByProductId(int ProductId);
        List<Model.ProductAttributeMap> GetProductAttributeMapByCategoryIdForProductCreate(int CategoryId);

    }
}
