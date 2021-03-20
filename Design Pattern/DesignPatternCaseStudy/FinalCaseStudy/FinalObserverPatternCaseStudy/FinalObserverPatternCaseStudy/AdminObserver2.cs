﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalObserverPatternCaseStudy
{
    class AdminObserver2 : INotificationObserver
    {
        public string Name { get { return "Admin2"; } }
        public void TicketsBooked()
        {
            Console.WriteLine(Name + " 100 Tickets are booked");
        }
    }
}
