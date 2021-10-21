using Microsoft.EntityFrameworkCore;
using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RistoranteMVC.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        protected readonly RistoranteMVCDbContext _dbContext;
        public CategoryRepository(RistoranteMVCDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Category GetById(Guid id)
        {
            return _dbContext.Categories.Find(id);
        }

        public List<Category> ListAll()
        {
            return _dbContext.Categories.ToList();
        }

        public Category Add(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public void Delete(Guid id)
        {
            _dbContext.Categories.Remove(_dbContext.Categories.Find(id));
            _dbContext.SaveChanges();
        }

        public void Update(Category category)
        {
            _dbContext.Entry(category).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
