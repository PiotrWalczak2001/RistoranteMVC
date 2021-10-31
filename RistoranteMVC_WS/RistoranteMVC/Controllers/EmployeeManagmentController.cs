using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;
using System;

namespace RistoranteMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeManagmentController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeManagmentController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ViewResult List()
        {
            return View(_employeeRepository.ListAll());
        }

        public IActionResult Details(Guid id)
        {
            var matchingEmployee = _employeeRepository.GetById(id);
            if (matchingEmployee == null)
            {
                return NotFound();
            }
            else
            {
                return View(matchingEmployee);
            }
        }

        public IActionResult Create()
        {
            return View(new Employee());
        }

        [HttpPost]
        public IActionResult Create(Employee employeeToCreate)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Add(employeeToCreate);
                return RedirectToAction("SuccessfulEdit", employeeToCreate);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var matchingEmployee = _employeeRepository.GetById(id);
            if (matchingEmployee == null)
            {
                return NotFound();
            }
            else
            {
                _employeeRepository.Delete(id);
                return RedirectToAction("List");
            }
        }

        public IActionResult SuccessfulEdit(Employee employee)
        {
            return View(employee);
        }
    }
}
