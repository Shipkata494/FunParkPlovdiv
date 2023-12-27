
namespace FunParkPlovdiv.Data.Data
{
    using FunParkPlovdiv.Data.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;
    using static FunParkPlovdiv.Common.EntityValidationConstants.User;

    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
            RidesCount = 0;
        }
        public Guid Id { get; set; }
        [MaxLength(UserNameMaxLenght)]
        public string Name { get; set; } = null!;
        [MaxLength(UserMiddleNameMaxLenght)]
        public string MiddleName { get; set; } = null!;
        [MaxLength(UserLastNameMaxLenght)]
        public string LastName { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        public Course Course { get; set; }
        public int RidesCount { get; set; }

    }
}
