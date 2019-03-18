using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TestProduct.DAL.DataContext;
namespace TestProduct.BAL
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Model.Category, TestProduct.DAL.DataContext.Category>();
                x.CreateMap<Model.Product, TestProduct.DAL.DataContext.Product>();
                x.CreateMap<Model.Attribute, TestProduct.DAL.DataContext.Attribute>().ForMember(dest=>dest.Name,opt=>opt.MapFrom(src=>src.AttributeName)).ReverseMap();
                x.CreateMap<Model.ProductAttributeMap, TestProduct.DAL.DataContext.ProductAttributeMap>();
            });
        }
    }
}
