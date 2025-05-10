using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface ISubscriptionRepository
    {
        Task<List<Subscription>> GetSubscriptionsByUserId(string userId);
        Task<Subscription?> CreateSubscription(Subscription subscription);

        Task<Subscription?> UpdateSubscription(int id, Subscription subscription);
        Task<Subscription?> DeleteSubscription(int id);
        Task<Subscription?> GetSubscriptionById(int id);
    }
}


