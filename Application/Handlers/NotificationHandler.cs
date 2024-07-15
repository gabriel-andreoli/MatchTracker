using Domain.Handlers;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public sealed class NotificationHandler : INotificationHandler
    {
        private List<Notification> Notifications { get; set; } = new List<Notification>();

        public void AddNotification(string key, string message) => Notifications.Add(new Notification(key, message));

        public void Dispose() => Notifications.Clear();

        public List<Notification> GetNotifications() => Notifications;

        public bool HasNotifications() => Notifications.Any();
    }
}
