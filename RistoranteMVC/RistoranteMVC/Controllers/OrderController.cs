using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;

namespace RistoranteMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TakeOrder(Order order)
        {
            var itemsFromCart = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = itemsFromCart;

            if(_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Empty cart");
            }

            if(ModelState.IsValid)
            {
                _orderRepository.TakeOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CompleteOrder");
            }

            return View(order);
        }

        public IActionResult CompleteOrder()
        {
            return View();
        }
    }
}
