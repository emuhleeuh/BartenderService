using System.ComponentModel.DataAnnotations;

namespace BartenderService.Models
{
    public class OrderCocktail
    {
        [Key]
        public int ID { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int CocktailId { get; set; }
        public Cocktail Cocktail { get; set; }
        public int Quantity { get; set; }
    }
}
