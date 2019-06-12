using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phd.Models;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;

namespace Phd.Models
{
    public class PhdContext : DbContext
    {
        public PhdContext (DbContextOptions<PhdContext> options)
            : base(options)
        {
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
