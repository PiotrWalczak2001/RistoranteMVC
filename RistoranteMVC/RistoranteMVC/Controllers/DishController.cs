﻿using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;
using RistoranteMVC.ViewModels;
using System;
using System.Collections.Generic;

namespace RistoranteMVC.Controllers
{
    public class DishController : Controller
    {
        private readonly IDishRepository _dishRepository;
        private readonly ICategoryRepository _categoryRepository;
        public DishController(IDishRepository dishRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
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
            var matchingDish = _dishRepository.GetById(id);
            matchingDish.Category = _categoryRepository.GetById(matchingDish.CategoryId);
            return View(matchingDish);
        }
    }
}
