using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Models
{
    public class Dish
    {
        public Guid DishId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public int Kcal { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Recommended { get; set; }
    }
}
