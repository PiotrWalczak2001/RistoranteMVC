using RistoranteMVC.Models;

namespace RistoranteMVC.Contracts
{
    public interface IOrderRepository
    {
        void TakeOrder(Order order);
    }
}
