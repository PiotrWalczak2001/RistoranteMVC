using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Contracts;
using RistoranteMVC.Models;
using RistoranteMVC.ViewModels;
using System;
using System.Collections.Generic;

namespace RistoranteMVC.Controllers
{
    public class DishController : Controller
    {
        private readonly IDishRepository _dishRepository;
        public DishController(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }
        public ViewResult List(string categoryId)
        {
            List<Dish> dishes;
            if(string.IsNullOrEmpty(categoryId))
            {
                dishes = _dishRepository.ListAll();
            }
            else
            {
                dishes = _dishRepository.DishesByCategory(Guid.Parse(categoryId));
            }

            return View(new DishListViewModel { Dishes = dishes});
        }

        [Route("[controller]/Details/{id}")]
        public IActionResult Details(Guid id)
        {
            var dish = _dishRepository.GetById(id);
            return View(new DishDetailsViewModel { Dish = dish });
        }
    }
}
