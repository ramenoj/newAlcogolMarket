using Microsoft.AspNetCore.Mvc;

namespace newAlcogolMarket.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}