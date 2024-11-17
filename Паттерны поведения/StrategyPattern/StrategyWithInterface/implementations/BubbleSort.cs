using StrategyPattern.StrategyWithInterface.Interfaces;

namespace StrategyPattern.StrategyWithInterface.implementations
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
