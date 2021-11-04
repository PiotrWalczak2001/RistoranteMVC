using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Dishes.Commands.UpdateDish
{
    public class UpdateDishCommand : IRequest<Guid>
    {
        public Guid DishId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public int Kcal { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Recommended { get; set; }
    }
}
