using RistoranteMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Contracts.Persistence
{
    public interface IDishRepository : IAsyncRepository<Dish>
    {
    }
}
