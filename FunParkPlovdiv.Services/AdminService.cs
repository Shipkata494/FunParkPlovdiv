using FunParkPlovdiv.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunParkPlovdiv.Services
{
    public class AdminService : IAdminService
    {
        public async Task<bool> AuthenticateUser(string username, string password)
        {
            if (username == "1" && password == "2")
            {
                return true;
            }
            return false;
        }
    }
}
