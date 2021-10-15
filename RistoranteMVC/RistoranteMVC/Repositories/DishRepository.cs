using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RistoranteMVC.Repositories
{
    public class DishRepository : BaseRepository<Dish>, IDishRepository
    {
        public DishRepository(RistoranteMVCDbContext dbContext) : base(dbContext)
        {

        }
        public List<Dish> DishesByCategory(Guid categoryId)
        {
            return _dbContext.Dishes.Where(d => d.CategoryId == categoryId).ToList();
        }

        public List<Dish> RecommendedDishes()
        {
            return _dbContext.Dishes.Where(d => d.Recommended == true).ToList();
        }
    }
}
