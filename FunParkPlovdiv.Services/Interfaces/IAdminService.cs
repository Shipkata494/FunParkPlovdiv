using FunParkPlovdiv.Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunParkPlovdiv.Services.Interfaces
{
    public interface IAdminService
    {
        Task<bool> AuthenticateUser(AdminServiceModel model);
    }
}
