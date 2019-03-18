using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using TestProduct.BAL.Model;
using TestProduct.BAL.ServiceInterfaces;
using TestProduct.DAL.Repository;

namespace TestProduct.BAL.Services
{
    public class ProductAttributeMapService : IProductAttributeMapService
    {
        ProductAttributeMapProvider productAttributeMapProvider = new ProductAttributeMapProvider();
        AttributeService attributeService = new AttributeService();
        public List<ProductAttributeMap> GetAllProductAttributeMap()
        {
            return Mapper.Map<List<ProductAttributeMap>>(productAttributeMapProvider.GetAll().ToList());
        }

        public List<ProductAttributeMap> GetProductAttributeMapByCategoryIdForProductCreate(int CategoryId)
        {
            var attributeList = attributeService.GetAllAttributesByCategoryId(CategoryId);
            return attributeList.Select(a => new ProductAttributeMap() { AttributeId = a.Id, Attribute = a }).ToList();
        }

        public ProductAttributeMap GetProductAttributeMapById(int id)
        {
            return Mapper.Map<ProductAttributeMap>(productAttributeMapProvider.FindBy(c => c.Id == id).FirstOrDefault());
        }

        public List<ProductAttributeMap> GetProductAttributeMapByProductId(int ProductId)
        {
            return Mapper.Map<List<ProductAttributeMap>>(productAttributeMapProvider.FindBy(c => c.ProductId == ProductId).ToList());
        }
    }
}
