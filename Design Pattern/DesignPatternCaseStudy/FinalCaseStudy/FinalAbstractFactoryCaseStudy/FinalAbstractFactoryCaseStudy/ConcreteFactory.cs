﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalAbstractFactoryCaseStudy
{
    public class ConcreteFactory : Factory
    {
        public void MakeElectronicOrder(Channel channel, ProductType productType)
        {
            new ElectronicOrder(productType, channel);
        }

        public void MakeFurnitureOrder(Channel channel, ProductType productType)
        {
            new FurnitureOrder(productType, channel);
        }

        public void MakeToyOrder(Channel channel, ProductType productType)
        {
            new ToyOrder(productType, channel);
        }
    }
}
