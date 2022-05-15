using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Models;
using System.Diagnostics;

namespace newAlcogolMarket.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult basket()
        {
            return View();
        }

        public IActionResult Wine()
        {
            return View();
        }

        public IActionResult Liquor()
        {
            return View();
        }

        public IActionResult Champagne()
        {
            return View();
        }

        public IActionResult Whisky()
        {
            return View();
        }

        public IActionResult Cognac()
        {
            return View();
        }

        public IActionResult beer()
        {
            return View();
        }

        public IActionResult Absinthe()
        {
            return View();
        }

        public IActionResult Vodka()
        {
            return View();
        }

        public IActionResult Snacks()
        {
            return View();
        }

        public IActionResult Softdrinks()
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