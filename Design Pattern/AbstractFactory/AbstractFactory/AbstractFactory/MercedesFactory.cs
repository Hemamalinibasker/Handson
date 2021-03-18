using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactory.Headlight;
using static AbstractFactory.Tire;

namespace AbstractFactory
{
    
    public class MercedesFactory : Factory
    {
        public override IHeadlight makeHeadlight()
        {
            return new MercedesHeadlight();
        }
        public override ITire makeTire()
        {
            return new MercedesTire();
        }
    }
}
