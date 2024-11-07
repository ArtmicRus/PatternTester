using AbstractFactory.EngineImplications;
using AbstractFactory.Interfaces;
using AbstractFactory.VehicleImplications;

namespace AbstractFactory.FactoryImplication
{
    internal class MotorcycleFactory : IFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }

        public IEngine CreateEngine()
        {
            return new MotorcycleEngine();
        }
    }
}
