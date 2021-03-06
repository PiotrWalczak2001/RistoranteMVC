using MediatR;
using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Application.Features.Categories.Commands.AddCategory;
using RistoranteMVC.Application.Features.Categories.Commands.DeleteCategory;
using RistoranteMVC.Application.Features.Categories.Commands.UpdateCategory;
using RistoranteMVC.Application.Features.Categories.Queries.GetAllCategories;
using RistoranteMVC.Application.Features.Categories.Queries.GetCategoryById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllCategories")]
        public async Task<ActionResult<List<CategoryListVm>>> GetAllCategories()
        {
            var dtos = await _mediator.Send(new GetAllCategoriesQuery());
            return Ok(dtos);
        }

        [HttpGet("details/{id}", Name = "GetCategoryById")]
        public async Task<ActionResult<CategoryVm>> GetCategoryById(Guid id)
        {
            var query = new GetCategoryByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }

        [HttpPost(Name = "AddCategory")]
        public async Task<ActionResult<Guid>> Add([FromBody] AddCategoryCommand addCategoryCommand)
        {
            var id = await _mediator.Send(addCategoryCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateCategory")]
        public async Task<ActionResult<Guid>> Update([FromBody] UpdateCategoryCommand updateCategoryCommand)
        {
            var id = await _mediator.Send(updateCategoryCommand);
            return Ok(id);
        }


        [HttpDelete("{id}", Name = "DeleteCategory")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteCategoryCommand = new DeleteCategoryCommand() { CategoryId = id };
            await _mediator.Send(deleteCategoryCommand);
            return NoContent();
        }
    }
}
