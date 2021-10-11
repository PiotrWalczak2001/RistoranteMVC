using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.ViewModels
{
    public class HomeViewModel
    {
        public List<Dish> RecommendedDishes { get; set; }
    }
}
