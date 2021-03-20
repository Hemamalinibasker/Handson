using System;

namespace FinalObserverPatternCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
                AdminObserver1 admin1 = new AdminObserver1();
                AdminObserver2 admin2 = new AdminObserver2();

                NotificationService service = new NotificationService();
                service.AddSubscriber(admin1);
                service.AddSubscriber(admin2);
                service.TicketsBooked(105);
                service.RemoveSubscriber(admin2);
                Console.ReadLine();
            }
        }
    }

