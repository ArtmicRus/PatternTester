using FactoryPattern.Examples.PatternSourceWithAbstractClasses.Abstracts;

namespace FactoryPattern.Examples.PatternSourceWithAbstractClasses.Objects
{
    /// <summary>
    /// Объект велосипеда
    /// </summary>
    internal class Bicycle : Vehicle
    {
        /// <inheritdoc/>
        public override void Drive()
        {
            Console.WriteLine("Катаюсь на велосипеде");
        }
    }
}
