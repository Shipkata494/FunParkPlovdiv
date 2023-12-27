namespace FunParkPlovdiv.Controllers
{
    using System.Security.Claims;

    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Mvc;

    using FunParkPlovdiv.Services.Interfaces;
    using FunParkPlovdiv.Services.ServiceModels;

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
        public async Task<IActionResult> Index(AdminServiceModel model)
        {
            if (ModelState.IsValid)
            {
               

                var IsUserAuthenticate = await adminService.AuthenticateUser(model);

                if (!IsUserAuthenticate)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, model.Username),
                        new Claim("Password", model.Password),
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
