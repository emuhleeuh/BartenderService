using System.ComponentModel.DataAnnotations;

namespace BartenderService.Models
{
    public class Cocktail
    {
        [Key]
        public int ID { get; set; }
        public string DrinkName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<OrderCocktail> OrderCocktails { get; set; }
    }
}
