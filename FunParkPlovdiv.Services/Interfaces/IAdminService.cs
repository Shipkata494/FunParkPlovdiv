namespace FunParkPlovdiv.Services.Interfaces
{
    using FunParkPlovdiv.Services.ServiceModels;
    using FunParkPlovdiv.ViewModels.User;
    public interface IAdminService
    {
        Task<bool> AuthenticateUser(AdminServiceModel model);
        Task AddUserAsync(UserViewModel model);
        Task UserDriveAsync(DriveViewModel model);
        Task<bool> UserExist(string phoneNumber);
        Task<UserInfoViewModel> GetUserByPhoneNumberAsync(string phoneNumber);
        Task<ICollection<UserStatisticsViewModel>> GetUserStatisticsAsync(DateTime date);
    }
}
