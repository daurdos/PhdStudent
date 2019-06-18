using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Phd.Models
{
    public class PhdContext : IdentityDbContext<User>
    {
        public PhdContext (DbContextOptions<PhdContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Phd.Models.PhdStudent> PhdStudent { get; set; }
        public DbSet<Phd.Models.Vote> Vote { get; set; }

        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        */
    }
}
