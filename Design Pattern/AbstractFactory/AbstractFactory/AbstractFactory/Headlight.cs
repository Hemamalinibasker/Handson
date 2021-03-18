using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    
    public abstract class Headlight
    {
        public interface IHeadlight
        {
            void headlight();
        }
        public class AudiHeadlight : IHeadlight
        {
            public void headlight()
            {
                Console.WriteLine("Audi Headlight");
            }
        }
        public class MercedesHeadlight : IHeadlight
        {
            public void headlight()
            {
                Console.WriteLine("Mercedes Headlight");
            }
        }
    }
}
