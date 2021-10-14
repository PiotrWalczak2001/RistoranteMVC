using Microsoft.EntityFrameworkCore;
using RistoranteMVC.Contracts;
using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RistoranteMVC.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly RistoranteMVCDbContext _dbContext;
        public BaseRepository(RistoranteMVCDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T GetById(Guid id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public List<T> ListAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
