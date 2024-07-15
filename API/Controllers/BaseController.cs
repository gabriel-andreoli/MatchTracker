using API.Responses;
using Domain.Handlers;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{
    public class ApplicationController : ControllerBase
    {
        private readonly INotificationHandler _notificationHandler;
        public ApplicationController(INotificationHandler notificationHandler)
        {
            _notificationHandler = notificationHandler;
        }

        protected ActionResult CreateCustomResponse<T>(T response) 
            where T : BaseResponse
        {
            if (_notificationHandler.HasNotifications()) 
            {
                _notificationHandler.GetNotifications().ForEach(notification => response.AddNotification(notification));
                return BadRequest(response);
            }
            
            return Ok(response);
        }
    }
}
