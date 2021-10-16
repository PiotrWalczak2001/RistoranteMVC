﻿using Microsoft.AspNetCore.Authorization;
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

        public IActionResult List()
        {
            return View(_categoryRepository.ListAll());
        }

        public IActionResult Details(Guid id)
        {
            return View(_categoryRepository.GetById(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category categoryToCreate)
        {
            categoryToCreate.CategoryId = Guid.NewGuid();
            _categoryRepository.Add(categoryToCreate);
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var categoryToDelete = _categoryRepository.GetById(id);
            _categoryRepository.Delete(categoryToDelete);
            return RedirectToAction("List");
        }

        public IActionResult Edit(Guid id)
        {
            return View(_categoryRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Category categoryToEdit)
        {
            _categoryRepository.Update(categoryToEdit);
            return RedirectToAction("List");
        }
    }
}