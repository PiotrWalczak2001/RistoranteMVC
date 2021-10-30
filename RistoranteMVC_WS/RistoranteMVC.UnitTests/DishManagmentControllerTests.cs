using Microsoft.AspNetCore.Mvc;
using Moq;
using RistoranteMVC.Controllers;
using RistoranteMVC.Models;
using RistoranteMVC.UnitTests.Mocks;
using RistoranteMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RistoranteMVC.UnitTests
{
    public class DishManagmentControllerTests
    {
        [Fact]
        public void List_ReturnsAViewResult_WithAllDishes()
        {
            //arrange
            var mockDishRepository = RepositoryMocks.GetDishRepository();
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var dishManagmentController = new DishManagmentController(mockDishRepository.Object, mockCategoryRepository.Object);

            //act
            var result = dishManagmentController.List();

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var dishes = Assert.IsAssignableFrom<List<Dish>>(viewResult.ViewData.Model);
            Assert.Equal(20, dishes.Count());
        }
        
        [Fact]
        public void DishDetails_ReturnsAViewResult_WithDishDetails()
        {
            //arrange
            var mockDishRepository = RepositoryMocks.GetDishRepository();
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var dishManagmentController = new DishManagmentController(mockDishRepository.Object, mockCategoryRepository.Object);

            //act
            var result = dishManagmentController.Details(Guid.Parse("DF20E4AD-12B7-4ECB-A4AE-ED776B8C6EDD"));

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult.Model);
        }

        [Fact]
        public void DishDetails_InValidGuid_ReturnNotFoundResult()
        {
            //arrange
            var mockDishRepository = RepositoryMocks.GetDishRepository();
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var dishManagmentController = new DishManagmentController(mockDishRepository.Object, mockCategoryRepository.Object);

            //act
            var result = dishManagmentController.Details(Guid.Parse("ACD6B6C6-4EB8-4C60-A6E9-CC64B97214E7"));

            //assert
            Assert.IsType<NotFoundResult>(result);
        }

       [Fact]
       public void CreateDish_POST_SuccessfulyCreateDish_AndRedirectToAction()
       {
           //arrange
           var mockDishRepository = RepositoryMocks.GetDishRepository();
           var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
           mockDishRepository.Setup(repo => repo.Add(It.IsAny<Dish>())).Verifiable();

           var dishManagmentController = new DishManagmentController(mockDishRepository.Object, mockCategoryRepository.Object);

           Dish dishToCreate = new Dish
           {
                DishId = Guid.Parse("5BDED331-45EC-4852-B1B4-84795B0999EB"),
                Name = "New Dish",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Description = "New Description",
                Kcal = 333,
                Price = 40.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
           };

           EditDishViewModel editDishToCreateViewModel = new EditDishViewModel { Dish = dishToCreate , Categories = mockCategoryRepository.Object.ListAll()};
            
           //act
           var result = dishManagmentController.Create(editDishToCreateViewModel);

           //assert
           var redirect = Assert.IsType<RedirectToActionResult>(result);
           Assert.Equal("SuccessfulEdit", redirect.ActionName);
           Assert.NotNull(redirect.RouteValues);
           Assert.Equal(dishToCreate.CategoryId, redirect.RouteValues["CategoryId"]);
           Assert.Equal(dishToCreate.Name, redirect.RouteValues["Name"]);
           Assert.Equal(dishToCreate.DishId, redirect.RouteValues["DishId"]);
           Assert.Equal(dishToCreate.Description, redirect.RouteValues["Description"]);
           Assert.Equal(dishToCreate.Kcal, redirect.RouteValues["Kcal"]);
           Assert.Equal(dishToCreate.Price, redirect.RouteValues["Price"]);
           Assert.Equal(dishToCreate.ImageUrl, redirect.RouteValues["ImageUrl"]);
           Assert.Equal(dishToCreate.Recommended, redirect.RouteValues["Recommended"]);

           mockDishRepository.Verify();
       }

        
        [Fact]
        public void EditDish_POST_SuccessfulyUpdateDish_AndRedirectToAction()
        {
            //arrange
            var mockDishRepository = RepositoryMocks.GetDishRepository();
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            mockDishRepository.Setup(repo => repo.Update(It.IsAny<Dish>())).Verifiable();

            var dishManagmentController = new DishManagmentController(mockDishRepository.Object, mockCategoryRepository.Object);

            Dish dishToEdit = new Dish
            {
                DishId = Guid.Parse("DF20E4AD-12B7-4ECB-A4AE-ED776B8C6EDD"),
                Name = "Edited Dish",
                CategoryId = Guid.Parse("D99C5243-4815-4722-9FE3-E27623B8232B"),
                Description = "Edited Description",
                Kcal = 111,
                Price = 99.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png",
                Recommended = false
            };

            EditDishViewModel dishToEditViewModel = new EditDishViewModel { Dish = dishToEdit, Categories = mockCategoryRepository.Object.ListAll() };

            //act
            var result = dishManagmentController.Edit(dishToEditViewModel);

            //assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("SuccessfulEdit", redirect.ActionName);
            Assert.NotNull(redirect.RouteValues);
            Assert.Equal(dishToEdit.CategoryId, redirect.RouteValues["CategoryId"]);
            Assert.Equal(dishToEdit.Name, redirect.RouteValues["Name"]);
            Assert.Equal(dishToEdit.DishId, redirect.RouteValues["DishId"]);
            Assert.Equal(dishToEdit.Description, redirect.RouteValues["Description"]);
            Assert.Equal(dishToEdit.Kcal, redirect.RouteValues["Kcal"]);
            Assert.Equal(dishToEdit.Price, redirect.RouteValues["Price"]);
            Assert.Equal(dishToEdit.ImageUrl, redirect.RouteValues["ImageUrl"]);
            Assert.Equal(dishToEdit.Recommended, redirect.RouteValues["Recommended"]);

            mockDishRepository.Verify();
        }
        

       [Fact]
       public void DeleteDish_POST_SuccessfulyDeleteDish_AndRedirectToList()
       {
           //arrange
           var mockDishRepository = RepositoryMocks.GetDishRepository();
           var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
           mockDishRepository.Setup(repo => repo.Delete(It.IsAny<Guid>())).Verifiable();

           var dishManagmentController = new DishManagmentController(mockDishRepository.Object, mockCategoryRepository.Object);

           //act
           var result = dishManagmentController.Delete(Guid.Parse("DF20E4AD-12B7-4ECB-A4AE-ED776B8C6EDD"));

           //assert
           var redirect = Assert.IsType<RedirectToActionResult>(result);
           Assert.Equal("List", redirect.ActionName);

           mockDishRepository.Verify();
       }

       [Fact]
       public void DishDelete_InValidGuid_ReturnNotFoundResult()
       {
           //arrange
           var mockDishRepository = RepositoryMocks.GetDishRepository();
           var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
           var dishManagmentController = new DishManagmentController(mockDishRepository.Object, mockCategoryRepository.Object);

           //act
           var result = dishManagmentController.Delete(Guid.Parse("EE00AA87-C9E0-4B10-ACB1-60E06BEABFE6"));

           //assert
           Assert.IsType<NotFoundResult>(result);
       }

    }
}
