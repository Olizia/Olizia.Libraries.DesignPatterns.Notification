using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Item;
using Olizia.Libraries.DesignPatterns.Notification.NotificationItems.ENUMs;

namespace Olizia.Libraries.DesignPatterns.Notification.NotificationItems;

public class NotificationItemTyped : INotificationItem
{
    public NotificationItemTyped(string message, TypeNotification typeNotification)
    {
        Message = message;
        TypeNotification = typeNotification;
    }

    public string Message { get; set; }
    public TypeNotification TypeNotification { get; set; }
}
