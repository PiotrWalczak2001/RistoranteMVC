using System;

namespace RistoranteMVC.Models
{
    public class ShoppingCartItem
    {
        public Guid ShoppingCartItemId { get; set; }
        public Guid ShoppingCartId { get; set; }
        public Dish Dish { get; set; }
        public int Amount { get; set; }
    }
}
