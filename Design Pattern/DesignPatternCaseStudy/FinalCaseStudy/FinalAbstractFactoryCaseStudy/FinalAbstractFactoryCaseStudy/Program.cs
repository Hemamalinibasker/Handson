using System;

namespace FinalAbstractFactoryCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory fact = new ConcreteFactory();
            ClientOrder client = new ClientOrder(fact);
            client.BuildElectronicOrder(Channel.Ecommerce); 
            client.BuildFurnitureOrder(Channel.Tele);           
            client.BuildToyOrder(Channel.Ecommerce);          
            Console.ReadKey();
        }
    }
}
