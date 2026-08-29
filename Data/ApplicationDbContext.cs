using BluelineWebsite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BluelineWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Service> Services => Set<Service>();
        public DbSet<Project> Projects => Set<Project>();
        public DbSet<ContactInquiry> ContactInquiries => Set<ContactInquiry>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure unique index for Service URLs
            builder.Entity<Service>()
                .HasIndex(s => s.Slug)
                .IsUnique();

            // Configure relationship between Service and Case Studies
            builder.Entity<Project>()
                .HasOne(p => p.Service)
                .WithMany(s => s.Projects)
                .HasForeignKey(p => p.ServiceId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}