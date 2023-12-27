namespace FunParkPlovdiv.Controllers
{
    using FunParkPlovdiv.Services.Interfaces;
    using FunParkPlovdiv.ViewModels.Price;
    using Microsoft.AspNetCore.Mvc;
    public class PriceController : Controller
    {
        private readonly IPriceService priceService;

        public PriceController(IPriceService _priceService)
        {
            this.priceService = _priceService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> EditSmallCourse(PriceViewModel viewModel) 
        {
            await priceService.EditSmallCourseAsync(viewModel);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> EditBigCourse(PriceViewModel viewModel)
        {
            await priceService.EditBigCourseAsync(viewModel);
            return RedirectToAction("Index");
        }
    }
}
