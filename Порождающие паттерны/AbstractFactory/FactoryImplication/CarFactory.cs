using AbstractFactory.EngineImplications;
using AbstractFactory.Interfaces;
using AbstractFactory.VehicleImplications;

namespace AbstractFactory.FactoryImplication
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
