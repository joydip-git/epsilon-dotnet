using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return this.View();
        }
        public ActionResult AddProductRecord()
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
