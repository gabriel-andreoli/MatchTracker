using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Entities
{
    public sealed class User : IdentityUser<Guid>
    {
        public string? Name{ get; set; }
    }
}
