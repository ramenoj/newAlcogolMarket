using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.Categories;
using newAlcogolMarket.Manager.Products;
using newAlcogolMarket.Manager.Recommendations;
using newAlcogolMarket.Manager.Sizes;
using newAlcogolMarket.Manager.Snacks;
using newAlcogolMarket.Manager.Users;
using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;
using System.Security.Claims;

namespace newAlcogolMarket.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserManager _usermanager;
        private readonly IProductManager _productmanager;
        private readonly IRecommendationManager _recommendation;
        private readonly ICategoryManager _category;
        private readonly ISizeManager _size;
        private readonly ISnackManager _snack;

        public UserController(IUserManager usermanager, IProductManager productmanager, IRecommendationManager recommendation, ICategoryManager category, ISizeManager size, ISnackManager snack)
        {
            _usermanager = usermanager;
            _productmanager = productmanager;
            _recommendation = recommendation;
            _category = category;
            _size = size;
            _snack = snack;
        }

        [Authorize(Roles ="admin")]
        public async Task<IActionResult> Index()
        {
            var userGetall = _usermanager.GetAll();
            return View(await userGetall);
        }
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            var fakeuser = _usermanager.Get(user);
            if (fakeuser!=null)
            {
                return RedirectToAction("Register");
            }
            await _usermanager.Add(user);
            return RedirectToAction("SignIn");
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(User fakeuser)
        {
            var user = _usermanager.Get(fakeuser);
            if (user == null)
            {
                return RedirectToAction("SignIn");
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, fakeuser.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, fakeuser.Login),
            };
            var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("SignIn");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _usermanager.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(User user)
        {
            var fakeuser = _usermanager.Get(user);
            if (fakeuser == null)
            {
                await _usermanager.Update(user);
            }
            else
            {
                return RedirectToAction("Update");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        //public async Task<IActionResult> AddProduct(Product product)
        //{
        //    await 
        //}
    }
}