namespace FunParkPlovdiv.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FunParkPlovdiv.Services.Interfaces;
    public class ImageController : Controller
    {
       private readonly IImageService imageService;
        public ImageController(IImageService _imageService)
        {
            imageService = _imageService;
        }
        public IActionResult Index() 
        {
            var images = imageService.GetImages();
            return View(images);
        }
    }
}
