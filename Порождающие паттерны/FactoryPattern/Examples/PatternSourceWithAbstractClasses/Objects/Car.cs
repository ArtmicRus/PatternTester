using FactoryPattern.Examples.PatternSourceWithAbstractClasses.Abstracts;

namespace FactoryPattern.PatternSourceWithAbstractClasses.Objects
{
    /// <summary>
    /// Объект машины
    /// </summary>
    internal class Car : Vehicle
    {
        /// <inheritdoc/>
        public override void Drive()
        {
            Console.WriteLine("Еду на машине");
        }
    }
}
