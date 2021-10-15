using RistoranteMVC.Models;

namespace RistoranteMVC.Repositories
{
    public interface IOrderRepository
    {
        void TakeOrder(Order order);
    }
}
