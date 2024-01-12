namespace FunParkPlovdiv.Controllers
{
    using System.Security.Claims;

    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Mvc;

    using FunParkPlovdiv.Services.Interfaces;
    using FunParkPlovdiv.Services.ServiceModels;
    using FunParkPlovdiv.ViewModels.User;
    using Microsoft.AspNetCore.Authorization;
   [Authorize]
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;
        public AdminController(IAdminService _adminService)
        {
            adminService = _adminService;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
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
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(UserViewModel model)
        {
          
                if (await adminService.UserExist(model.Phone))
                {
                    return RedirectToAction("UserDrive", "Admin");
                }
                else
                {
                    await adminService.AddUserAsync(model);
                    return RedirectToAction("Index", "Home");
                }
                      
        }

        public IActionResult UserDrive() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserDrive(DriveViewModel model)
        {         
                if (await adminService.UserExist(model.Phone))
                {
                    await adminService.UserDriveAsync(model);
                    return RedirectToAction("Info", model);
                }
                else
                {
                    return RedirectToAction("AddUser", "Admin");
                }
            
                      
        }
        public async Task<IActionResult> Info(DriveViewModel viewModel)
        {
           UserInfoViewModel model = await adminService.GetUserByPhoneNumberAsync(viewModel.Phone);
            return View("UserInfo", model);
        }
        public IActionResult UserInfo(UserInfoViewModel model)
        {           
            return View(model);
        }
    }
}
