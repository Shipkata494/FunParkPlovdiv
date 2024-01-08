namespace FunParkPlovdiv.Data.Models
{
using System.ComponentModel.DataAnnotations;
    public class Administrator
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string PasswordHash { get; set; } = null!;
    
    }
}
