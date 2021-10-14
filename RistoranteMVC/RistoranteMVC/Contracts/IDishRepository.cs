using RistoranteMVC.Models;
using System;
using System.Collections.Generic;

namespace RistoranteMVC.Contracts
{
    public interface IDishRepository : IBaseRepository<Dish>
    {
        List<Dish> DishesByCategory(Guid categoryId);
        List<Dish> RecommendedDishes();
    }
}
