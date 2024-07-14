using Microsoft.AspNetCore.Identity;

namespace SharedItems.Entities
{
    public sealed class User : IdentityUser<Guid>
    {
        public string? Name { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public bool Deleted { get; set; }

        public void DeleteMe() => Deleted = true;
        public void UpdateMe() => UpdatedAt = DateTimeOffset.Now;
        public void ReactiveMe() => Deleted = false;
        public void Initialize()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTimeOffset.Now;
        }
    }
}
