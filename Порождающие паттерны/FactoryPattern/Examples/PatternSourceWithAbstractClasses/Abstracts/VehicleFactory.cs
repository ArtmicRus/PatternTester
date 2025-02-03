using FactoryPattern.Examples.PatternSourceWithAbstractClasses.Abstracts;

namespace FactoryPattern.PatternSourceWithAbstractClasses.Abstracts
{
    /// <summary>
    /// Фабрика по созданию колёсных транспортных средств
    /// </summary>
    abstract class VehicleFactory
    {
        /// <summary>
        /// Метод создания велосипеда
        /// </summary>
        /// <returns>Созданный объект транспортного средства</returns>
        public abstract Vehicle CreateVehicle();
    }
}
