using DISample.Service;
using Microsoft.AspNetCore.Mvc;

namespace DISample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        // TODO: In case difference
        /*public IActionResult Index([FromServices] IProductService productService)
        {
            var product = productService.GetAll();
            return View(product);
        }*/
    }
}
