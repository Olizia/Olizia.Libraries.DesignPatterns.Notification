using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Container;
using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Publisher;
using Olizia.Libraries.DesignPatterns.Notification.NotificationItems;

namespace Olizia.Libraries.DesignPatterns.Notification.Publishers;

public class NotificationPublisherTyped : INotificationPublisher<NotificationItemTyped>
{
    private INotifiableContainer<NotificationItemTyped> _notifiableContainer;

    public NotificationPublisherTyped(INotifiableContainer<NotificationItemTyped> notifiableContainer)
    {
        _notifiableContainer = notifiableContainer;
    }

    public void AddNotification(NotificationItemTyped notification)
    {
        _notifiableContainer.AddNotification(notification);
    }

    public void AddNotifications(List<NotificationItemTyped> notifications)
    {
        _notifiableContainer.AddNotifications(notifications);
    }
}