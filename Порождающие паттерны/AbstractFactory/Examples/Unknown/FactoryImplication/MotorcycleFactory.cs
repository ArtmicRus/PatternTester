using AbstractFactory.Examples.Unknown.EngineImplications;
using AbstractFactory.Examples.Unknown.Interfaces;
using AbstractFactory.Examples.Unknown.VehicleImplications;

namespace AbstractFactory.Examples.Unknown.FactoryImplication
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
