using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Categories.Queries.GetCategoryById
{
    public class CategoryVm
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
