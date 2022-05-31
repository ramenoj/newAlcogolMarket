using newAlcogolMarket.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using newAlcogolMarket.Models;
using newAlcogolMarket.Manager.Users;
using newAlcogolMarket.Manager.Products;
using newAlcogolMarket.Manager.Snacks;

namespace HelloMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductManager ProductManager;
        private readonly ISnackManager SnackManager;
        public HomeController(IProductManager productManager, ISnackManager snackManager)
        {
            ProductManager = productManager;
            SnackManager = snackManager;
        }

        

        
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult basket()
        {
            return View();
        }

        public async Task<IActionResult> Wine()
        {
            var Wine = await ProductManager.GetAllByCategory("Вино");
            return View(Wine);
        }

        public async Task<IActionResult> Liquor()
        {
            var Liquor = await ProductManager.GetAllByCategory("Ликер");
            return View(Liquor);
        }

        public async Task<IActionResult> Champagne()
        {
            var Champagne = await ProductManager.GetAllByCategory("Шампанское");
            return View(Champagne);
        }

        public async Task<IActionResult> Whisky()
        {
            var Whisky = await ProductManager.GetAllByCategory("Виски");
            return View(Whisky);
        }

        public async Task<IActionResult> Cognac()
        {
            var Cognac = await ProductManager.GetAllByCategory("Коньяк");
            return View(Cognac);
        }

        public async Task<IActionResult> Beer()
        {
            var beer = await ProductManager.GetAllByCategory("Пиво");
            return View(beer);
        }

        public async Task<IActionResult> Absinthe()
        {
            var absinthe = await ProductManager.GetAllByCategory("Абсент");
            return View(absinthe);

        }

        public async Task<IActionResult> Vodka()
        {
            var Vodka = await ProductManager.GetAllByCategory("Водка");
            return View(Vodka);
        }

        public async Task<IActionResult> Snacks()
        {
            var Snacks = await SnackManager.GetAll();
            return View(Snacks);
        }

        public async Task<IActionResult> Rom()
        {
            var Rom = await ProductManager.GetAllByCategory("Ром");
            return View(Rom);
        }

        public async Task<IActionResult> Tequilla()
        {
            var Tequilla = await ProductManager.GetAllByCategory("Текила");
            return View(Tequilla);
        }

        public IActionResult Details()
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