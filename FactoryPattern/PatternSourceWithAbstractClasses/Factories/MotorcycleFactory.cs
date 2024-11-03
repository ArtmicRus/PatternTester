using FactoryPattern.PatternSourceWithAbstractClasses.Abstracts;
using FactoryPattern.PatternSourceWithAbstractClasses.Objects;

namespace FactoryPattern.PatternSourceWithAbstractClasses.Factories
{
    /// <summary>
    /// Фабрика создания мотоциклов
    /// </summary>
    internal class MotorcycleFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }
}
