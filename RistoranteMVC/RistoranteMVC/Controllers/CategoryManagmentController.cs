using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;
using System;

namespace RistoranteMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryManagmentController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryManagmentController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            return View(_categoryRepository.ListAll());
        }

        public IActionResult Details(Guid id)
        {
            var matchingCategory = _categoryRepository.GetById(id);
            if(matchingCategory == null)
            {
                return NotFound();
            }
            else
                return View(matchingCategory);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category categoryToCreate)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.Add(categoryToCreate);
                return RedirectToAction("SuccessfulEdit", categoryToCreate);
            }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var matchingCategory = _categoryRepository.GetById(id);
            if (matchingCategory == null)
            {
                return NotFound();
            }
            else
            {
                _categoryRepository.Delete(id);
                return RedirectToAction("List");
            }              
        }

        public IActionResult Edit(Guid id)
        {

            var matchingCategory = _categoryRepository.GetById(id);
            if (matchingCategory == null)
            {
                return NotFound();
            }
            else
            {
                return View(matchingCategory);
            }
        }

        [HttpPost]
        public IActionResult Edit(Category categoryToEdit)
        {
            if(ModelState.IsValid)
            {
                _categoryRepository.Update(categoryToEdit);
                return RedirectToAction("SuccessfulEdit", categoryToEdit);
            }
            else
                return View();
        }

        public IActionResult SuccessfulEdit(Category category)
        {
            return View(category);
        }

    }
}
