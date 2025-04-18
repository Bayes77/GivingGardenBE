namespace GivingGardenBE.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Image { get; set; }
        public List<Organization>? Organizations { get; set; } = new List<Organization>();
        public List<Subscription>? Subscriptions { get; set; } = new List<Subscription>();
    }
}
