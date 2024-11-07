using AbstractFactory.EngineImplications;
using AbstractFactory.Interfaces;
using AbstractFactory.VehicleImplications;

namespace AbstractFactory.FactoryImplication
{
    internal class CarFactory : IFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }

        public IEngine CreateEngine()
        {
            return new CarEngine();
        }
    }
}
