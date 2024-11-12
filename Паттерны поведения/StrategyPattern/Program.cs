using StrategyPattern.StrategyWithInterface;
using StrategyPattern.StrategyWithInterface.implementations;

internal class Program
{
    private static void Main(string[] args)
    {
        // Паттерн Стратегия(Strategy) представляет шаблон проектирования,
        // который определяет набор алгоритмов, инкапсулирует каждый из них и обеспечивает их взаимозаменяемость.
        // В зависимости от ситуации мы можем легко заменить один используемый алгоритм другим.
        // При этом замена алгоритма происходит независимо от объекта, который использует данный алгоритм.
        PeopleSorter pip = new PeopleSorter(new BubbleSort());
        pip.Sort();

        pip.SortStrategy = new ShakerSort();
        pip.Sort();
    }
}