using FactoryPattern.PatternSourceWithAbstractClasses.Abstracts;

namespace FactoryPattern.PatternSourceWithAbstractClasses.Objects
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
