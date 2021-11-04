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

namespace RistoranteMVC.Application.Features.Employees.Commands.AddEmployee
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, Guid>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public AddEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeToAdd = _mapper.Map<Employee>(request);
            await _employeeRepository.AddAsync(employeeToAdd);
            return employeeToAdd.EmployeeId;
        }
    }
}
