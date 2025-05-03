using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface ISubscriptionServices
    {
        Task<List<Subscription>> GetSubscriptionsByUserId(string userId);
        Task<Subscription?> CreateSubscription(Subscription subscription);
        Task<Subscription?> UpdateSubscription(int id, Subscription subscription);
        Task<Subscription?> DeleteSubscription(int id);
    }
}


