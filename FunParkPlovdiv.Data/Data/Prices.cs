namespace FunParkPlovdiv.Data.Data
{
    using System.ComponentModel.DataAnnotations;
    using static FunParkPlovdiv.Common.EntityValidationConstants.Price;
    public class Prices
    {
        public Prices()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(PriceTitleMaxLenght)]
        public string Title { get; set; } = null!;
        [Required]
        public decimal Value { get; set; }
    }
}
