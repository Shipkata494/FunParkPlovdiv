using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using FunParkPlovdiv.Services.Interfaces;

namespace FunParkPlovdiv.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;
        public AdminController(IAdminService _adminService)
        {
            adminService = _adminService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
            if (ModelState.IsValid)
            {
                var user = new
                {
                    username,
                    password
                };

                var IsUserAuthenticate = await adminService.AuthenticateUser(user.username, user.password);

                if (!IsUserAuthenticate)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, username),
                        new Claim("Password", password),
                        new Claim(ClaimTypes.Role, "Administrator"),
                    };

                var claimsIdentity = new ClaimsIdentity
                    (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(5),
                    IsPersistent = true,                 
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return RedirectToAction("Index","Home");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
