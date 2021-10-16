using Microsoft.EntityFrameworkCore;
using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RistoranteMVC.Repositories
{
    public class DishRepository : IDishRepository
    {
        protected readonly RistoranteMVCDbContext _dbContext;
        public DishRepository(RistoranteMVCDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Dish GetById(Guid id)
        {
            return _dbContext.Dishes.Find(id);
        }

        public List<Dish> ListAll()
        {
            return _dbContext.Dishes.ToList();
        }

        public Dish Add(Dish dish)
        {
            _dbContext.Dishes.Add(dish);
            _dbContext.SaveChanges();
            return dish;
        }

        public void Delete(Dish dish)
        {
            _dbContext.Dishes.Remove(dish);
            _dbContext.SaveChanges();
        }

        public void Update(Dish dish)
        {
            _dbContext.Entry(dish).State = EntityState.Modified;
            _dbContext.SaveChanges();
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
