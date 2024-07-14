using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mappings
{
    public static class ModelBuilderExtension
    {
        public static void ConfigureMappings(this ModelBuilder builder) 
        {
            builder.ApplyConfiguration(new EventMapping());
            builder.ApplyConfiguration(new OrganizeMapping());
            builder.ApplyConfiguration(new MatchMapping());
        }
    }
}
