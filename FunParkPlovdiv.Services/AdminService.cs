using FunParkPlovdiv.Common;
using FunParkPlovdiv.Data;
using FunParkPlovdiv.Services.Interfaces;
using FunParkPlovdiv.Services.ServiceModels;
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

        public async Task<bool> AuthenticateUser(AdminServiceModel model)
        {
            var administrator = await dbContext.Administrator.Where(a=>a.Username == model.Username).FirstAsync();
           return PasswordHash.ValidatePassword(model.Password, administrator.PasswordHash);
        }
    }
}
