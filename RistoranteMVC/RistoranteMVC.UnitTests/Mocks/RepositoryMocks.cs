using Moq;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;
using System;
using System.Collections.Generic;

namespace RistoranteMVC.UnitTests.Mocks
{
    public static class RepositoryMocks
    {

        public static Mock<ICategoryRepository> GetCategoryRepository()
        {
            var guidList = new List<Guid>
            {
                Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B")
            };


            var categories = new List<Category>
            {
                new Category
                {
                    CategoryId = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"),
                    Name = "Pizzas"
                },
                new Category
                {
                    CategoryId = Guid.Parse("A4B49C2F-93B6-42C7-99C6-524638667AFD"),
                    Name = "Pastas"
                },
                new Category
                {
                    CategoryId = Guid.Parse("C85F1AD9-CEF4-4BAB-94DA-E4DFB466C158"),
                    Name = "Soups"
                },
                new Category
                {
                    CategoryId = Guid.Parse("10895537-2732-403B-87DC-047EC2535593"),
                    Name = "Desserts"
                },
                new Category
                {
                    CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                    Name = "Drinks"
                },
            };

            

            var mockCategoryRepository = new Mock<ICategoryRepository>();

            mockCategoryRepository.Setup(repo => repo.ListAll()).Returns(categories);
            mockCategoryRepository.Setup(repo => repo.GetById(It.IsIn<Guid>(guidList))).Returns(categories[0]);         

            return mockCategoryRepository;

        }

        public static Mock<IDishRepository> GetDishRepository()
        {
            var guidList = new List<Guid>
            {
                Guid.Parse("DF20E4AD-12B7-4ECB-A4AE-ED776B8C6EDD"),
                Guid.Parse("6018CADB-7909-4448-B76C-7E071FCF54BA"),
                Guid.Parse("4739DFD9-37BD-4254-BC24-ED17E6C1358A"),
                Guid.Parse("9350370B-ED3D-4942-8CD5-7126D92BA548"),
                Guid.Parse("77EA1799-9682-48F2-82BA-05B3D0E2AF2A"),

                Guid.Parse("B2D88346-6713-4007-B989-0110EC11D7DF"),
                Guid.Parse("6F4C2926-143D-4C53-B3AB-A9863A7A3C5D"),
                Guid.Parse("E9E3222A-C2B5-448C-84C4-79CBD7C336B6"),
                Guid.Parse("4D6B6C83-3762-442C-A192-23243A15FB75"),
                Guid.Parse("E187728C-9D5A-4161-A00F-B3CA24871524"),

                Guid.Parse("3518F462-C4D0-433A-A61F-37B248EC8DEA"),
                Guid.Parse("BB44E5D5-9618-4CFA-A9DE-5068A79BA44B"),
                Guid.Parse("F40504DE-B060-4D0F-B6F2-6316EEE7E7ED"),
                Guid.Parse("DA047EAE-FC18-44FE-A02E-7B93FB358F03"),
                Guid.Parse("F85A7CDE-AAD3-4084-A098-D282DF40CB94"),

                Guid.Parse("12BB6E79-77C5-4E33-8CEF-94F84A7376B4"),
                Guid.Parse("774CAB28-96D8-421A-94FA-68C91E535342"),
                Guid.Parse("E1E06A42-582A-4372-999D-483051B03152"),
                Guid.Parse("B78AA9B1-64CE-4CE1-90D8-F75A97216AA2"),
                Guid.Parse("28A7637D-AE10-4EED-AEAD-DBF8272FAB3E")
            };


            var dishes = new List<Dish>
            {
            new Dish
            {
                DishId = Guid.Parse("DF20E4AD-12B7-4ECB-A4AE-ED776B8C6EDD"),
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
                DishId = Guid.Parse("6018CADB-7909-4448-B76C-7E071FCF54BA"),
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
                DishId = Guid.Parse("4739DFD9-37BD-4254-BC24-ED17E6C1358A"),
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
                DishId = Guid.Parse("9350370B-ED3D-4942-8CD5-7126D92BA548"),
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
                DishId = Guid.Parse("77EA1799-9682-48F2-82BA-05B3D0E2AF2A"),
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
                DishId = Guid.Parse("B2D88346-6713-4007-B989-0110EC11D7DF"),
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
                DishId = Guid.Parse("6F4C2926-143D-4C53-B3AB-A9863A7A3C5D"),
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
                DishId = Guid.Parse("E9E3222A-C2B5-448C-84C4-79CBD7C336B6"),
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
                DishId = Guid.Parse("4D6B6C83-3762-442C-A192-23243A15FB75"),
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
                DishId = Guid.Parse("E187728C-9D5A-4161-A00F-B3CA24871524"),
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
                DishId = Guid.Parse("3518F462-C4D0-433A-A61F-37B248EC8DEA"),
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
                DishId = Guid.Parse("BB44E5D5-9618-4CFA-A9DE-5068A79BA44B"),
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
                DishId = Guid.Parse("F40504DE-B060-4D0F-B6F2-6316EEE7E7ED"),
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
                DishId = Guid.Parse("DA047EAE-FC18-44FE-A02E-7B93FB358F03"),
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
                DishId = Guid.Parse("F85A7CDE-AAD3-4084-A098-D282DF40CB94"),
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
                DishId = Guid.Parse("28A7637D-AE10-4EED-AEAD-DBF8272FAB3E"),
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
                DishId = Guid.Parse("B78AA9B1-64CE-4CE1-90D8-F75A97216AA2"),
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
                DishId = Guid.Parse("E1E06A42-582A-4372-999D-483051B03152"),
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
                DishId = Guid.Parse("774CAB28-96D8-421A-94FA-68C91E535342"),
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
                DishId = Guid.Parse("12BB6E79-77C5-4E33-8CEF-94F84A7376B4"),
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

            mockDishRepository.Setup(repo => repo.ListAll()).Returns(dishes);
            mockDishRepository.Setup(repo => repo.GetById(It.IsIn<Guid>(guidList))).Returns(dishes[0]);

            return mockDishRepository;
        }
    }
}
