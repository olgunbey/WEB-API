using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebAPP.Models;
using WebAPP.Services;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       
        public ProductController()
        {
          
        }
        [HttpGet("ProductListele")]
        public IActionResult ProductListele()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ ProductID=1,ProductName="olgun"},
                new Product(){ ProductID=2,ProductName="ahmet"},
                new Product(){ ProductID=3,ProductName="mehmet"},
                new Product(){ ProductID=4,ProductName="eren"},
            };
            
            return Ok(products);
        }
    }
}
