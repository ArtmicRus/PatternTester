using FactoryPattern.PatternSourceWithAbstractClasses.Abstracts;
using FactoryPattern.PatternSourceWithAbstractClasses.Objects;

namespace FactoryPattern.PatternSourceWithAbstractClasses.Factories
{
    /// <summary>
    /// Фабрика создания машин
    /// </summary>
    internal class CarFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
