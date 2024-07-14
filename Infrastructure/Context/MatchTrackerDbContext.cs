using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedItems.Entities;

namespace Infrastructure.Context
{
    public sealed class MatchTrackerDbContext : IdentityDbContext<User,IdentityRole<Guid>, Guid>
    {
        public MatchTrackerDbContext(DbContextOptions<MatchTrackerDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("identity");
        }
    }
}
