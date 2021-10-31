using Microsoft.EntityFrameworkCore;
using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected readonly RistoranteMVCDbContext _dbContext;
        public EmployeeRepository(RistoranteMVCDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Employee GetById(Guid id)
        {
            return _dbContext.Employees.Find(id);
        }

        public List<Employee> ListAll()
        {
            return _dbContext.Employees.ToList();
        }

        public Employee Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }

        public void Delete(Guid id)
        {
            _dbContext.Employees.Remove(_dbContext.Employees.Find(id));
            _dbContext.SaveChanges();
        }
    }
}
