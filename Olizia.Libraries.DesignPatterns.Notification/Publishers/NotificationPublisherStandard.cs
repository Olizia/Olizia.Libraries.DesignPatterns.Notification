﻿using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Container;
using Olizia.Libraries.DesignPatterns.Notification.Abstractions.Publisher;
using Olizia.Libraries.DesignPatterns.Notification.NotificationItems;

namespace Olizia.Libraries.DesignPatterns.Notification.Publishers;

public class NotificationPublisherStandard : INotificationPublisher<NotificationItemStandard>
{
    private NotifiableContainerBase<NotificationItemStandard> _notifiableContainer;

    public NotificationPublisherStandard(NotifiableContainerBase<NotificationItemStandard> notifiableContainer)
    {
        _notifiableContainer = notifiableContainer;
    }

    public void AddNotification(NotificationItemStandard notification)
    {
        _notifiableContainer.AddNotification(notification);
    }

    public void AddNotifications(List<NotificationItemStandard> notifications)
    {
        _notifiableContainer.AddNotifications(notifications);
    }
}