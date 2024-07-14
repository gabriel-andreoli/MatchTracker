using Infrastructure.Context;
using Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Configurations
{
    public static class ProgramExtension
    {
        public static void ConfigureIdentity(this WebApplicationBuilder builder) 
        {
            builder.Services.AddAuthorization();

            builder.Services.AddAuthentication()
                            .AddBearerToken(IdentityConstants.BearerScheme);

            builder.Services.AddIdentityCore<User>()
                            .AddEntityFrameworkStores<MatchTrackerDbContext>()
                            .AddApiEndpoints();
        }

        public static void ConfigureDatabase(this WebApplicationBuilder builder) 
        {
            builder.Services.AddDbContext<MatchTrackerDbContext>(options =>
                            options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection")));
        }

        public static void AddDependencyInjection(this WebApplicationBuilder builder) 
        {

        }
    }
}
