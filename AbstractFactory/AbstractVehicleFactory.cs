using DesignPatterns.AbstractFactory.Vehicles;

namespace DesignPatterns.AbstractFactory
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IVehicle Create();
    }
}
