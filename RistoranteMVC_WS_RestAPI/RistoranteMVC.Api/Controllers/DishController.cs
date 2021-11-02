using MediatR;
using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Application.Features.Dishes.Queries.GetAllDishes;
using RistoranteMVC.Application.Features.Dishes.Queries.GetDishById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DishController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DishController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllDishes")]
        public async Task<ActionResult<List<DishListVm>>> GetAllDishes()
        {
            var dtos = await _mediator.Send(new GetAllDishesQuery());
            return Ok(dtos);
        }

        [HttpGet("details/{id}", Name = "GetDishById")]
        public async Task<ActionResult<DishVm>> GetDishById(Guid id)
        {
            var query = new GetDishByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }

    }
}
