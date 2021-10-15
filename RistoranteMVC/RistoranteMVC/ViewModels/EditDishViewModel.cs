using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.ViewModels
{
    public class EditDishViewModel
    {
        public Dish Dish { get; set; }
        public List<Category> Categories { get; set; }
    }
}
