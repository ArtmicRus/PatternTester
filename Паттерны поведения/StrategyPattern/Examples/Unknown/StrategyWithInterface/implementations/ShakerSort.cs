using StrategyPattern.Examples.Unknown.StrategyWithInterface.Interfaces;

namespace StrategyPattern.Examples.Unknown.StrategyWithInterface.implementations
{
    /// <summary>
    /// Сортировка перемешиванием
    /// </summary>
    internal class ShakerSort : ISortStrategy
    {
        /// <inheritdoc/>
        public void Sort()
        {
            Console.WriteLine("ShakerSort correct");
        }
    }
}
