using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            //Seeding some data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoriesId = 1, Name = "Beverage", Description = "Beverage" },
                new Category { CategoriesId = 2, Name = "Bakery", Description = "Bakery" },
                new Category { CategoriesId = 3, Name = "Drink", Description = "Drink" },
                new Category { CategoriesId = 4, Name = "Indian Food", Description = "Snack" }
                );
            modelBuilder.Entity<Product>().HasData(
                                new Product { ProductId = 1, CategoryId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99 },
                new Product { ProductId = 2, CategoryId = 2, Name = "Coffee", Quantity = 400, Price = 1.00 },
                new Product { ProductId = 3, CategoryId = 3, Name = "Indian Tea", Quantity = 500, Price = 5.00 },
                new Product { ProductId = 4, CategoryId = 4, Name = "Samosa", Quantity = 100, Price = 1.99 }
                );
        }
    }
}