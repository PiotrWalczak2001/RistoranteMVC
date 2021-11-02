using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Dishes.Queries.GetDishById
{
    public class DishVm
    {
        public Guid DishId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryDto Category { get; set; }
        public Guid CategoryId { get; set; }
        public int Kcal { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
