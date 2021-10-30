using Microsoft.AspNetCore.Identity;
using RistoranteMVC.Auth;
using RistoranteMVC.ViewModels;
using System.Threading.Tasks;

namespace RistoranteMVC.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool> Login(LoginViewModel loginViewModel)
        {
            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                if (result.Succeeded)
                {
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> Register(RegisterViewModel registerViewModel)
        {
            var user = new ApplicationUser() 
                { 
                    UserName = registerViewModel.UserName,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    Email = registerViewModel.Email
                };

            var result = await _userManager.CreateAsync(user, registerViewModel.Password);

            if (result.Succeeded)
                return true;
            else
                return false;
            
        }
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
