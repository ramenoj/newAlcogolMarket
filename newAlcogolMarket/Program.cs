using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using newAlcogolMarket.Manager.Categories;
using newAlcogolMarket.Manager.Countries;
using newAlcogolMarket.Manager.Products;
using newAlcogolMarket.Manager.Recommendations;
using newAlcogolMarket.Manager.Sizes;
using newAlcogolMarket.Manager.Snacks;
using newAlcogolMarket.Manager.Users;
using newAlcogolMarket.Models;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
builder.Services.AddTransient<IUserManager, UserManager>();
builder.Services.AddTransient<IProductManager, ProductManager>();
builder.Services.AddTransient<IRecommendationManager, RecommendationManager>();
builder.Services.AddTransient<ISizeManager, SizeManager>();
builder.Services.AddTransient<ICategoryManager, CategoryManager>();
builder.Services.AddTransient<ISnackManager, SnackManager>();
builder.Services.AddTransient<ICountryManager, CountryManager>();

builder.Services.AddControllersWithViews();
builder.Services.AddSession(options =>
{
    //options.Cookie.Name = ".AdventureWorks.Session";
    options.Cookie.HttpOnly = true;
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.IsEssential = true;
});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/User/Register";
        options.AccessDeniedPath = "/User/Register";
    });
// Add services to the container.
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCookiePolicy();
app.UseRouting();

app.UseAuthentication();   // добавление middleware аутентификации 
app.UseAuthorization();   // добавление middleware авторизации 
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=SignIn}/{id?}");

app.Run();