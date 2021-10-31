using RistoranteMVC.Models;
using System;
using System.Collections.Generic;

namespace RistoranteMVC.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetById(Guid id);
        List<Employee> ListAll();
        Employee Add(Employee employee);
        void Delete(Guid id);
    }
}
