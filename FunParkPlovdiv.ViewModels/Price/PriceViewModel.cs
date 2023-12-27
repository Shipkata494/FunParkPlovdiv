using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FunParkPlovdiv.ViewModels.Price
{
    public class PriceViewModel
    {
        public string Title { get; set; }
        [RegularExpression("/^[0-9]{1,5}(\\.[0-9]{0,2})?$/gm")]
        public decimal Value { get; set; }
    }
}
