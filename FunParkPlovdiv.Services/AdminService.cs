using FunParkPlovdiv.Common;
using FunParkPlovdiv.Data;
using FunParkPlovdiv.Data.Models;
namespace FunParkPlovdiv.Services
{
    using FunParkPlovdiv.Services.Interfaces;
    using FunParkPlovdiv.Services.ServiceModels;
    using FunParkPlovdiv.ViewModels.User;
    using Microsoft.EntityFrameworkCore;
    public class AdminService : IAdminService
    {
        private readonly FunParkPlovdivDbContext dbContext;

        public AdminService(FunParkPlovdivDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task AddUserAsync(UserViewModel model)
        {
            User user = new User()
            {
                Name = model.Name,
                Email = model.Email,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                PhoneNumber = model.Phone
            };
           await dbContext.Users.AddAsync(user);
           await dbContext.SaveChangesAsync();
        }

        public async Task<bool> AuthenticateUser(AdminServiceModel model)
        {
            var administrator = await dbContext.Administrator.Where(a=>a.Username == model.Username).FirstAsync();
           return PasswordHash.ValidatePassword(model.Password, administrator.PasswordHash);
        }

        public async Task<UserInfoViewModel> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            var result = new UserInfoViewModel();
          var user = await dbContext.Users.Include(u=>u.Drives).Where(u => u.PhoneNumber == phoneNumber).FirstOrDefaultAsync();
            foreach (var item in user!.Drives)
            {
                var drive = new DriveViewModel()
                {
                    Date = item.Date,
                    Phone = user.PhoneNumber,
                    Course = item.Courses
                };
                result.Drives.Add(drive);
            }
            result.Name = user.Name;
            result.Phone = phoneNumber;
            result.MiddleName = user.MiddleName;
            result.LastName = user.LastName;
            return  result;
            
        }

        public async Task UserDriveAsync(DriveViewModel model)
        {

                var user = await dbContext.Users.Where(u => u.PhoneNumber == model.Phone).FirstAsync();
            Drive drive = new Drive()
            {
                Date = model.Date,
                Courses = model.Course
            };
            user.Drives.Add(drive);
            await dbContext.SaveChangesAsync();          
        }

        public async Task<bool> UserExist(string phoneNumber)
        {
            var user = await dbContext.Users.Where(u => u.PhoneNumber == phoneNumber).FirstOrDefaultAsync();
            if (user == null)
            {
                return false;
            }
            return true;
        }
    }
}
