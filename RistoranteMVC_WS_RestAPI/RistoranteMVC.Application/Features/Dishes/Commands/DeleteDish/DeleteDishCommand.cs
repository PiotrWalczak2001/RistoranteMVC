using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Dishes.Commands.DeleteDish
{
    public class DeleteDishCommand : IRequest
    {
        public Guid DishId { get; set; }
    }
}
