namespace GivingGardenBE.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime Subscribed_at { get; set; }
        public string? PaymentType { get; set; } 
        public decimal PaymentAmount { get; set; }
        public List<PaymentTypes>? PaymentTypes { get; set; } = new List<PaymentTypes>();
    }
}
