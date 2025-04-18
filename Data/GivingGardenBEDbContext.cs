﻿using Microsoft.EntityFrameworkCore;    
﻿using Microsoft.EntityFrameworkCore;    
using GivingGardenBE.Models;
using GivingGardenBE.Data;
using GivingGardenBE.Data;
using GivingGardenBE.Data;
using GivingGardenBE.Data;



=======
﻿using Microsoft.EntityFrameworkCore;
using GivingGardenBE.Models;
using GivingGardenBE.Data;
>>>>>>> main
namespace GivingGardenBE.Data
{
    public class GivingGardenBEDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<PaymentTypes> PaymentTypes { get; set; }
        public GivingGardenBEDbContext(DbContextOptions<GivingGardenBEDbContext> options)
            : base(options)
        {
        }
>>>>>>> main
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(UserData.Users);
            modelBuilder.Entity<Subscription>().HasData(SubscriptionData.Subscriptions);
            modelBuilder.Entity<Organization>().HasData(OrganizationData.Organizations);
            modelBuilder.Entity<PaymentTypes>().HasData(PaymentTypesData.PaymentTypes);
        }
    }
}