using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class EntityBase
    {
        public Guid? Id { get; set; }
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
