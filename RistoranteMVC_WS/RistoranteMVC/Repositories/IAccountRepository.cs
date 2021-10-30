using RistoranteMVC.ViewModels;
using System.Threading.Tasks;

namespace RistoranteMVC.Repositories
{
    public interface IAccountRepository
    {
        Task<bool> Login(LoginViewModel loginViewModel);
        Task<bool> Register(RegisterViewModel registerViewModel);
        Task Logout();
    }
}
