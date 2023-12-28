using FunParkPlovdiv.Common;
using FunParkPlovdiv.Data;
using FunParkPlovdiv.Data.Models;
using FunParkPlovdiv.Services.Interfaces;
using FunParkPlovdiv.Services.ServiceModels;
using FunParkPlovdiv.ViewModels.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunParkPlovdiv.Services
{
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
            };
           await dbContext.Users.AddAsync(user);
           await dbContext.SaveChangesAsync();
        }

        public async Task<bool> AuthenticateUser(AdminServiceModel model)
        {
            var administrator = await dbContext.Administrator.Where(a=>a.Username == model.Username).FirstAsync();
           return PasswordHash.ValidatePassword(model.Password, administrator.PasswordHash);
        }

        public async Task UserDriveAsync(string email, DriveViewModel model)
        {

                var user = await dbContext.Users.Where(u => u.Email == email).FirstAsync();
            Drive drive = new Drive()
            {
                Date = model.Date,
                Courses = model.Course
            };
            user.Drives.Add(drive);
            await dbContext.SaveChangesAsync();          
        }

        public async Task<bool> UserExist(string email)
        {
            var user = await dbContext.Users.Where(u => u.Email == email).FirstOrDefaultAsync();
            if (user == null)
            {
                return false;
            }
            return true;
        }
    }
}
