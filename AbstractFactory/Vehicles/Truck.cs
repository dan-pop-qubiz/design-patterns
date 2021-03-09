using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Vehicles
{
    public class Truck: IVehicle
    {
        public string Name { get; } = "Truck";
    }
}
