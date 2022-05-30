using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.Categories;
using newAlcogolMarket.Manager.Countries;
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
        private readonly IUserManager _userManager;
        private readonly IProductManager _productManager;
        private readonly IRecommendationManager _recommendationManager;
        private readonly ICategoryManager _categoryManager;
        private readonly ISizeManager _sizeManager;
        private readonly ISnackManager _snackManager;
        private readonly ICountryManager _countryManager;

        public UserController(IUserManager usermanager, IRecommendationManager recommendationmanager, ICategoryManager category, ISizeManager size, ISnackManager snack, IProductManager? productmanager,ICountryManager countrymanager)
        {
            _userManager = usermanager;
            _productManager = productmanager;
            _recommendationManager = recommendationmanager;
            _categoryManager = category;
            _sizeManager= size;
            _snackManager = snack;
            _countryManager = countrymanager;
        }

        [Authorize(Roles ="admin")]
        public async Task<IActionResult> Index()
        {
            var userGetall = _userManager.GetAll();
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
            var fakeuser = _userManager.Get(user);
            if (fakeuser!=null)
            {
                return RedirectToAction("Register");
            }
            await _userManager.Add(user);
            return RedirectToAction("SignIn");
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(User fakeuser)
        {
            HttpContext.Session.SetInt32("Id",fakeuser.Id);
            var user = _userManager.Get(fakeuser);
            if (user == null)
            {
                return RedirectToAction("SignIn");
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Login)
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
            await _userManager.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(User user)
        {
            var fakeuser = _userManager.Get(user);
            if (fakeuser == null)
            {
                await _userManager.Update(user);
            }
            else
            {
                return RedirectToAction("Update");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await _productManager.Add(product);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteProduct(Product product)
        {
            await _productManager.Delete(product.Id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            await _productManager.Update(product);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllProduct(Product product)
        {
            await _productManager.GetAll();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> FilterProduct(Product product)
        {
            await _productManager.Filter(product.Name);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddSize(Size size)
        {
            await _sizeManager.Add(size);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteSize(Size size)
        {
            await _sizeManager.Delete(size.Id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSize(Size size)
        {
            await _sizeManager.Update(size);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllSize()
        {
            await _sizeManager.GetAll();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> FilterProduct(Size size)
        {
            await _sizeManager.Filter(size);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddSnack(Snack snack)
        {
            await _snackManager.Add(snack);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteSnack(Snack snack)
        {
            await _snackManager.Delete(snack.Id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSnack(Snack snack)
        {
            await _snackManager.Update(snack);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllSnack()
        {
            await _snackManager.GetAll();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> FilterSnack(Snack snack)
        {
            await _snackManager.Filter(snack.Name);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddCountry(Country country)
        {
            await _countryManager.Add(country);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCountry(Country country)
        {
            await _countryManager.Delete(country.Id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCountry(Country country)
        {
            await _countryManager.Update(country);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllCountry()
        {
            await _snackManager.GetAll();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> FilterCountry(Country country)
        {
            await _countryManager.Filter(country.Name);
            return RedirectToAction("Index");
        }
    }
}