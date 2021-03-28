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