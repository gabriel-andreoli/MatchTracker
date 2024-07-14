﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Match : EntityBase
    {
        public DateTimeOffset? FinishedAt { get; set; }
        public IEnumerable<UserMatch> UserMatches { get; set; }
        public Event? Event { get; set; }
        public Guid EventId { get; set; } 
        public Match() { }
    }
}
