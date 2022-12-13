using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Item;

namespace Olizia.Libraries.DesignPatterns.Notification.NotificationItems;

public class NotificationItemStandard : INotificationItem
{
    public NotificationItemStandard(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
}