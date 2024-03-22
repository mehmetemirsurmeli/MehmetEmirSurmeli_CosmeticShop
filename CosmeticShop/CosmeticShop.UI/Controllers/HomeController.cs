using CosmeticShop.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CosmeticShop.UI.Controllers
{
    public class HomeController : Controller
    {
      private readonly IProductService _productManager;

        public HomeController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
           
            return View();
        }
    }
}
