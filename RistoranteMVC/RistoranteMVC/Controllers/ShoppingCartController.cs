using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;
using RistoranteMVC.ViewModels;
using System;
using System.Linq;

namespace RistoranteMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDishRepository _dishRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IDishRepository dishRepository, ShoppingCart shoppingCart)
        {
            _dishRepository = dishRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var itemsFromCart = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = itemsFromCart;

            if(_shoppingCart.ShoppingCartItems.Count == 0)
            {
                return View(new ShoppingCartViewModel { Message = "Empty cart" });
            }

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(Guid id)
        {
            var dishToAdd = _dishRepository.ListAll().FirstOrDefault(d => d.DishId == id);

            if (dishToAdd != null)
            {
                _shoppingCart.AddToCart(dishToAdd);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(Guid id)
        {
            var dishToRemove = _dishRepository.ListAll().FirstOrDefault(d => d.DishId == id);

            if (dishToRemove != null)
            {
                _shoppingCart.RemoveFromCart(dishToRemove);
            }
            return RedirectToAction("Index");
        }

    }
}
