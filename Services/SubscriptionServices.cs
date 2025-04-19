using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Services
{
    public class SubscriptionServices : ISubscriptionServices
    {
        private readonly ISubscriptionRepository _subscriptionRepository;

        public SubscriptionServices(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }

        public async Task<List<Subscription>> GetSubscriptionsByUserId(int userId)
        {
            return await _subscriptionRepository.GetSubscriptionsByUserId(userId);
        }

        public async Task<Subscription?> GetSubscriptionById(int id)
        {
            return await _subscriptionRepository.GetSubscriptionById(id);
        }

        public async Task<Subscription?> CreateSubscription(Subscription subscription)
        {
            return await _subscriptionRepository.CreateSubscription(subscription);
        }

        public async Task<Subscription?> DeleteSubscription(int id)
        {
            return await _subscriptionRepository.DeleteSubscription(id);
        }

        public async Task<Subscription?> UpdateSubscription(int id, Subscription subscription)
        {
            return await _subscriptionRepository.UpdateSubscription(id,subscription);
        }
    }
}


