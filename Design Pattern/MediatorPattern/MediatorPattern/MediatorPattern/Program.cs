using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chat = new ChatMediator();
            IUser user1 = new PremiumUser() { Name = "user1" };
            IUser user2 = new BasicUser() { Name = "user2" };
            IUser user3 = new BasicUser() { Name = "user3" };

            chat.AddUser(user1);
            chat.AddUser(user2);
            chat.AddUser(user3);



            chat.SendMessage(user1, "Hii");
            chat.SendMessage(user3, "Hello");
            Console.ReadLine();

            Console.ReadLine();
            }
        }
    }
