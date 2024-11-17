using AbstractFactory.EngineImplications;
using AbstractFactory.Interfaces;
using AbstractFactory.VehicleImplications;

namespace AbstractFactory.FactoryImplication
{
    /// <summary>
    /// Фабрика комплексного создания объекта Motorcycle
    /// </summary>
    internal class MotorcycleFactory : IFactory
    {
        /// <inheritdoc/>
        public IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }

        /// <inheritdoc/>
        public IEngine CreateEngine()
        {
            return new MotorcycleEngine();
        }
    }
}
