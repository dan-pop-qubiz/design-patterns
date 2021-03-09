using DesignPatterns.AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IVehicle Create();
    }
}
