using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Country> Countries { get; set; }  
        public DbSet<Size> Sizes { get; set; }
        public DbSet<BasketItem> BasketItem { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Snack> Snacks  { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {}
    }
}
