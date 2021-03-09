using DesignPatterns.AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class NoMotorVehicleFactory : IVehicleFactory
    {
        public IVehicle Create(VehicleFilter filter)
        {
            switch (filter.NumberOfWheels)
            {
                case 1:
                    return new Unicycle();
                case 2:
                    return new Bicycle();
                case 3: 
                    return new Tricycle();
                default:
                    return new Bicycle();
            }
        }
    }
}
