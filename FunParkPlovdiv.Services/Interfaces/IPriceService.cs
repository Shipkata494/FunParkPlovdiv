using FunParkPlovdiv.ViewModels.Price;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunParkPlovdiv.Services.Interfaces
{
    public interface IPriceService
    {
        Task<PriceViewModel> GetDataOfSmallCourseAsync();
        Task<PriceViewModel> GetDataOfBigCourseAsync();
        Task EditSmallCourseAsync(PriceViewModel priceViewModel);
        Task EditBigCourseAsync(PriceViewModel priceViewModel);
    }
}
