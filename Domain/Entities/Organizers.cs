using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedItems.Entities;

namespace Domain.Entities
{
    public sealed class Organizers : EntityBase
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
