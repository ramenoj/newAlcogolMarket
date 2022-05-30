using Microsoft.AspNetCore.Mvc;

namespace newAlcogolMarket.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string tableName,int id)
        {
            return View();
        }
    }
}