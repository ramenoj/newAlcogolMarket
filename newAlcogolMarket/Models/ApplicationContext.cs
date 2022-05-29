﻿using newAlcogolMarket.Models.Entity;

namespace newAlcogolMarket.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Country> Сountries { get; set; }   
        public DbSet<Strength> Strengths { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<BasketItem> BasketItem { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {}
    }
}
