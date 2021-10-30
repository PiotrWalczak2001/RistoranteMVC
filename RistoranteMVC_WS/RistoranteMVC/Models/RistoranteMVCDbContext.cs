using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RistoranteMVC.Auth;
using System;

namespace RistoranteMVC.Models
{
    public class RistoranteMVCDbContext : IdentityDbContext<ApplicationUser>
    {
        public RistoranteMVCDbContext(DbContextOptions<RistoranteMVCDbContext> options) : base(options)
        {
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var adminRoleId = "DAFF313F-89DD-4621-BC3F-B6EE1F2A23C6";

            ApplicationUser user = new ApplicationUser()
            {
                FirstName = "Janeczek",
                LastName = "Adminowy",
                Id = "D174C90E-6C1D-452C-B91F-CA39C112B73E",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                EmailConfirmed = true,
                UserName = "Janeczek",
                NormalizedUserName = "JANECZEK",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var password = new PasswordHasher<ApplicationUser>();
            var hashed = password.HashPassword(user, "Adminowy$12");
            user.PasswordHash = hashed;

            modelBuilder.Entity<ApplicationUser>().HasData(user);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { UserId = user.Id, RoleId = adminRoleId });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole 
            { 
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMINISTRATOR"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Name = "Pizzas"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Name = "Pastas"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Name = "Soups"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Name = "Desserts"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Name = "Drinks"
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Pizza margherita",
                Description = "Delicious classic from the pizza family",
                CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Kcal = 600,
                Price = 25.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Pizza salami",
                Description = "The best for meetings with friends",
                CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Kcal = 750,
                Price = 31.50M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Pizza americana",
                Description = "American pizza in the Italian version",
                CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Kcal = 800,
                Price = 32.20M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Four cheeses pizza",
                Description = "the best cheeses on your favorite pizza",
                CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Kcal = 900,
                Price = 33.90M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Spaghetti bolognese",
                Description = "The best pasta with classic bolognese sauce",
                CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Kcal = 450,
                Price = 18.20M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Spaghetti carbonara",
                Description = "Our kitchen's bestseller",
                CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Kcal = 550,
                Price = 19.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Lasagne",
                Description = "For more hunger",
                CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Kcal = 840,
                Price = 36.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Tagliatelle with spinach",
                Description = "This taste will surprise you",
                CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Kcal = 410,
                Price = 19.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Creamy tomato soup",
                Description = "Its taste comes from the best ingredients",
                CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Kcal = 180,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Curry soup",
                Description = "Our novelty",
                CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Kcal = 210,
                Price = 13.30M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Soup with meatballs",
                Description = "Tasty and nutritious",
                CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Kcal = 210,
                Price = 15.95M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Mushroom soup",
                Description = "Very aromatic dish that will delight everyone",
                CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Kcal = 210,
                Price = 14.49M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Tiramisu",
                Description = "The best dessert that will impress your other half",
                CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Kcal = 300,
                Price = 10.50M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Panna Cotta",
                Description = "Melts in your mouth",
                CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Kcal = 290,
                Price = 10.40M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Ice-creams",
                Description = "Sweet and cold what more could you want",
                CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Kcal = 260,
                Price = 9.10M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Granita",
                Description = "It is worth a try",
                CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Kcal = 270,
                Price = 10.05M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Coffee",
                Description = "Just good coffee",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Kcal = 10,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Tea",
                Description = "Just good tea",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Kcal = 10,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Water",
                Description = "Just water",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Kcal = 10,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = Guid.NewGuid(),
                Name = "Coca-Cola",
                Description = "Just Coca-Cola",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Kcal = 110,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            });
        }
    }
}
