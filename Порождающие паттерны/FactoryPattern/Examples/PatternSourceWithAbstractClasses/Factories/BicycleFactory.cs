using FactoryPattern.Examples.PatternSourceWithAbstractClasses.Abstracts;
using FactoryPattern.Examples.PatternSourceWithAbstractClasses.Objects;
using FactoryPattern.PatternSourceWithAbstractClasses.Abstracts;

namespace FactoryPattern.Examples.PatternSourceWithAbstractClasses.Factories
{
    /// <summary>
    /// Фабрика создания велосипедов
    /// </summary>
    internal class BicycleFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Bicycle();
        }
    }
}
