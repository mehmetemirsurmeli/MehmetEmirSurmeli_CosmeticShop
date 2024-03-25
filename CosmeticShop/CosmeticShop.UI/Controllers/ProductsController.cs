using CosmeticShop.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticShop.UI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productManager;
        private readonly ICategoryService _categoryManager;

        public ProductsController(IProductService productManager, ICategoryService categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productManager.GetAllNonDeletedAsync(false);
            return View(products.Data);
        }

        public async Task<IActionResult> Details(int id)
        {
            return View();
        }
    }
}
