using Microsoft.AspNetCore.Mvc;
using StudentPortal.Web.Models;
using System.Diagnostics;
using Newtonsoft.Json;

namespace StudentPortal.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [Route("api/helloworld")]
        public IActionResult HelloWorld()
        {
            return Ok("Hello, world!");
        }
        
        // TODO 1: fix this.
        [HttpPost]
        [Route("api/customroute")] // Change the route name here
        public IActionResult HelloWorld([FromBody] string jsonString)
        {
            // Deserialize the JSON string into an object
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            // Extract the value you want to display
            string value = jsonObject.value;

            // Return the response
            return Ok($"Hello, {value}!");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
