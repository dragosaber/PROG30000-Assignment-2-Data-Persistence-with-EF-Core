using Microsoft.EntityFrameworkCore;
using GMS_Jospeh_Thomas.Models;

namespace GMS_Jospeh_Thomas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasData(
                new Item { ItemId = 1, Name = "Milk", Category = ItemCategory.Dairy, PurchaseDate = new DateTime(2026, 10, 1), Quantity = 40, Price = 4.99m },
                new Item { ItemId = 2, Name = "Cheese", Category = ItemCategory.Dairy, PurchaseDate = new DateTime(2026, 10, 3), Quantity = 25, Price = 8.49m },
                new Item { ItemId = 3, Name = "Chicken", Category = ItemCategory.Meat, PurchaseDate = new DateTime(2026, 10, 5), Quantity = 30, Price = 12.99m },
                new Item { ItemId = 4, Name = "Ground Beef", Category = ItemCategory.Meat, PurchaseDate = new DateTime(2026, 10, 7), Quantity = 20, Price = 10.75m },
                new Item { ItemId = 5, Name = "Potato Crisps", Category = ItemCategory.Snacks, PurchaseDate = new DateTime(2026, 10, 9), Quantity = 100, Price = 3.49m },
                new Item { ItemId = 6, Name = "Chocolate Bar", Category = ItemCategory.Snacks, PurchaseDate = new DateTime(2026, 10, 12), Quantity = 150, Price = 1.99m },
                new Item { ItemId = 7, Name = "Sourdough Bread", Category = ItemCategory.Bakery, PurchaseDate = new DateTime(2026, 10, 14), Quantity = 35, Price = 5.25m },
                new Item { ItemId = 8, Name = "Raspberry Muffin", Category = ItemCategory.Bakery, PurchaseDate = new DateTime(2026, 10, 16), Quantity = 60, Price = 2.50m },
                new Item { ItemId = 9, Name = "Gala Apples", Category = ItemCategory.Produce, PurchaseDate = new DateTime(2026, 10, 18), Quantity = 200, Price = 0.99m },
                new Item { ItemId = 10, Name = "Spinach", Category = ItemCategory.Produce, PurchaseDate = new DateTime(2026, 10, 20), Quantity = 45, Price = 3.99m }
            );
        }

    }
}
