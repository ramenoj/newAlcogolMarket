using Microsoft.AspNetCore.Mvc;

namespace newAlcogolMarket.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(string tableName,int id)
        {
            switch (tableName)
            {
                case "Absent":
                    
                    break;

            }

            return View();
        }
    }
}
