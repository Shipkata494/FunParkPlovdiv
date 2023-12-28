
namespace FunParkPlovdiv.Data.Models
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
            Drives = new HashSet<Drive>();
        }
        public Guid Id { get; set; }
        [MaxLength(UserNameMaxLenght)]
        public string Name { get; set; } = null!;
        [MaxLength(UserMiddleNameMaxLenght)]
        public string MiddleName { get; set; } = null!;
        [MaxLength(UserLastNameMaxLenght)]
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public ICollection<Drive> Drives { get; set; }


    }
}
