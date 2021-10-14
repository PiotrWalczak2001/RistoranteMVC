using System;
using System.Collections.Generic;

namespace RistoranteMVC.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(Guid id);
        List<T> ListAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
