using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
