using Moq;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.UnitTests.Mocks
{
    public static class RepositoryMocks
    {

        public static Mock<ICategoryRepository> GetCategoryRepository()
        {
            var categoryGuid1 = Guid.Parse("BFBF2A17-6262-42F2-8533-40CBF627F5BD");
            var categoryGuid2 = Guid.Parse("E307E8C7-69BF-47EC-B124-174F29BECBD4");
            var categoryGuid3 = Guid.Parse("4510466D-0F39-4D17-A9AB-533AB8BE1260");
            var categoryGuid4 = Guid.Parse("72F31CDD-7521-4E4B-8C10-8E930701FDFD");
            var categoryGuid5 = Guid.Parse("9DE155E9-B6D2-49AF-9C5E-689A9BCDF9CB");

            var categories = new List<Category>
            {
                new Category
                {
                    CategoryId = categoryGuid1,
                    Name = "Category1"
                },
                new Category
                {
                    CategoryId = categoryGuid2,
                    Name = "Category2"
                },
                new Category
                {
                    CategoryId = categoryGuid3,
                    Name = "Category3"
                },
                new Category
                {
                    CategoryId = categoryGuid4,
                    Name = "Category4"
                },
                new Category
                {
                    CategoryId = categoryGuid5,
                    Name = "Category5"
                },
            };

            var mockCategoryRepository = new Mock<ICategoryRepository>();

            mockCategoryRepository.Setup(repository => repository.ListAll()).Returns(categories);

            return mockCategoryRepository;

        }

        public static Mock<IDishRepository> GetDishRepository()
        {
            var dishes = new List<Dish>
            {
            new Dish
            {
                Name = "Pizza margherita",
                Description = "Delicious classic from the pizza family",
                CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Kcal = 600,
                Price = 25.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            },

            new Dish
            {
                Name = "Pizza salami",
                Description = "The best for meetings with friends",
                CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Kcal = 750,
                Price = 31.50M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Pizza americana",
                Description = "American pizza in the Italian version",
                CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Kcal = 800,
                Price = 32.20M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Four cheeses pizza",
                Description = "the best cheeses on your favorite pizza",
                CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Kcal = 900,
                Price = 33.90M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Spaghetti bolognese",
                Description = "The best pasta with classic bolognese sauce",
                CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Kcal = 450,
                Price = 18.20M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Spaghetti carbonara",
                Description = "Our kitchen's bestseller",
                CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Kcal = 550,
                Price = 19.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            },

            new Dish
            {
                Name = "Lasagne",
                Description = "For more hunger",
                CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Kcal = 840,
                Price = 36.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Tagliatelle with spinach",
                Description = "This taste will surprise you",
                CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Kcal = 410,
                Price = 19.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Creamy tomato soup",
                Description = "Its taste comes from the best ingredients",
                CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Kcal = 180,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            },

            new Dish
            {
                Name = "Curry soup",
                Description = "Our novelty",
                CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Kcal = 210,
                Price = 13.30M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Soup with meatballs",
                Description = "Tasty and nutritious",
                CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Kcal = 210,
                Price = 15.95M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Mushroom soup",
                Description = "Very aromatic dish that will delight everyone",
                CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Kcal = 210,
                Price = 14.49M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Tiramisu",
                Description = "The best dessert that will impress your other half",
                CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Kcal = 300,
                Price = 10.50M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            },

            new Dish
            {
                Name = "Panna Cotta",
                Description = "Melts in your mouth",
                CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Kcal = 290,
                Price = 10.40M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Ice-creams",
                Description = "Sweet and cold what more could you want",
                CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Kcal = 260,
                Price = 9.10M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Granita",
                Description = "It is worth a try",
                CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Kcal = 270,
                Price = 10.05M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Coffee",
                Description = "Just good coffee",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Kcal = 10,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = true
            },

            new Dish
            {
                Name = "Tea",
                Description = "Just good tea",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Kcal = 10,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Water",
                Description = "Just water",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Kcal = 10,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },

            new Dish
            {
                Name = "Coca-Cola",
                Description = "Just Coca-Cola",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Kcal = 110,
                Price = 12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            },
        };

            var mockDishRepository = new Mock<IDishRepository>();

            mockDishRepository.Setup(repository => repository.ListAll()).Returns(dishes);

            return mockDishRepository;
        }
    }
}
