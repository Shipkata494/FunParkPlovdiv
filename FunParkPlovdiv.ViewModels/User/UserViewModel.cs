
namespace FunParkPlovdiv.ViewModels.User
{
    using System.ComponentModel.DataAnnotations;
    using static FunParkPlovdiv.Common.EntityValidationConstants.User;
    public class UserViewModel
    {
        [StringLength(UserNameMaxLenght, MinimumLength = UserNameMinLenght)]
        public string Name { get; set; } = null!;
        [StringLength(UserMiddleNameMaxLenght, MinimumLength = UserMiddleNameMinLenght)]
        public string MiddleName { get; set; } = null!;
        [StringLength(UserLastNameMaxLenght, MinimumLength = UserLastNameMinLenght)]
        public string LastName { get; set; } = null!;
        [EmailAddress]
        public string? Email { get; set; }
        [StringLength(UserPhoneMaxLenght, MinimumLength = UserPhoneMinLenght)]
        public string Phone { get; set; } = null!;
    }
}
