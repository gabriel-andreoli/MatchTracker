﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public interface INotificationHandler
    {
        void AddNotification(string key, string message);
        bool HasNotifications();
        List<Notification> GetNotifications();
        void Dispose();
    }
}
