namespace FunParkPlovdiv.ViewModels.User
{
    using FunParkPlovdiv.Data.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;
    using static FunParkPlovdiv.Common.EntityValidationConstants.User;
    public class DriveViewModel
    {
        [EmailAddress]
        [StringLength(UserPhoneMaxLenght, MinimumLength = UserPhoneMinLenght)]
        public string Phone { get; set; } = null!;
        public Course Course { get; set; }
        public DateTime Date { get; set; }
    }
}
