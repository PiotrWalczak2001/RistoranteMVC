using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Models
{
    public class OrderDetail
    {
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public Guid DishId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Dish Dish { get; set; }
        public virtual Order Order { get; set; }
    }
}
