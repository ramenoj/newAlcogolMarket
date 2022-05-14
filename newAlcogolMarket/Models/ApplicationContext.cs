using Microsoft.EntityFrameworkCore;
using newAlcogolMarket.Models.Category;

namespace newAlcogolMarket.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Absent> Absents { get; set; } = null!;
        public DbSet<Beer> Beers { get; set; } = null!;
        public DbSet<Champagne> Champagnes { get; set; } = null!;
        public DbSet<Cognac> Cognacs { get; set; } = null!;
        public DbSet<Liquor> Liquors { get; set; } = null!;
        public DbSet<Snack> Snacks  { get; set; } = null!;
        public DbSet<Wine> Wines { get; set; } = null!;
        public DbSet<Vodka> Vodkas { get; set; } = null!;
        public DbSet<Whiski> Whiskis { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            
        }
    }
}
