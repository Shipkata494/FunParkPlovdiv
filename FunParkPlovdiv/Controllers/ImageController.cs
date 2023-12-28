namespace FunParkPlovdiv.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FunParkPlovdiv.Services.Interfaces;
    public class ImageController : Controller
    {
       private readonly IImageService imageService;
       private readonly IWebHostEnvironment environment;
        public ImageController(IImageService _imageService,IWebHostEnvironment _environment)
        {
            imageService = _imageService;
            environment = _environment;
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
        public IActionResult Delete(string imageName)
        {
            try
            {
                var uploadsFolder = Path.Combine(environment.WebRootPath, "Content", "Images");
                var imagePath = Path.Combine(uploadsFolder, imageName);               
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                    return Json(new { success = true, message = "Image deleted successfully" });
                }
                else
                {
                    return Json(new { success = false, message = "Image not found" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Error deleting image: {ex.Message}" });
            }
        }
    }
}
