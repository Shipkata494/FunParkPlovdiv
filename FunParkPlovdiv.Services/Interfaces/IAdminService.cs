namespace FunParkPlovdiv.Services.Interfaces
{
    using FunParkPlovdiv.Services.ServiceModels;
    using FunParkPlovdiv.ViewModels.User;
    public interface IAdminService
    {
        Task<bool> AuthenticateUser(AdminServiceModel model);
        Task AddUserAsync(UserViewModel model);
        Task UserDriveAsync(DriveViewModel model);
        Task<bool> UserExist(string email);
        Task<UserInfoViewModel> GetUserByEmailAsync(string email);
    }
}
