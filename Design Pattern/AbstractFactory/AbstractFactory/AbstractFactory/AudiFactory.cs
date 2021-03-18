using System;
using static AbstractFactory.Headlight;
using static AbstractFactory.Tire;

namespace AbstractFactory
{
    
    public class AudiFactory : Factory
    {
        public override IHeadlight makeHeadlight()
        {
            return new AudiHeadlight();
        }
        public override ITire makeTire()
        {
            return new AudiTire();
        }
    }
}
