using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Vehicles;

namespace DesignPatterns.AbstractFactory
{
    public class VehicleFactory : AbstractVehicleFactory
    {
        private readonly IVehicleFactory factory;
        private readonly VehicleFilter filter;

        public VehicleFactory(VehicleFilter filter)
        {
            this.filter = filter;
            factory = filter.HasEngine ? (IVehicleFactory) new MotorVehicleFactory() : new NoMotorVehicleFactory();
        }

        public override IVehicle Create()
        {
            return factory.Create(filter);
        }
    }
}