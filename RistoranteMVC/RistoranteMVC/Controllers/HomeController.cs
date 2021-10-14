﻿using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Contracts;
using RistoranteMVC.Models;
using RistoranteMVC.ViewModels;
using System.Collections.Generic;

namespace RistoranteMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDishRepository _dishRepository;
        public HomeController(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }
        public ViewResult Index()
        {
            List<Dish> recommendedDishes = _dishRepository.RecommendedDishes();
            if(recommendedDishes.Count < 1)
            {
                return View();
            }
            return View(new HomeViewModel { RecommendedDishes = recommendedDishes});
        }
    }
}
