using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Vehicles
{
    public class SportsCar : IVehicle
    {
        public string Name { get; } = "SportsCar";
    }
}
