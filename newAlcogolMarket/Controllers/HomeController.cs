using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Category;
using System.Diagnostics;

namespace newAlcogolMarket.Controllers
{
    public class HomeController : Controller
    {

        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Absents.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Absent absent)
        {
            db.Absents.Add(absent);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}