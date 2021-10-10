using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Contracts
{
    public interface IDishRepository : IBaseRepository<Dish>
    {
        List<Dish> DishesByCategory(Guid categoryId);
        List<Dish> RecommendedDishes();
    }
}
