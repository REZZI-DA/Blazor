using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StudentWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<model.Club> Clubs { get; set; }


        public DbSet<model.ClubsByLeague> ClubsByLeagues { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<model.ClubsByLeague>().HasNoKey().ToView(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
