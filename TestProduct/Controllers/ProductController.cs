using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProduct.BAL;
using TestProduct.BAL.Model;
using TestProduct.BAL.ServiceInterfaces;
using TestProduct.BAL.Services;

namespace TestProduct.Controllers
{
    public class ProductController : Controller
    {
        ICategoryService CategoryService;
        IProductService ProductService;
        public ProductController()
        {
            CategoryService = new CategoryService();
            ProductService = new ProductService();
        }
        public ActionResult List()
        {
            List<Product> ProductList = ProductService.GetAllProducts();
            return View(ProductList);
        }
        public ActionResult Create()
        {
            Product model = new Product();
            List<Category> CategoryList = CategoryService.GetAllCategory();
            ViewBag.CategoryId = new SelectList(CategoryList, "Id", "Name");
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Product product,List<ProductAttributeMap> attributeMaps)
        {
            product.ProductAttributeMaps = attributeMaps;
            ProductService.AddNewProduct(product);

            return RedirectToAction("List");
        }
        public ActionResult Details(int id)
        {
            Product product = ProductService.GetProductById(id);
            return View(product);
        }


    }
}