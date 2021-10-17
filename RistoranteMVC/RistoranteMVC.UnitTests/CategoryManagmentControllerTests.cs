using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Controllers;
using RistoranteMVC.Models;
using RistoranteMVC.UnitTests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
