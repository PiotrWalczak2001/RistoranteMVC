using System;
using System.ComponentModel.DataAnnotations;

namespace RistoranteMVC.Models
{
    public class Category
    {
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
