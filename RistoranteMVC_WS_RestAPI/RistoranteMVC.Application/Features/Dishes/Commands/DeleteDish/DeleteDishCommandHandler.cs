using MediatR;
using RistoranteMVC.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Dishes.Commands.DeleteDish
{
    public class DeleteDishCommandHandler : IRequestHandler<DeleteDishCommand>
    {
        private readonly IDishRepository _dishRepository;
        public DeleteDishCommandHandler(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }
        public async Task<Unit> Handle(DeleteDishCommand request, CancellationToken cancellationToken)
        {
            var dish = await _dishRepository.GetByIdAsync(request.DishId);
            await _dishRepository.DeleteAsync(dish);
            return Unit.Value;
        }
    }
}
