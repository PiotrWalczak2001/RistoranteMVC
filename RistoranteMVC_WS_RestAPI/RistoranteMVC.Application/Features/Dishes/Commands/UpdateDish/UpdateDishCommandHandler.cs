using AutoMapper;
using MediatR;
using RistoranteMVC.Application.Contracts.Persistence;
using RistoranteMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Dishes.Commands.UpdateDish
{
    public class UpdateDishCommandHandler : IRequestHandler<UpdateDishCommand, Guid>
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMapper _mapper;
        public UpdateDishCommandHandler(IDishRepository dishRepository, IMapper mapper)
        {
            _dishRepository = dishRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(UpdateDishCommand request, CancellationToken cancellationToken)
        {
            var dishToUpdate = _mapper.Map<Dish>(request);
            await _dishRepository.UpdateAsync(dishToUpdate);

            return dishToUpdate.DishId;
        }
    }
}
