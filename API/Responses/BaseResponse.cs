using Domain.Models;

namespace API.Responses
{
    public abstract class BaseResponse
    {
        public bool HasNotifications { get; private set; }

        public List<Notification> Notifications { get; private set; } = new List<Notification>();

        public void AddNotification(Notification notification) 
        {
            HasNotifications = true;
            Notifications.Add(notification);
        }
    }
}
