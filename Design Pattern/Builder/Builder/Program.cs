using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create director and builders

            Sweet director = new Sweet();

            Builder b1 = new ConcreteChild();
            Builder b2 = new ConcreteAdult();
            Console.WriteLine("\nSweet Shop");
            // Construct two products

            director.Construct(b1);
            Console.WriteLine("\nChild Package");
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Console.WriteLine("\nAdult Package");
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user

            Console.ReadLine();
        }
    }
}
