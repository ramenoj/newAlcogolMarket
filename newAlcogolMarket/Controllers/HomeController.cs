using newAlcogolMarket.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using newAlcogolMarket.Models;
using newAlcogolMarket.Manager.Users;
using newAlcogolMarket.Manager.Products;

namespace HelloMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductManager _productManager;

        public HomeController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        public IActionResult Index()
        {
            var products = _productManager.FilterByRating();
            return View(products);
        }
    }
}