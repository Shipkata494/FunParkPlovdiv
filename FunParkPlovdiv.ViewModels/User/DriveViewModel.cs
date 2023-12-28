using FunParkPlovdiv.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunParkPlovdiv.ViewModels.User
{
    public class DriveViewModel
    {
        [EmailAddress]
        public string Email { get; set; } = null!;
        public Course Course { get; set; }
        public DateTime Date { get; set; }
    }
}
