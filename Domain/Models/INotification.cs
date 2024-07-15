using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public sealed class Notification
    {
        public string? Message { get; set; }
        public string? Key { get; set; }
        public DateTimeOffset? Moment { get; set; }
        public Notification() 
        {
        }
        public Notification(string key, string message)
        {
            Key = key;
            Message = message;
            Moment = DateTimeOffset.Now;
        }
    }
}
