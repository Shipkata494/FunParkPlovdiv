using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunParkPlovdiv.Common
{
    public class EntityValidationConstants
    {
        public static class Price
        {
            public const int PriceTitleMaxLenght = 50;
            public const int PriceTitleMinLenght = 1;
            public const int PriceValueMin = 0;
        }
        public static class User
        {
            public const int UserNameMaxLenght = 50;
            public const int UserNameMinLenght = 1;
            public const int UserMiddleNameMaxLenght = 50;
            public const int UserMiddleNameMinLenght = 1;
            public const int UserLastNameMaxLenght = 50;
            public const int UserLastNameMinLenght = 1;
            public const int UserPhoneMaxLenght = 15;
            public const int UserPhoneMinLenght = 10;
        }
    }
}
