using System;
using System.ComponentModel.DataAnnotations;

namespace RistoranteMVC.Models
{
    public class Dish
    {
        [Required]
        public Guid DishId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public Category Category { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        [Range(0,999.99)]
        public int Kcal { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(0,999.99)]
        public decimal Price { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        public bool Recommended { get; set; }
    }
}
