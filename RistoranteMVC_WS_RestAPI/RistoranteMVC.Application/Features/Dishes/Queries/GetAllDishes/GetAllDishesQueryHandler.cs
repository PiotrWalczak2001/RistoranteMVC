using AutoMapper;
using MediatR;
using RistoranteMVC.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Dishes.Queries.GetAllDishes
{
    public class GetAllDishesQueryHandler : IRequestHandler<GetAllDishesQuery, List<DishListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IDishRepository _dishRepository;
        public GetAllDishesQueryHandler(IDishRepository dishRepository, IMapper mapper)
        {
            _dishRepository = dishRepository;
            _mapper = mapper;
        }
        public async Task<List<DishListVm>> Handle(GetAllDishesQuery request, CancellationToken cancellationToken)
        {
            var dishes = await _dishRepository.ListAllAsync();
            var mappedDishes = _mapper.Map<List<DishListVm>>(dishes);
            return mappedDishes;
        }
    }
}
