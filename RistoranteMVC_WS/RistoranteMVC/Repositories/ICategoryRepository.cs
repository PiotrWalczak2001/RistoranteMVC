using RistoranteMVC.Models;
using System;
using System.Collections.Generic;

namespace RistoranteMVC.Repositories
{
    public interface ICategoryRepository
    {
        Category GetById(Guid id);
        List<Category> ListAll();
        Category Add(Category category);
        void Update(Category category);
        void Delete(Guid id);
    }
}
