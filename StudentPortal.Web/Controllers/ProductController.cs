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
            if (productId == null)
            {
                // Handle case where productId is not provided
                // For example, redirect to a different action or display an error message
                // return RedirectToAction("Index", "Home"); // Redirect to the home page
                // Or return a custom error view
                // return View("Error", new ErrorViewModel { ErrorMessage = "No product ID provided." });
            }

            // Your logic to retrieve product details based on the productId
            // var product = productService.GetProductById(productId.Value);

            // if (product == null)
            // {
            //     return NotFound(); // Handle case where product is not found
            // }

            // Create a ProductViewModel object to pass to the view
            var productViewModel = new ProductViewModel
            {
                ProductId = 12,
                ProductName = "amintest",
                Description = "amin test prod",
                Price = 123.45m,
                // Add more properties as needed
            };

            // Pass the ProductViewModel to the view
            return View(productViewModel);
        }
        
        [HttpGet]
        public IActionResult ViewProduct()
        {
            // Assuming you want to return a simple string response
            return Ok($"This is a Get request to the ViewProduct action.");
        }
        
        [HttpPost]
        public IActionResult ViewProduct([FromBody] int id)
        {
            // Assuming you want to return the same value posted
            return Ok($"This is a Post request to the ViewProduct action with id = {id}.");
        }


    }
    
}

