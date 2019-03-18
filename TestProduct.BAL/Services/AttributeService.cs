using AutoMapper;
using System;
using System.Collections.Generic;
using TestProduct.BAL.ServiceInterfaces;
using TestProduct.DAL.Repository;
using System.Linq;
using TestProduct.BAL.Model;

namespace TestProduct.BAL.Services
{
    public class AttributeService : IAttributeService
    {
        AttributeProvider attributeProvider = new AttributeProvider();
        public List<Model.Attribute> GetAllAttributes()
        {
            return Mapper.Map<List<Model.Attribute>>(attributeProvider.GetAll().ToList());
        }

        public List<Model.Attribute> GetAllAttributesByCategoryId(int CategoryId)
        {
            return Mapper.Map<List<Model.Attribute>>(attributeProvider.FindBy(a => a.AttributeCategoryMaps.Any(am => am.CategoryId == CategoryId)).ToList());
        }

        public List<ProductAttributeMap> GetAllAttributesByCategoryIdForProductCreate(int CategoryId)
        {
            return Mapper.Map<List<Model.ProductAttributeMap>>(attributeProvider.FindBy(a => a.AttributeCategoryMaps.Any(am => am.CategoryId == CategoryId)).ToList());
        }

        public Model.Attribute GetAttributeById(int id)
        {
            return Mapper.Map<Model.Attribute>(attributeProvider.FindBy(c => c.Id == id).FirstOrDefault());
        }
    }
}
