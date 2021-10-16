using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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

        public IActionResult List()
        {
            return View(_dishRepository.ListAll());
        }

        public IActionResult Details(Guid id)
        {
            var matchingDish = _dishRepository.GetById(id);
            matchingDish.Category = _categoryRepository.GetById(matchingDish.CategoryId);
            return View(matchingDish);
        }

        public IActionResult Create()
        {
            return View(new EditDishViewModel { Categories = _categoryRepository.ListAll() });
        }

        [HttpPost]
        public IActionResult Create(EditDishViewModel dishToCreate)
        {
            _dishRepository.Add(dishToCreate.Dish);
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var dishToDelete = _dishRepository.GetById(id);
            _dishRepository.Delete(dishToDelete);
            return RedirectToAction("List");
        }

        public IActionResult Edit(Guid id)
        {
            return View(new EditDishViewModel
            {
                Dish = _dishRepository.GetById(id),
                Categories = _categoryRepository.ListAll()
            });
        }

        [HttpPost]
        public IActionResult Edit(EditDishViewModel dishViewModel)
        {
            _dishRepository.Update(dishViewModel.Dish);
            return RedirectToAction("List");
        }
    }
}
