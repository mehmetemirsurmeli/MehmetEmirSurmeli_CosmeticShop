using Microsoft.AspNetCore.Mvc;

namespace CosmeticShop.UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
