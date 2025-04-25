using GivingGardenBE.Models;

namespace GivingGardenBE.Data
{
    public class SubscriptionData
    {
        public static List<Subscription> Subscriptions = new()
        {
            new() { Id = 1, UserId = 1, OrganizationId = 108, Subscribed_at = DateTime.Now, PaymentType = "paypal", PaymentAmount = 10.00m },
            new() { Id = 2, UserId = 2, OrganizationId = 102, Subscribed_at = DateTime.Now, PaymentType = "debit", PaymentAmount = 10.00m },
            new() { Id = 3, UserId = 3, OrganizationId = 106, Subscribed_at = DateTime.Now, PaymentType = "mastercard", PaymentAmount = 10.00m },
            new() { Id = 4, UserId = 4, OrganizationId = 104, Subscribed_at = DateTime.Now, PaymentType = "cryptocurrency", PaymentAmount = 10.00m },
            new() { Id = 5, UserId = 5, OrganizationId = 105, Subscribed_at = DateTime.Now, PaymentType = "visa", PaymentAmount = 10.00m },
        };
    }
}
