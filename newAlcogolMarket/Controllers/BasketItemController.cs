using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.BasketItems;

namespace newAlcogolMarket.Controllers
{
    public class BasketItemController : Controller
    {
        private readonly BasketItemManager _manager;
        public BasketItemController(BasketItemManager manager)
        {
            _manager = manager;
        }
        public IActionResult Add(int ProductId, int Quantity)
        {

        }
    }
}
