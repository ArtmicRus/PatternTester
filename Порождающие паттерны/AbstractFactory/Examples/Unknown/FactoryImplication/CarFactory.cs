using AbstractFactory.Examples.Unknown.EngineImplications;
using AbstractFactory.Examples.Unknown.Interfaces;
using AbstractFactory.Examples.Unknown.VehicleImplications;

namespace AbstractFactory.Examples.Unknown.FactoryImplication
{
    /// <summary>
    /// Фабрика комплексного создания объекта Car
    /// </summary>
    internal class CarFactory : IFactory
    {
        /// <inheritdoc/>
        public IVehicle CreateVehicle()
        {
            return new Car();
        }

        /// <inheritdoc/>
        public IEngine CreateEngine()
        {
            return new CarEngine();
        }
    }
}
