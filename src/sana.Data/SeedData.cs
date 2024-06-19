using sana.Domain.Models;

namespace sana.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            /*******************************************************/
            /* USER INFORMATION */
            var hasher = new PasswordHasher<IdentityUser>();

            var user1 = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "customer1@example.com",
                NormalizedUserName = "CUSTOMER1@EXAMPLE.COM",
                Email = "customer1@example.com",
                NormalizedEmail = "CUSTOMER1@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Customer@123"),
                SecurityStamp = string.Empty
            };

            var user2 = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "customer2@example.com",
                NormalizedUserName = "CUSTOMER2@EXAMPLE.COM",
                Email = "customer2@example.com",
                NormalizedEmail = "CUSTOMER2@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Customer@123"),
                SecurityStamp = string.Empty
            };

            modelBuilder.Entity<IdentityUser>().HasData(user1, user2);
            /*******************************************************/
            // Categories
            var category1 = new Category { Id = Guid.NewGuid(), CategoryName = "Electronics" };
            var category2 = new Category { Id = Guid.NewGuid(), CategoryName = "Clothing" };
            var category3 = new Category { Id = Guid.NewGuid(), CategoryName = "Books" };

            modelBuilder.Entity<Category>().HasData(category1, category2, category3);

            // Products
            var product1 = new Product
            {
                Id = Guid.NewGuid(),
                ProductName = "Smartphone",
                Description = "Latest smartphone model",
                Price = 999.99m,
                Stock = 100
            };

            var product2 = new Product
            {
                Id = Guid.NewGuid(),
                ProductName = "T-shirt",
                Description = "Cotton t-shirt",
                Price = 19.99m,
                Stock = 200
            };

            var product3 = new Product
            {
                Id = Guid.NewGuid(),
                ProductName = "Programming Book",
                Description = "Learn C# programming",
                Price = 49.99m,
                Stock = 50
            };

            modelBuilder.Entity<Product>().HasData(product1, product2, product3);

            // ProductCategories
            var productCategory1 = new ProductCategory { ProductID = product1.Id, CategoryID = category1.Id };
            var productCategory2 = new ProductCategory { ProductID = product2.Id, CategoryID = category2.Id };
            var productCategory3 = new ProductCategory { ProductID = product3.Id, CategoryID = category3.Id };

            modelBuilder.Entity<ProductCategory>().HasData(productCategory1, productCategory2, productCategory3);

            // ShoppingCarts
            var cart1 = new ShoppingCart { UserId = user1.Id };
            var cart2 = new ShoppingCart { UserId = user2.Id };

            modelBuilder.Entity<ShoppingCart>().HasData(cart1, cart2);

            // CartItems
            var cartItem1 = new CartItem { CartID = cart1.Id, ProductID = product1.Id, Quantity = 2 };
            var cartItem2 = new CartItem { CartID = cart2.Id, ProductID = product2.Id, Quantity = 1 };

            modelBuilder.Entity<CartItem>().HasData(cartItem1, cartItem2);

            // Orders
            var order1 = new Order { Id = Guid.NewGuid(), UserId = user1.Id, TotalAmount = 219.97m };
            var order2 = new Order { Id = Guid.NewGuid(), UserId = user2.Id, TotalAmount = 19.99m };

            modelBuilder.Entity<Order>().HasData(order1, order2);

            // OrderItems
            var orderItem1 = new OrderItem { OrderID = order1.Id, ProductID = product1.Id, Quantity = 2, UnitPrice = product1.Price };
            var orderItem2 = new OrderItem { OrderID = order2.Id, ProductID = product2.Id, Quantity = 1, UnitPrice = product2.Price };

            modelBuilder.Entity<OrderItem>().HasData(orderItem1, orderItem2);
        }
    }
}
