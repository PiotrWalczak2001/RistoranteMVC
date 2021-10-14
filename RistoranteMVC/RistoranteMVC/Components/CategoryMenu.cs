using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Contracts;
using RistoranteMVC.ViewModels;

namespace RistoranteMVC.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.ListAll();
            return View(new CategoryViewModel { Categories = categories});
        }
    }
}
