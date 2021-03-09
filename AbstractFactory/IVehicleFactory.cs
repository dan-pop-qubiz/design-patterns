using DesignPatterns.AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public interface IVehicleFactory
    {
        IVehicle Create(VehicleFilter filter);
    }
}
