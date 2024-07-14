using SharedItems.Entities;

namespace Domain.Entities
{
    public sealed class Organizer : EntityBase
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Event? Event { get; set; }
        public Guid EventId { get; set; }
    }
}
