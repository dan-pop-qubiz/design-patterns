using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Vehicles
{
    public class Bicycle: IVehicle
    {
        public string Name { get; } = "Bicycle";
    }
}
