using Microsoft.AspNetCore.Mvc;
using Moq;
using RistoranteMVC.Controllers;
using RistoranteMVC.Models;
using RistoranteMVC.UnitTests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RistoranteMVC.UnitTests
{
    public class CategoryManagmentControllerTests
    {
        [Fact]
        public void List_ReturnsAViewResult_WithAllCategories()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();       
            var categoryManagmentController = new CategoryManagmentController(mockCategoryRepository.Object);

            //act
            var result = categoryManagmentController.List();

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var categories = Assert.IsAssignableFrom<List<Category>>(viewResult.ViewData.Model);
            Assert.Equal(5, categories.Count());
        }

        [Fact]
        public void CategoryDetails_ReturnsAViewResult_WithCategoryDetails()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var categoryManagmentController = new CategoryManagmentController(mockCategoryRepository.Object);

            //act
            var result = categoryManagmentController.Details(Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"));

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult.Model);
        }

        [Fact]
        public void CategoryDetails_InValidGuid_ReturnNotFoundResult()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var categoryManagmentController = new CategoryManagmentController(mockCategoryRepository.Object);

            //act
            var result = categoryManagmentController.Details(Guid.Parse("ACD6B6C6-4EB8-4C60-A6E9-CC64B97214E7"));

            //assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void CreateCategory_POST_SuccessfulyCreateCategory_AndRedirectToAction()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            mockCategoryRepository.Setup(repo => repo.Add(It.IsAny<Category>())).Verifiable();

            var categoryManagmentController = new CategoryManagmentController(mockCategoryRepository.Object);

            var categoryToCreateGuid = Guid.Parse("5BDED331-45EC-4852-B1B4-84795B0999EB");
            var categoryToCreateName = "New Category";
            Category categoryToCreate = new Category { CategoryId = categoryToCreateGuid, Name = categoryToCreateName };

            //act
            var result = categoryManagmentController.Create(categoryToCreate);

            //assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("SuccessfulEdit", redirect.ActionName);
            Assert.NotNull(redirect.RouteValues);
            Assert.Equal(categoryToCreateGuid, redirect.RouteValues["CategoryId"]);
            Assert.Equal(categoryToCreateName, redirect.RouteValues["Name"]);

            mockCategoryRepository.Verify();
        }

        [Fact]
        public void EditCategory_POST_SuccessfulyUpdateCategory_AndRedirectToAction()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            mockCategoryRepository.Setup(repo => repo.Update(It.IsAny<Category>())).Verifiable();

            var categoryManagmentController = new CategoryManagmentController(mockCategoryRepository.Object);

            var categoryToEditGuid = Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A");
            var categoryToEditName = "Edited Category";
            Category categoryToEdit = new Category { CategoryId = categoryToEditGuid, Name = categoryToEditName};

            //act
            var result = categoryManagmentController.Edit(categoryToEdit);

            //assert
              var redirect = Assert.IsType<RedirectToActionResult>(result);
              Assert.Equal("SuccessfulEdit", redirect.ActionName);
              Assert.NotNull(redirect.RouteValues);
              Assert.Equal(categoryToEditGuid, redirect.RouteValues["CategoryId"]);
              Assert.Equal(categoryToEditName, redirect.RouteValues["Name"]);

              mockCategoryRepository.Verify(); 
        }

        [Fact]
        public void DeleteCategory_POST_SuccessfulyDeleteCategory_AndRedirectToList()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            mockCategoryRepository.Setup(repo => repo.Delete(It.IsAny<Guid>())).Verifiable();

            var categoryManagmentController = new CategoryManagmentController(mockCategoryRepository.Object);

            //act
            var result = categoryManagmentController.Delete(Guid.Parse("9BCD1113-6B23-4493-BC83-0C80A436430A"));

            //assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("List", redirect.ActionName);

            mockCategoryRepository.Verify();
        }

        [Fact]
        public void CategoryDelete_InValidGuid_ReturnNotFoundResult()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var categoryManagmentController = new CategoryManagmentController(mockCategoryRepository.Object);

            //act
            var result = categoryManagmentController.Delete(Guid.Parse("EE00AA87-C9E0-4B10-ACB1-60E06BEABFE6"));

            //assert
            Assert.IsType<NotFoundResult>(result);
        }

    }
}
