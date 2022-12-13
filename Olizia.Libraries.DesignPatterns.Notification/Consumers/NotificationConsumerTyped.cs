using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Consumer;
using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Container;
using Olizia.Libraries.DesignPatterns.Notification.NotificationItems;

namespace Olizia.Libraries.DesignPatterns.Notification.Consumers;

public class NotificationConsumerTyped : INotificationConsumer<NotificationItemTyped>
{
    private NotifiableContainerBase<NotificationItemTyped> _notifiableContainer;

    public NotificationConsumerTyped(NotifiableContainerBase<NotificationItemTyped> notifiableContainer)
    {
        _notifiableContainer = notifiableContainer;
    }

    public List<NotificationItemTyped> GetNotifications()
    {
        return _notifiableContainer.GetNotifications();
    }
}
