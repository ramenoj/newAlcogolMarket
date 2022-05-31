using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.Products;
using newAlcogolMarket.Models;

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
            {
                return NotFound();
            }
            else
            {
                return View(product);
            }
        }
        [HttpPost]
        public IActionResult Details(ProductViewModel model)
        {
            return Redirect("/BasketItem/Add?productId=" + model.Product.Id + "&quantity=" + model.Amount);
        }
    }
}