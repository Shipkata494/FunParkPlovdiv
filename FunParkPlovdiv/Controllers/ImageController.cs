using FunParkPlovdiv.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FunParkPlovdiv.Controllers
{
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
