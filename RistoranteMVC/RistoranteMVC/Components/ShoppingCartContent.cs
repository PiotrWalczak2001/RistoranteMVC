using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Models;
using RistoranteMVC.ViewModels;

namespace RistoranteMVC.Components
{
    public class ShoppingCartContent : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartContent(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {

            var itemsFromCart = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = itemsFromCart;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
