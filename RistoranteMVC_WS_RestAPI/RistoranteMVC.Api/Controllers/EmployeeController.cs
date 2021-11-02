using MediatR;
using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Application.Features.Employees.Queries.GetAllEmployees;
using RistoranteMVC.Application.Features.Employees.Queries.GetEmployeeById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllEmployees")]
        public async Task<ActionResult<List<EmployeeListVm>>> GetAllEmployees()
        {
            var dtos = await _mediator.Send(new GetAllEmployeesQuery());
            return Ok(dtos);
        }

        [HttpGet("details/{id}", Name = "GetEmployeeById")]
        public async Task<ActionResult<EmployeeVm>> GetEmployeeById(Guid id)
        {
            var query = new GetEmployeeByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }
    }
}
