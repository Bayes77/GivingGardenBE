using GivingGardenBE.Data;
using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;
using Microsoft.EntityFrameworkCore;

namespace GivingGardenBE.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly GivingGardenBEDbContext _context;

        public SubscriptionRepository(GivingGardenBEDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subscription>> GetSubscriptionsByUserId(int userId)
        {
            return await _context.Subscriptions
                .Where(s => s.UserId == userId)
                .ToListAsync();
        }

        public async Task<Subscription?> GetSubscriptionById(int id)
        {
            return await _context.Subscriptions.FindAsync(id);
        }

        public async Task<Subscription?> CreateSubscription(Subscription subscription)
        {
            var result = await _context.Subscriptions.AddAsync(subscription);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Subscription?> DeleteSubscription(int id)
        {
            var sub = await _context.Subscriptions.FindAsync(id);
            if (sub == null) return null;

            _context.Subscriptions.Remove(sub);
            await _context.SaveChangesAsync();
            return sub;
        }
    }
}



