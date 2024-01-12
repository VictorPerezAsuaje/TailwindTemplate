using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WebClient.Utilities;

public abstract class ExtendedController : Controller
{
    public void Notify(string message, NotificationIcon icon = NotificationIcon.success, string title = "Notification")
    {
        Notification notification = new Notification()
        {
            Title = title,
            Message = message,
            Icon = icon
        };

        TempData["Notification"] = JsonSerializer.Serialize(notification);
        Response.Headers.TryAdd("HX-Trigger", "notification-added");
    }

    public void Notify(Action<Notification> options)
    {
        Notification notification = new Notification();
        options(notification);
        TempData["Notification"] = JsonSerializer.Serialize(notification);
        Response.Headers.TryAdd("HX-Trigger", "notification-added");
    }
}
