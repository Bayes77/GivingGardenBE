using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface ISubscriptionServices
    {
        Task<List<Subscription>> GetSubscriptionsByUserId(int userId);
        Task<Subscription?> GetSubscriptionById(int id);
        Task<Subscription?> CreateSubscription(Subscription subscription);
        Task<Subscription?> DeleteSubscription(int id);
    }
}


