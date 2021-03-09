using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Vehicles
{
    public class Sedan : IVehicle
    {
        public string Name { get; } = "Sedan";
    }
}
