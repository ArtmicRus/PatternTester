using StrategyPattern.Examples.Unknown.StrategyWithInterface.Interfaces;

namespace StrategyPattern.Examples.Unknown.StrategyWithInterface.implementations
{
    /// <summary>
    /// Сортировка пузырьком
    /// </summary>
    internal class BubbleSort : ISortStrategy
    {
        /// <inheritdoc/>
        public void Sort()
        {
            Console.WriteLine("BubbleSort correct");
        }
    }
}
