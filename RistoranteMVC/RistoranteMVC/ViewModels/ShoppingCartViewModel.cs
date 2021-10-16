using RistoranteMVC.Models;

namespace RistoranteMVC.ViewModels
{
    public class ShoppingCartViewModel
    {
        public string Message { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
