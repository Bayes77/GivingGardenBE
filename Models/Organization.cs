﻿namespace GivingGardenBE.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public string? Title { get; set; } 
       
        public string? Email { get; set; } 
        public string? Image { get; set; } 
       
        public string? Description { get; set; } 
       
       
    }
}
