using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Dishes.Queries.GetAllDishes
{
    public class GetAllDishesQuery : IRequest<List<DishListVm>>
    {
    }
}
