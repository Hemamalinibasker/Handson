﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalObserverPatternCaseStudy
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);
        void RemoveSubscriber(INotificationObserver observer);
        void NotifySubscriber();
    }
}
