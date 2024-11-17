using StrategyPattern.StrategyWithInterface.Interfaces;

namespace StrategyPattern.StrategyWithInterface.implementations
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
