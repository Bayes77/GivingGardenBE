﻿using Microsoft.EntityFrameworkCore;    
using GivingGardenBE.Models;
using GivingGardenBE.Data;



namespace GivingGardenBE.Data
{
    public class GivingGardenBEDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        public GivingGardenBEDbContext(DbContextOptions<GivingGardenBEDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(UserData.User);
            modelBuilder.Entity<Subscription>().HasData(SubscriptionData.Subscriptions);
            modelBuilder.Entity<Organization>().HasData(OrganizationData.Organizations);
        }
    }
}
