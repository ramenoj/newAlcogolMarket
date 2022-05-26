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
        public IUserManager usermanager;
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
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(User fakeUser)
        {
            var user = usermanager.Get(fakeUser);
            if(user==null)
            {
                await usermanager.Add(fakeUser);
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Login),
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
            return RedirectToAction("Login");
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
            await usermanager.Update(user);
            return RedirectToAction("Index");
        }
    }
}