using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.Snacks;

namespace newAlcogolMarket.Controllers
{
    public class SnackController : Controller
    {
        private readonly ISnackManager _manager;

        public SnackController(ISnackManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> SnackDetails(int id)
        {
            var snack = _manager.Get(id);
            if (snack == null)
            {
                return NotFound();
            }
            else
            {
                return View(snack);
            }
        }
    }
}

