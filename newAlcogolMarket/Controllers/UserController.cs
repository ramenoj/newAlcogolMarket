﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.Categories;
using newAlcogolMarket.Manager.Countries;
using newAlcogolMarket.Manager.Products;
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
        private readonly ICategoryManager _categoryManager;
        private readonly ISizeManager _sizeManager;
        private readonly ISnackManager _snackManager;
        private readonly ICountryManager _countryManager;

        public UserController(IUserManager usermanager, ICategoryManager category, ISizeManager size, ISnackManager snack, IProductManager productmanager,ICountryManager countrymanager)
        {
            _userManager = usermanager;
            _productManager = productmanager;
            _categoryManager = category;
            _sizeManager= size;
            _snackManager = snack;
            _countryManager = countrymanager;
        }

        [Authorize(Roles ="admin")]
        public async Task<IActionResult> AdminPanel()
        {
            var userGetall = _userManager.GetAll();
            return View(await userGetall);
        }
        public IActionResult UserPanel()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                var Id = (int)HttpContext.Session.GetInt32("UserId");
                var user = _userManager.GetById(Id);
            if (user != null && user.Login == "admin")
            {
                return RedirectToAction("AdminPanel");
            }
            else if (user != null)
                return RedirectToAction("UserPanel");
            }
            

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
            
            var user = _userManager.Get(fakeuser);
            if (user == null)
            {
                return RedirectToAction("SignIn");
            }

            HttpContext.Session.SetInt32("UserId",user.Id);

            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Login)
            };
            var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);
            if (user.Login == "admin")
            {
                return RedirectToAction("AdminPanel");
            }
            else
            {
                return RedirectToAction("UserPanel");
            }
        }
        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            HttpContext.Session.Remove("UserId");
            await HttpContext.SignOutAsync();
            return RedirectToAction("SignIn");
        }
        [HttpGet]
        public IActionResult Basket()
        {
            var userId=HttpContext.Session.GetInt32("UserId");
            if (userId==null)
            {
               return RedirectToAction("SignIn");
            }
            var user = _userManager.GetById((int)userId);
            int totalAmount = 0;
            foreach(var item in user.BasketItems)
            {
                totalAmount += item.Price;
            }
            ViewBag.TotalAmount = totalAmount;
            return View(user.BasketItems);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _userManager.Delete(id);
            return RedirectToAction("AdminPanel");
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
            return RedirectToAction("AdminPanel");
        }
        public IActionResult Thanks()
        {
            return View();
        }
       
        public async Task<IActionResult> ProductView()
        {
            var products = await _productManager.GetAll();
            return View(products);
        }
        public async Task<IActionResult> UserView()
        {
            var users=await _userManager.GetAll();
            return View(users);
        }
        public async Task<IActionResult> SnackView()
        {
            var snacks=await _snackManager.GetAll();
            return View(snacks);
        }
        public async Task<IActionResult> SizeView()
        {
            var sizes=await _sizeManager.GetAll();
            return View(sizes);
        }

        public async Task<IActionResult> CountryView()
        {
            var countries=await _countryManager.GetAll();
            return View(countries);
        }
        public async Task<IActionResult> CategoryView()
        {
            var categories = await _categoryManager.GetAll();
            return View(categories);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await _productManager.Add(product);
            return RedirectToAction("ProductView");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productManager.Delete(id);
            return RedirectToAction("ProductView");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var product = _productManager.Get(id);
            await _productManager.Update(product);
            return RedirectToAction("ProductView");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllProduct(Product product)
        {
            await _productManager.GetAll();
            return RedirectToAction("ProductView");
        }
        [HttpPost]
        public async Task<IActionResult> FilterProduct(Product product)
        {
            await _productManager.Filter(product.Name);
            return RedirectToAction("ProductView");
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            await _userManager.Add(user);
            return RedirectToAction("UserView");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userManager.Delete(id);
            return RedirectToAction("UserView");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(int id)
        {
            var user = _userManager.GetById(id);
            await _userManager.Update(user);
            return RedirectToAction("UserView");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllUser()
        {
            await _userManager.GetAll();
            return RedirectToAction("UserView");
        }
        [HttpPost]
        public async Task<IActionResult> FilterUser(User user)
        {
            await _userManager.Filter(user.Login);
            return RedirectToAction("UserView");
        }
        [HttpPost]
        public async Task<IActionResult> AddSize(Size size)
        {
            await _sizeManager.Add(size);
            return RedirectToAction("SizeView");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteSize(Size size)
        {
            await _sizeManager.Delete(size.Id);
            return RedirectToAction("SizeView");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSize(Size size)
        {
            await _sizeManager.Update(size);
            return RedirectToAction("SizeView");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllSize()
        {
            await _sizeManager.GetAll();
            return RedirectToAction("SizeView");
        }
        [HttpPost]
        public async Task<IActionResult> FilterSize(Size size)
        {
            await _sizeManager.Filter(size);
            return RedirectToAction("SizeView");
        }
        [HttpPost]
        public async Task<IActionResult> AddSnack(Snack snack)
        {
            await _snackManager.Add(snack);
            return RedirectToAction("SnackView");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteSnack(Snack snack)
        {
            await _snackManager.Delete(snack.Id);
            return RedirectToAction("SnackView");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSnack(Snack snack)
        {
            await _snackManager.Update(snack);
            return RedirectToAction("SnackView");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllSnack()
        {
            await _snackManager.GetAll();
            return RedirectToAction("SnackView");
        }
        [HttpPost]
        public async Task<IActionResult> FilterSnack(Snack snack)
        {
            await _snackManager.Filter(snack.Name);
            return RedirectToAction("SnackView");
        }
        [HttpPost]
        public async Task<IActionResult> AddCountry(Country country)
        {
            await _countryManager.Add(country);
            return RedirectToAction("CountryView");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCountry(Country country)
        {
            await _countryManager.Delete(country.Id);
            return RedirectToAction("CountryView");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCountry(Country country)
        {
            await _countryManager.Update(country);
            return RedirectToAction("CountryView");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllCountry()
        {
            await _snackManager.GetAll();
            return RedirectToAction("CountryView");
        }
        [HttpPost]
        public async Task<IActionResult> FilterCountry(Country country)
        {
            await _countryManager.Filter(country.Name);
            return RedirectToAction("CountryView");
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {
            await _categoryManager.Add(category);
            return RedirectToAction("CategoryView");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryManager.Delete(id);
            return RedirectToAction("CategoryView");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Category category)
        {
            await _categoryManager.Update(category);
            return RedirectToAction("CategoryView");
        }
        [HttpPost]
        public async Task<IActionResult> GetAllCategories()
        {
            await _categoryManager.GetAll();
            return RedirectToAction("CategoryView");
        }
        [HttpPost]
        public async Task<IActionResult> FilterCategory(Category category)
        {
            await _categoryManager.Filter(category.Name);
            return RedirectToAction("CategoryView");
        }
    }
}