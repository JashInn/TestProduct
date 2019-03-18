using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProduct.BAL.ServiceInterfaces;
using TestProduct.BAL.Services;

namespace TestProduct.Controllers
{
    public class AttributeController : Controller
    {
        IAttributeService attributeService;
        IProductAttributeMapService productAttributeMapService;
        public AttributeController()
        {
            attributeService = new AttributeService();
            productAttributeMapService = new ProductAttributeMapService(); 
        }
        // GET: Attribute
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAttributesForProductByCategory(int id)
        {
            var attributeList = productAttributeMapService.GetProductAttributeMapByCategoryIdForProductCreate(id);
            return Json(attributeList, JsonRequestBehavior.AllowGet);
        }
    }
}