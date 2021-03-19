using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ProductManagementSystem.UserInterface.Models;

namespace ProductManagementSystem.UserInterface.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
        public ActionResult GetAllProducts()
        {
            ProductModelManager manager = new ProductModelManager();
            List<ProductViewModel> products = manager.GetAllProductRecords();
            return this.View(products);
        }
        [HttpGet]
        public ActionResult AddProductRecord()
        {
            return this.View();
        }
        [HttpPost]
        public ActionResult AddProductRecord(ProductAddViewModel productAddViewModel)
        {
            ProductModelManager manager = new ProductModelManager();
            var status = manager.AddProductRecord(productAddViewModel);
            this.ViewBag.Status = status;
            //productAddViewModel.Status = status;
            //return this.View(productAddViewModel);
            //return this.View(new ProductAddViewModel { Status = status });
            return this.View();
        }
        //[HttpPost]
        public ActionResult SubmitData(ProductAddViewModel productAddViewModel)
        {
            return this.View();
        }
        public ActionResult UpdateProductRecord()
        {
            return this.View();
        }
        public ActionResult DeleteProductRecord()
        {
            return this.View();
        }
        public ActionResult GetProduct()
        {
            return this.View();
        }
    }
}
