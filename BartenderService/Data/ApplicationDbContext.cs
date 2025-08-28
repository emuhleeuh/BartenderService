using Microsoft.EntityFrameworkCore;
using BartenderService.Models;
namespace BartenderService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<OrderCocktail> OrderCocktails { get; set; }
    }

    }

