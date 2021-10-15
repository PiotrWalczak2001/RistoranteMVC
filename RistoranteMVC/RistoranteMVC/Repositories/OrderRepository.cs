using RistoranteMVC.Models;
using System;

namespace RistoranteMVC.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly RistoranteMVCDbContext _dbContext;
        private readonly ShoppingCart _shoppingCart;
        public OrderRepository(RistoranteMVCDbContext dbContext, ShoppingCart shoppingCart) 
        {
            _dbContext = dbContext;
            _shoppingCart = shoppingCart;
        }

        public void TakeOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            _dbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                OrderDetail orderDetail = new()
                {
                    DishId = item.Dish.DishId,
                    Price = item.Dish.Price,
                    Amount = item.Amount,
                    OrderId = order.OrderId
                };

                _dbContext.OrderDetails.Add(orderDetail);
            }

            _dbContext.SaveChanges();
        }
    }
}
