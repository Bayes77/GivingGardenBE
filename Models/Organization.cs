namespace GivingGardenBE.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public string? Title { get; set; } 
       
        public string? Email { get; set; } 
        public string? Image { get; set; } 
       
        public string? Description { get; set; } 

        public List<User>? Users { get; set; } = new List<User>();
        public List<Subscription>? Subscriptions { get; set; } = new List<Subscription>();


    }
}
