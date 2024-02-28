using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Web.Models;
using System.Diagnostics;

namespace StudentPortal.Web.Controllers
{
    public class ProductController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public ProductController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult ViewProduct(int? productId)
        {
            // Your logic to retrieve and display the product with the given productId
            return View();
        }

        // Other actions related to managing products can be added here
    }
    
}

