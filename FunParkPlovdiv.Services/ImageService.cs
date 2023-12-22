using FunParkPlovdiv.Services.Interfaces;
using FunParkPlovdiv.Services.ServiceModels;
namespace FunParkPlovdiv.Services
{
    public class ImageService : IImageService
    {

        List<ImageModel> IImageService.GetImages()
        {
            var imagePath = "wwwroot/Content/Images";
      
            var imageFiles = Directory.GetFiles(imagePath, "*.*", SearchOption.TopDirectoryOnly)
                                       .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png"))
                                       .ToList();

            var images = imageFiles.Select(file => new ImageModel
            {
                FilePath = file.Replace("wwwroot/",""),
                AltText = Path.GetFileNameWithoutExtension(file)
            }).ToList();

            return images;
        }
    }
}
