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
        public IActionResult Upload()
        {
            var file = Request.Form.Files[0];
            if (file != null && file.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Content","Images");
                var uniqueFileName = file.FileName;
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                return Json(new { success = true, message = "Image uploaded successfully" });
            }

            return Json(new { success = false, message = "No file received" });
        }
    }
}
