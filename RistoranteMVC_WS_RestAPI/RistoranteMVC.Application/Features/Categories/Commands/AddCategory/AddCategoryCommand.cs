using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Categories.Commands.AddCategory
{
    public class AddCategoryCommand : IRequest<Guid>
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
