using GivingGardenBE.Models;
using Microsoft.EntityFrameworkCore;

namespace GivingGardenBE.Data
{
    public class GivingGardenBEDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<PaymentTypes> PaymentTypes { get; set; }
        public DbSet<Categories> Categories { get; set; }

        public GivingGardenBEDbContext(DbContextOptions<GivingGardenBEDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // === USER ===
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .Property(u => u.FirebaseUid)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasAlternateKey(u => u.FirebaseUid);

            // === ORGANIZATION ===
            modelBuilder.Entity<Organization>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<Organization>()
                .Property(o => o.CategoryName)
                .IsRequired();

            modelBuilder.Entity<Organization>()
                .Property(o => o.Created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Organization>()
                .HasOne(o => o.User)
                .WithMany(u => u.Organizations)
                .HasForeignKey(o => o.UserId)
                .HasPrincipalKey(u => u.FirebaseUid);


            // === SUBSCRIPTION ===
            modelBuilder.Entity<Subscription>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.User)
                .WithMany(u => u.Subscriptions)
                .HasForeignKey(s => s.UserId)
                .HasPrincipalKey(u => u.FirebaseUid)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.Organization)
                .WithMany(o => o.Subscriptions)
                .HasForeignKey(s => s.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);

            // === PAYMENT TYPES ===
            modelBuilder.Entity<PaymentTypes>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<PaymentTypes>()
                .Property(p => p.PaymentTypeName)
                .IsRequired();

            // === CATEGORIES ===
            modelBuilder.Entity<Categories>()
                .HasKey(c => c.Id);

            // === SEED DATA ===
            modelBuilder.Entity<User>().HasData(UserData.Users);
            modelBuilder.Entity<Subscription>().HasData(SubscriptionData.Subscriptions);
            modelBuilder.Entity<Organization>().HasData(OrganizationData.Organizations);
            modelBuilder.Entity<PaymentTypes>().HasData(PaymentTypesData.PaymentTypes);
            modelBuilder.Entity<Categories>().HasData(CategoriesData.Categories);
        }
    }
}
