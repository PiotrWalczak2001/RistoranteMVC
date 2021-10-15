using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Repositories;

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
            return View(_categoryRepository.ListAll());
        }
    }
}
