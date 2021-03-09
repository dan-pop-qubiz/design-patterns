using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class VehicleFilter
    {
        public bool HasEngine { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfPassengers { get; set; }
        public bool HasCargo { get; set; }
    }
}
