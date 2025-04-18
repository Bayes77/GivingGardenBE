
using Microsoft.EntityFrameworkCore;
using GivingGardenBE.Models;



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
            modelBuilder.Entity<User>().HasData(UserData.Users);
            modelBuilder.Entity<Subscription>().HasData(SubscriptionData.Subscriptions);
            modelBuilder.Entity<Organization>().HasData(OrganizationData.Organizations);
            modelBuilder.Entity<PaymentTypes>().HasData(PaymentTypesData.PaymentTypes);
        }
    }
}