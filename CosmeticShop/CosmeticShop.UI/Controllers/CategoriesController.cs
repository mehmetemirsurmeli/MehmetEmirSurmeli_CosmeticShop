using CosmeticShop.Business.Abstract;
using CosmeticShop.Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticShop.UI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IProductService _productManager;
        private readonly ICategoryService _categoryManager;
        public CategoriesController(IProductService productManager, ICategoryService categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productManager.GetAllNonDeletedAsync(false);
            return View(products.Data);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
