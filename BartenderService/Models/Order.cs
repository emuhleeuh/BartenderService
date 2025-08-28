using System.ComponentModel.DataAnnotations;

namespace BartenderService.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string OrderStatus { get; set; }

        public ICollection<OrderCocktail> OrderCocktails { get; set; } = new List<OrderCocktail>();
    }
}
