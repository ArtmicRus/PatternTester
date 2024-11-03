using FactoryPattern.PatternSourceWithAbstractClasses.Abstracts;

namespace FactoryPattern.PatternSourceWithAbstractClasses.Objects
{
    /// <summary>
    /// Объект мотоцикла
    /// </summary>
    internal class Motorcycle : Vehicle
    {
        /// <inheritdoc/>
        public override void Drive()
        {
            Console.WriteLine("Еду на мотоцикле");
        }
    }
}
