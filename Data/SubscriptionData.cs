using GivingGardenBE.Models;

namespace GivingGardenBE.Data
{
    public class SubscriptionData
    {
        public static List<Subscription> Subscriptions = new()
        {
            new() { Id = 1, UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", OrganizationId = 108, Subscribed_at = DateTime.Now, PayFrequency = "Monthly", PaymentType = "paypal", PaymentAmount = 10.00m },
            new() { Id = 2, UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", OrganizationId = 102, Subscribed_at = DateTime.Now, PayFrequency = "Quarterly", PaymentType = "debit", PaymentAmount = 10.00m },
            new() { Id = 3, UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", OrganizationId = 106, Subscribed_at = DateTime.Now, PayFrequency = "Monthly", PaymentType = "mastercard", PaymentAmount = 10.00m },
            new() { Id = 4, UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2", OrganizationId = 104, Subscribed_at = DateTime.Now, PayFrequency = "Weekly", PaymentType = "cryptocurrency", PaymentAmount = 10.00m },
            new() { Id = 5, UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2", OrganizationId = 105, Subscribed_at = DateTime.Now, PayFrequency = "Yearly", PaymentType = "visa", PaymentAmount = 10.00m },
        };
    }
}
