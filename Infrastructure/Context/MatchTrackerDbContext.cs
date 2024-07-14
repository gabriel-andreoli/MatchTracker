using Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public sealed class MatchTrackerDbContext : IdentityDbContext<User,IdentityRole<Guid>, Guid>
    {
        public MatchTrackerDbContext(DbContextOptions<MatchTrackerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("identity");
        }
    }
}
