using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Vehicles
{
    public class Bus: IVehicle
    {
        public string Name { get; } = "Bus";
    }
}
