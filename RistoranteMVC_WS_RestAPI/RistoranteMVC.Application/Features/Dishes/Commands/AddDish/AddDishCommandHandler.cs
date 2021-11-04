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

namespace RistoranteMVC.Application.Features.Dishes.Commands.AddDish
{
    public class AddDishCommandHandler : IRequestHandler<AddDishCommand, Guid>
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMapper _mapper;
        public AddDishCommandHandler(IDishRepository dishRepository, IMapper mapper)
        {
            _dishRepository = dishRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(AddDishCommand request, CancellationToken cancellationToken)
        {
            var dishToAdd = _mapper.Map<Dish>(request);
            await _dishRepository.AddAsync(dishToAdd);

            return dishToAdd.DishId;
        }
    }
}
