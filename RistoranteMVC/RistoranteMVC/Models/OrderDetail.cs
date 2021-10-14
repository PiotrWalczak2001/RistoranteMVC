using System;

namespace RistoranteMVC.Models
{
    public class OrderDetail
    {
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public Guid DishId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Dish Dish { get; set; }
        public Order Order { get; set; }
    }
}
