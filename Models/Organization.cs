namespace GivingGardenBE.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        
        public string? Title { get; set; } 
       
        public string? Email { get; set; } 
        public string? Image { get; set; } 
       
        public string? Description { get; set; } 
        public string? Mission { get; set; }
        public string? Website { get; set; }
        public string? CategoryName { get; set; }
        public DateTime Created_at { get; set; } 


        public List<User>? Users { get; set; } 
        public List<Subscription>? Subscriptions { get; set; } 
      public List<Categories>? Categories { get; set; } 
        public List<PaymentTypes>? PaymentTypes { get; set; } 
        
     
     


    }
}
