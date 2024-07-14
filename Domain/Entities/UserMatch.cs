namespace Domain.Entities
{
    public sealed class UserMatch : EntityBase
    {
        public int Life { get; set; }
        public bool Winner { get; set; }
        public bool Resign { get; set; }
        public Match? Match { get; set; }
        public Guid MatchId { get; set; }
        public UserMatch() { }
    }
}
