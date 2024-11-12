using StrategyPattern.StrategyWithInterface.Interfaces;

namespace StrategyPattern.StrategyWithInterface.implementations
{
    /// <summary>
    /// Сортировка пузырьком
    /// </summary>
    internal class BubbleSort : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("BubbleSort correct");
        }
    }
}
