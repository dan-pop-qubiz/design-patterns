using DesignPatterns.AbstractFactory.Vehicles;

namespace DesignPatterns.AbstractFactory
{
    public interface IVehicleFactory
    {
        IVehicle Create(VehicleFilter filter);
    }
}
