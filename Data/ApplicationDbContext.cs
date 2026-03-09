using FreelanceMarketplace.Models.Identity;
using FreelanceMarketplace.Models.Contracts;
using FreelanceMarketplace.Models.Messaging;
using FreelanceMarketplace.Models.Notifications;
using FreelanceMarketplace.Models.Payments;
using FreelanceMarketplace.Models.Projects;
using FreelanceMarketplace.Models.Proposals;
using FreelanceMarketplace.Models.Reviews;
using FreelanceMarketplace.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreelanceMarketplace.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<FreelancerSkill> FreelancerSkills { get;set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Proposal> Proposals { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Notification> Notifications { get; set; }
    }
}
