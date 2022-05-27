using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager.Users;
using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Entities;
using System.Security.Claims;

namespace newAlcogolMarket.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserManager usermanager;
        public UserController(IUserManager usermanager)
        {
            this.usermanager = usermanager;
        }
        [Authorize(Roles ="admin")]
        public async Task<IActionResult> Index()
        {
            var userGetall = usermanager.GetAll();
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
            var fakeuser = usermanager.Get(user);
            if (fakeuser!=null)
            {
                return RedirectToAction("Register");
            }
            await usermanager.Add(user);
            return RedirectToAction("SignIn");
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(User fakeuser)
        {
            var user = usermanager.Get(fakeuser);
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
            await usermanager.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(User user)
        {
            var fakeuser = usermanager.Get(user);
            if (fakeuser == null)
            {
                await usermanager.Update(user);
            }
            else
            {
                return RedirectToAction("Update");
            }
            return RedirectToAction("Index");
        }
    }
}