using StrategyPattern.StrategyWithInterface;
using StrategyPattern.StrategyWithInterface.implementations;

internal class Program
{
    private static void Main(string[] args)
    {
        PeopleSorter pip = new PeopleSorter(new BubbleSort());
        pip.Sort();

        pip.SortStrategy = new ShakerSort();
        pip.Sort();



    }
}