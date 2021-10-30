using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;
using RistoranteMVC.ViewModels;
using System;

namespace RistoranteMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DishManagmentController : Controller
    {
        private readonly IDishRepository _dishRepository;
        private readonly ICategoryRepository _categoryRepository;
        public DishManagmentController(IDishRepository dishRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _dishRepository = dishRepository;
        }

        public ViewResult List()
        {
            return View(_dishRepository.ListAll());
        }

        public IActionResult Details(Guid id)
        {
            var matchingDish = _dishRepository.GetById(id);
            if(matchingDish == null)
            {
                return NotFound();
            }
            else
            {
                matchingDish.Category = _categoryRepository.GetById(matchingDish.CategoryId);
                return View(matchingDish);
            }          
        }

        public IActionResult Create()
        {
            return View(new EditDishViewModel { Categories = _categoryRepository.ListAll() });
        }

        [HttpPost]
        public IActionResult Create(EditDishViewModel dishToCreate)
        {
            if(ModelState.IsValid)
            {
                _dishRepository.Add(dishToCreate.Dish);
                return RedirectToAction("SuccessfulEdit", dishToCreate.Dish);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var matchingDish = _dishRepository.GetById(id);
            if (matchingDish == null)
            {
                return NotFound();
            }
            else
            {
                _dishRepository.Delete(id);
                return RedirectToAction("List");
            }
        }

        public IActionResult Edit(Guid id)
        {
            var matchingDish = _dishRepository.GetById(id);
            if (matchingDish == null)
            {
                return NotFound();
            }
            else
            {
                return View(new EditDishViewModel
                {
                    Dish = matchingDish,
                    Categories = _categoryRepository.ListAll()
                });
            }
        }

        [HttpPost]
        public IActionResult Edit(EditDishViewModel dishToEdit)
        {
            if(ModelState.IsValid)
            {
                _dishRepository.Update(dishToEdit.Dish);
                return RedirectToAction("SuccessfulEdit", dishToEdit.Dish);
            }
            else
            {
                return View();
            }
       
        }

        public IActionResult SuccessfulEdit(Dish dish)
        {
            return View(dish);
        }
    }
}
