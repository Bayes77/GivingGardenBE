namespace GivingGardenBE.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime Subscribed_at { get; set; }
        public string? PaymentType { get; set; } 
        public decimal PaymentAmount { get; set; }
        public User? Users { get; set; } 
        public Organization? Organizations { get; set; }
    }
}
