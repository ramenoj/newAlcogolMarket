using newAlcogolMarket.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using newAlcogolMarket.Models;
using newAlcogolMarket.Manager.Users;
using newAlcogolMarket.Manager.Absents;

namespace HelloMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private IUserManager _userManager;
        private IAbsentManager _absentManager;
        public HomeController(IUserManager userManager,IAbsentManager absentManager)
        {
            _userManager = userManager;
            _absentManager = absentManager;
        }
        public async Task<IActionResult> Index()
        {
            var userGetall = _userManager.GetAll();
            return View(await userGetall);
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(User user)
        {
            await _userManager.Add(user);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _userManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}