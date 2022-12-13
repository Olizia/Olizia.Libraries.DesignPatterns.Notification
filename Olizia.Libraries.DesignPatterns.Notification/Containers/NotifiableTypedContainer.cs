using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Container;
using Olizia.Libraries.DesignPatterns.Notification.NotificationItems;

namespace Olizia.Libraries.DesignPatterns.Notification.Containers;

public class NotifiableTypedContainer : INotifiableContainer<NotificationItemTyped>
{
    private List<NotificationItemTyped> _notifications;

    public NotifiableTypedContainer()
    {
        _notifications = new List<NotificationItemTyped>();
    }

    public void AddNotification(NotificationItemTyped item)
    {
        _notifications.Add(item);
    }

    public void AddNotifications(List<NotificationItemTyped> items)
    {
        _notifications.AddRange(items);
    }

    public List<NotificationItemTyped> GetNotifications()
    {
        return _notifications;
    }
}
