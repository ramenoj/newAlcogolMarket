using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.BasketItems;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Controllers
{
    public class BasketItemController : Controller
    {

        private readonly BasketItemManager _manager;
        public BasketItemController(BasketItemManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Add(int productId, int quantity)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return NotFound();
            var item = new BasketItem
            {
                ProductId = productId,
                Quantity = quantity,
                UserId = (int)userId,
                DateCreated = DateTime.Now,
            };
            await _manager.Create(item);
            return RedirectToRoute("Item/Details/" + productId);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            await _manager.Delete(Id);
            return RedirectToAction("Basket", "User");
        }
        
    }
}
