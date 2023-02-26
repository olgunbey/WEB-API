using Microsoft.AspNetCore.Mvc;
using WebAPP.Services;

namespace WebAPP.Controllers
{
    public class ProductController : Controller
    {
        private ProductApiService productApiService;
        public ProductController(ProductApiService _productApiService)
        {
            productApiService= _productApiService;
        }
        public async Task<IActionResult> Index()
        
        {
            return View(await productApiService.Apis());
        }
    }
}
