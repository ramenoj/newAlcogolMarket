using newAlcogolMarket.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using newAlcogolMarket.Models;
using newAlcogolMarket.Manager.Users;

namespace HelloMvcApp.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult Index()
        {
            return View();
        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]



    }
}