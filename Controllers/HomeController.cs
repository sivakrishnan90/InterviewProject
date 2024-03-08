
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using testrobo.Models;

namespace testrobo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            Units u = new Units();
            return View(u);
        }

        [HttpPost]
        public IActionResult Index(Units u)
        {            
            return View(u);
        }

      

    }
}
