using Microsoft.EntityFrameworkCore;
using newAlcogolMarket.Models.Entity;

namespace newAlcogolMarket.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Absent> Absents { get; set; } = null!;
        public DbSet<Beer> Beers { get; set; } = null!;
        public DbSet<Champagne> Champagnes { get; set; } = null!;
        public DbSet<Cognac> Cognacs { get; set; } = null!;
        public DbSet<Liquor> Liquors { get; set; } = null!;
        public DbSet<Snack> Snacks  { get; set; } = null!;
        public DbSet<Wine> Wines { get; set; } = null!;
        public DbSet<Vodka> Vodkas { get; set; } = null!;
        public DbSet<Whiskey> Whiskey { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {}
    }
}
