using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Consumer;
using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Container;
using Olizia.Libraries.DesignPatterns.Notification.NotificationItems;

namespace Olizia.Libraries.DesignPatterns.Notification.Consumers;

public class NotificationConsumerStandard : INotificationConsumer<NotificationItemStandard>
{
    private NotifiableContainerBase<NotificationItemStandard> _notifiableContainer;

    public NotificationConsumerStandard(NotifiableContainerBase<NotificationItemStandard> notifiableContainer)
    {
        _notifiableContainer = notifiableContainer;
    }

    public List<NotificationItemStandard> GetNotifications()
    {
        return _notifiableContainer.GetNotifications();
    }
}
