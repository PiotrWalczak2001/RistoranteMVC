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
    }
}
