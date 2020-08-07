using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WeddingPlannerApp.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Role> Roles { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}