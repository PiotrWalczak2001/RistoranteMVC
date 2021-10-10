using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Models
{
    public class Coupon
    {
        public Guid CouponId { get; set; }
        public string CouponName { get; set; }
        public int Discount { get; set; }
        public bool? OnAll {get; set;}
        public bool? OnCategory {get; set;}
        public Guid? CategoryId { get; set; }
        public bool? OnDish {get; set;}
        public Guid? DishId { get; set; }
    }
}
