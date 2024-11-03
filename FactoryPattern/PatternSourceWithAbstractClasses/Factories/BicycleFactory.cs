using FactoryPattern.PatternSourceWithAbstractClasses.Abstracts;
using FactoryPattern.PatternSourceWithAbstractClasses.Objects;

namespace FactoryPattern.PatternSourceWithAbstractClasses.Factories
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
