using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.Products;

namespace newAlcogolMarket.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager _manager;

        public ProductController(IProductManager manager)
        {
            _manager = manager;
        }

        public IActionResult Details(int id)
        {
            var product =  _manager.Get(id);
            if(product == null)
            {a
                return NotFound();
            }
            else
            {
                return View(product);
            }
        }
    }
}