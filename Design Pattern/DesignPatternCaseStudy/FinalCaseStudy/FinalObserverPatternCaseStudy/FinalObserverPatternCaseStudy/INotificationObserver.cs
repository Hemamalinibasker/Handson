using System;
using System.Collections.Generic;
using System.Text;

namespace FinalObserverPatternCaseStudy
{
    public interface INotificationObserver
    {
        string Name { get; }
        void TicketsBooked();
    }
}
