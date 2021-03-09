using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Vehicles
{
    public class MotorCycle: IVehicle
    {
        public string Name { get; } = "MotorCycle";
    }
}
