using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Container;
using Olizia.Libraries.DesignPatterns.Notification.NotificationItems;

namespace Olizia.Libraries.DesignPatterns.Notification.Containers;

public class NotifiableContainer : INotifiableContainer<NotificationItemStandard>
{
    private List<NotificationItemStandard> _notifications;

    public NotifiableContainer()
    {
        _notifications = new List<NotificationItemStandard>();
    }

    public void AddNotification(NotificationItemStandard item)
    {
        _notifications.Add(item);
    }

    public void AddNotifications(List<NotificationItemStandard> items)
    {
        _notifications.AddRange(items);
    }

    public List<NotificationItemStandard> GetNotifications()
    {
        return _notifications;
    }
}
