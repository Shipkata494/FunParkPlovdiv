using FunParkPlovdiv.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunParkPlovdiv.Data.Models
{
    public class Drive
    {
        public Drive()
        {
            Date = DateTime.Today;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Course Courses { get; set; }

    }
}
