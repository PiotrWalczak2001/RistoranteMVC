using RistoranteMVC.Models;
using System;
using System.Collections.Generic;

namespace RistoranteMVC.Repositories
{
    public interface IDishRepository
    {
        Dish GetById(Guid id);
        List<Dish> ListAll();
        Dish Add(Dish dish);
        void Update(Dish dish);
        void Delete(Dish dish);
        List<Dish> DishesByCategory(Guid categoryId);
        List<Dish> RecommendedDishes();
    }
}
