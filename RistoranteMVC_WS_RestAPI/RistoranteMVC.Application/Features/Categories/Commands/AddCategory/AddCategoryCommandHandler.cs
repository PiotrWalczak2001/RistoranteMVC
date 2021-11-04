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

namespace RistoranteMVC.Application.Features.Categories.Commands.AddCategory
{
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public AddCategoryCommandHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryToAdd = _mapper.Map<Category>(request);
            await _categoryRepository.AddAsync(categoryToAdd);

            return categoryToAdd.CategoryId;
        }
    }
}
