

namespace Domain.Entities
{
    public sealed class Event : EntityBase
    {
        public string Description { get; set; }
        public DateTimeOffset? Init { get; set; }
        public DateTimeOffset? End { get; set; }
        public IEnumerable<Match> Matches { get; set; }
        public IEnumerable<Organizer> Organizers { get; set; }

        public Event() { }

    }
}
