using BartenderService.Models;
using BartenderService.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BartenderService.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Make sure database exists
            context.Database.EnsureCreated();

            // Look for any cocktails already in the table
            if (context.Cocktails.Any())
            {
                return;   // DB has been seeded
            }

            var cocktails = new Cocktail[]
            {
                 new Cocktail { DrinkName = "Margarita", Price = 12.00M, Description = "Tequila, Triple Sec, Lime Juice, Salt Rim" },
                 new Cocktail { DrinkName = "Old Fashioned", Price = 14.00M, Description = "Bourbon, Sugar, Bitters, Orange Peel" },
                 new Cocktail { DrinkName = "Mojito", Price = 11.00M, Description = "White Rum, Mint, Sugar, Lime Juice, Soda" },
                 new Cocktail { DrinkName = "Cosmopolitan", Price = 13.00M, Description = "Vodka, Triple Sec, Cranberry Juice, Lime Juice" },
                 new Cocktail { DrinkName = "Whiskey Sour", Price = 12.50M, Description = "Whiskey, Lemon Juice, Sugar, Egg White (optional)" }
            };

            context.Cocktails.AddRange(cocktails);
            context.SaveChanges();
        }
    }
}
