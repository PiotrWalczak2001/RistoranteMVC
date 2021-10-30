using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Auth;
using RistoranteMVC.Repositories;
using RistoranteMVC.ViewModels;
using System.Threading.Tasks;

namespace RistoranteMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _accountRepository.Login(loginViewModel))
                    return RedirectToAction("Index", "Home");
            }
  
            ModelState.AddModelError("", "Username/password not found");
            return View(loginViewModel);
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _accountRepository.Register(registerViewModel))
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(registerViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _accountRepository.Logout();
            return RedirectToAction("Index", "Home");
        }

    }
}
