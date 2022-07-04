using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.BasketItems;
using newAlcogolMarket.Manager.Products;
using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Controllers
{
    public class BasketItemController : Controller
    {

        private readonly IBasketItemManager _manager;
        private readonly IProductManager _productManager;
        public BasketItemController(IBasketItemManager manager, IProductManager productManager)
        {
            _manager = manager;
            _productManager = productManager;
        }
        public async Task<IActionResult> Add(int productId, int quantity)
        {
           var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("SignIn","User");
            while(quantity > 0)
            {
                var item = new BasketItem
                {
                    ProductId = productId,
                    Quantity = quantity,
                    UserId = (int)userId,
                    DateCreated = DateTime.Now,
                    Price = _productManager.Get(productId).Price
                };
                await _manager.Create(item);
                quantity--;
            }
            
            return Redirect("/Product/Details/" + productId);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            await _manager.Delete(Id);
            return RedirectToAction("Basket", "User");
        }
        public async Task<IActionResult> Pay()
        {
            await _manager.Clear();
            return RedirectToAction("Thanks","User");

        }
    }
}
