using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;
using RistoranteMVC.ViewModels;
using System.Collections.Generic;

namespace RistoranteMVC.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IDishRepository _dishRepository;
        public HomeController(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }
        [AllowAnonymous]
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
