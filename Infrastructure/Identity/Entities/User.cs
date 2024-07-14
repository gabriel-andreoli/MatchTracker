using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity.Entities
{
    public sealed class User : IdentityUser<Guid>
    {
        public string? Name{ get; set; }
    }
}
