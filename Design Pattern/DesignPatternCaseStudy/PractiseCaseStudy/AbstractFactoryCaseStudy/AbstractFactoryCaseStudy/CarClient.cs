using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryCaseStudy
{
    class CarClient
    {
        CarFactory carfactory;
        public CarClient(CarFactory carFactory)
        {
            carfactory = carFactory;
        }
        public void BuildMicroCar(Location location)
        {
            carfactory.MakeMicroCar(location, CarType.MICRO);
        }
        public void BuildMiniCar(Location location)
        {
            carfactory.MakeMiniCar(location, CarType.MINI);
        }
        public void BuildLuxuryCar(Location location)
        {
            carfactory.MakeLuxuryCar(location, CarType.LUXURY);

        }
    }
}
