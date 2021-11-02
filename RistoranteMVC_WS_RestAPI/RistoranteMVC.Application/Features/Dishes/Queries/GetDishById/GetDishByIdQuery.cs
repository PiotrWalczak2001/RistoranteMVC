using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Dishes.Queries.GetDishById
{
    public class GetDishByIdQuery : IRequest<DishVm>
    {
        public Guid Id { get; set; }
    }
}
