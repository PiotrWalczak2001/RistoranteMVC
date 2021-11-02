using AutoMapper;
using MediatR;
using RistoranteMVC.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Dishes.Queries.GetDishById
{
    public class GetDishByIdQueryHandler : IRequestHandler<GetDishByIdQuery, DishVm>
    {
        private readonly IDishRepository _dishRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public GetDishByIdQueryHandler(IDishRepository dishRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _dishRepository = dishRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<DishVm> Handle(GetDishByIdQuery request, CancellationToken cancellationToken)
        {
            var dish = await _dishRepository.GetByIdAsync(request.Id);
            var mappedDish = _mapper.Map<DishVm>(dish);
            var category = await _categoryRepository.GetByIdAsync(dish.CategoryId);
            var mappedCategory = _mapper.Map<CategoryDto>(category);
            mappedDish.Category = mappedCategory;

            return mappedDish;
        }
    }
}
