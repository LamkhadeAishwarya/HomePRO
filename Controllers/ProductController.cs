using HomePRO.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomePRO.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            ViewData["Message"] = "This is Product List";
              List<Product> products = new List<Product>()
              {
                  new Product{ Id=1,Name="pen",Price=50},
                  new Product{ Id=2,Name="pencil",Price=100},
                  new Product{ Id=3,Name="Bag",Price = 500},

              };
              ViewBag.Product= products;
           
            return View();
        }
    }
}
