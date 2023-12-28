namespace FunParkPlovdiv.Services
{
    using FunParkPlovdiv.Data;
    using FunParkPlovdiv.Data.Models;
    using FunParkPlovdiv.Services.Interfaces;
    using FunParkPlovdiv.ViewModels.Price;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class PriceService : IPriceService
    {
        private readonly FunParkPlovdivDbContext dbContext;

        public PriceService(FunParkPlovdivDbContext _dbContext)
        {
           dbContext = _dbContext;
        }

        public async Task EditBigCourseAsync(PriceViewModel priceViewModel)
        {
            var prices = await dbContext.Prices.Where(p => p.Description == "BigCourse").FirstAsync();
            prices.Value = priceViewModel.Value;
            prices.Title = priceViewModel.Title;
            await dbContext.SaveChangesAsync();
        }


        public async Task EditSmallCourseAsync(PriceViewModel priceViewModel)
        {
            var prices = await dbContext.Prices.Where(p => p.Description == "MiniCourse").FirstAsync();
            prices.Value = priceViewModel.Value;
            prices.Title = priceViewModel.Title;
            await dbContext.SaveChangesAsync();
        }

        public async Task<PriceViewModel> GetDataOfBigCourseAsync()
        {
            var prices = await dbContext.Prices.Where(p=>p.Description== "BigCourse").FirstAsync();
            PriceViewModel price = new PriceViewModel()
            {
                Title = prices.Title,
                Value = prices.Value,
            };
            return price;
        }

        public async Task<PriceViewModel> GetDataOfSmallCourseAsync()
        {
            var prices = await dbContext.Prices.Where(p => p.Description == "MiniCourse").FirstAsync();
            PriceViewModel price = new PriceViewModel()
            {
                Title = prices.Title,
                Value = prices.Value,
            };
            return price;
        }
    }
}
