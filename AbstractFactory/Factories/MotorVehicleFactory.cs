using DesignPatterns.AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class MotorVehicleFactory : IVehicleFactory
    {
        public IVehicle Create(VehicleFilter filter)
        {
            if (filter.NumberOfWheels <= 3)
            {
                return new MotorCycle();
            }

            if (filter.HasCargo)
            {
                if (filter.NumberOfWheels > 4)
                {
                    return new Truck();
                }
                return new Van();
            }

            if (filter.NumberOfPassengers < 4)
            {
                return new SportsCar();
            }
            if (filter.NumberOfPassengers > 5)
            {
                return new Bus();
            }
            return new Sedan();
        }
    }
}
